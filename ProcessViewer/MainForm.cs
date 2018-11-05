using ComponentOwl.BetterListView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProcessView
{
    public partial class MainForm : Form
    {
        private List<string> knownProcesses = new List<string>();
        private List<string> hiddenProcesses = new List<string>();
        private string fileDirectory;
        private string knownFilePath;
        private string hiddenFilePath;

        public MainForm()
        {
            InitializeComponent();

            fileDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
            knownFilePath = Path.Combine(fileDirectory, "known");
            hiddenFilePath = Path.Combine(fileDirectory, "hidden");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadConfig();

            ReLoadProcesses();
        }

        private void LoadConfig()
        {
            if (File.Exists(knownFilePath))
            {
                knownProcesses = File.ReadAllLines(knownFilePath).ToList();
            }

            if (File.Exists(hiddenFilePath))
            {
                hiddenProcesses = File.ReadAllLines(hiddenFilePath).ToList();
            }
        }

        private void SaveConfig()
        {
            if (!Directory.Exists(fileDirectory))
            {
                Directory.CreateDirectory(fileDirectory);
            }

            File.WriteAllLines(knownFilePath, knownProcesses.ToArray());
            File.WriteAllLines(hiddenFilePath, hiddenProcesses.ToArray());
        }

        private void ReLoadProcesses()
        {
            betterListView1.Items.Clear();

            List<BetterListViewItem> result = new List<BetterListViewItem>();
            Process[] ps = Process.GetProcesses().OrderBy(i => i.ProcessName).ToArray();

            foreach (Process p in ps)
            {
                if (ckDoNotDisplayHidden.Checked && hiddenProcesses.Contains(p.ProcessName.ToUpper()))
                    continue;

                if (ckHideKnown.Checked && knownProcesses.Contains(p.ProcessName.ToUpper()))
                    continue;

                var filePath = WinAPI.GetExecutablePath(p);

                var item = new BetterListViewItem(WinAPI.GetFileIconImage(filePath), p.ProcessName);
                item.SubItems.Add(p.Id.ToString());
                item.SubItems.Add(filePath);
                //item.SubItems.Add(p.MainModule.FileVersionInfo.FileDescription);

                if (knownProcesses.Contains(p.ProcessName.ToUpper()))
                {
                    item.ForeColor = Color.Gray;
                }

                result.Add(item);
            }

            betterListView1.Items.AddRange(result);
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (betterListView1.SelectedItems.Count > 0)
            {
                var item = betterListView1.SelectedItems[0];

                switch (e.ClickedItem.Tag.ToString())
                {
                    case "known":
                        {
                            knownProcesses.Add(item.Text.ToUpper());
                            SaveConfig();

                            if (ckHideKnown.Checked)
                            {
                                List<BetterListViewItem> toRemove = new List<BetterListViewItem>();

                                foreach (var i in betterListView1.Items)
                                {
                                    if (i.Text.ToUpper() == item.Text.ToUpper())
                                    {
                                        toRemove.Add(i);
                                    }
                                }

                                betterListView1.Items.RemoveRange(toRemove);
                            }
                            else
                            {
                                foreach (var i in betterListView1.Items)
                                {
                                    if (i.Text.ToUpper() == item.Text.ToUpper())
                                    {
                                        i.ForeColor = Color.Gray;
                                    }
                                }
                            }

                            break;
                        }
                    case "hidden":
                        {
                            hiddenProcesses.Add(item.Text.ToUpper());
                            SaveConfig();

                            if (ckDoNotDisplayHidden.Checked)
                            {
                                List<BetterListViewItem> toRemove = new List<BetterListViewItem>();
                                foreach (var i in betterListView1.Items)
                                {
                                    if (i.Text.ToUpper() == item.Text.ToUpper())
                                    {
                                        toRemove.Add(i);
                                    }
                                }

                                betterListView1.Items.RemoveRange(toRemove);
                            }

                            break;
                        }
                    case "kill":
                        {
                            var pid = Convert.ToInt32(item.SubItems[1].Text);
                            var process = Process.GetProcesses().Where(p => p.Id == pid);
                            if (process.Any())
                            {
                                try
                                {
                                    process.First().Kill();
                                    betterListView1.Items.Remove(item);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            break;
                        }
                    case "location":
                        {
                            var file = item.SubItems[2].Text.ToString();
                            if (!string.IsNullOrEmpty(file) && File.Exists(file))
                            {
                                Process.Start("explorer.exe", "/select," + file);
                            }
                            break;
                        }
                }
            }
        }

        private void ckHideKnown_CheckedChanged(object sender, EventArgs e)
        {
            ReLoadProcesses();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ReLoadProcesses();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReLoadProcesses();
        }
    }
}
