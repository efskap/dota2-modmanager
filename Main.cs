using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dota2ModManager
{
    public partial class Main : Form
    {
        public const string ModDir = "mods/";
        public string DotaDir = "null";

        List<Mod> actuallyInstalled;

        public Main()
        {
            InitializeComponent();
        }

        void ScanForMods()
        {



            modList.Items.Clear();
            if (!Directory.Exists(ModDir))
                Directory.CreateDirectory(ModDir);
            List<Mod> list = new List<Mod>();
            foreach (var i in Directory.EnumerateDirectories(ModDir))
            {
               list.Add(new Mod(i));

            }
            modList.Items.AddRange(list.OrderBy(x => x.info.order).ToArray());
           



        }
        void CheckIfModsAreInstalled()
        {
            for (int i = 0; i < modList.Items.Count; i++)
            {
                modList.SetItemChecked(i, IsModInstalled((Mod)modList.Items[i]));
            }
            actuallyInstalled = modList.CheckedItems.Cast<Mod>().ToList();

        }
        bool IsModInstalled(Mod m)
        {
            foreach (string file in m.affected_files)
            {
                if (!File.Exists(DotaDir + file))
                {
                    Console.WriteLine(DotaDir + file + "doesnt exit");
                    return false;
                }
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            string steamPath = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", null);

            DotaDir = steamPath + "/steamapps/common/dota 2 beta/dota/";

            label1.Text = "Dota 2 in " + DotaDir;

            ScanForMods();
            CheckIfModsAreInstalled();
        }

        private void modsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modList.SelectedItem == null)
                richTextBox1.Rtf = "";
            else
                richTextBox1.Rtf = ((Mod)modList.SelectedItem).AboutBox();
        }

        private void modsList_MouseClick(object sender, MouseEventArgs e)
        {
            int index = modList.IndexFromPoint(e.Location);

            if (e.X > 15 && index > -1)
                modList.SetItemChecked(index, !modList.GetItemChecked(index));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            applyButton.Enabled = false;
            applyButton.Text = "Deleting old files...";
            //first uninstall unselected mods
            foreach (Mod mod in modList.Items)
            {
                bool ischecked = modList.GetItemChecked(modList.Items.IndexOf(mod));
                if (!ischecked)
                    foreach (string file in mod.affected_files)
                    {
                        if (File.Exists(DotaDir + file))
                        {
                            File.Delete(DotaDir + file);
                            Console.WriteLine("Deleted " + DotaDir + file);
                        }
                    }
            }
            applyButton.Text = "Installing new files...";
            foreach (Mod mod in modList.CheckedItems)
            {
                foreach (string file in mod.affected_files)
                {
                    Directory.CreateDirectory(DotaDir + file.Replace(file.Split('/').Last(), ""));
                    File.Copy(Environment.CurrentDirectory.Replace('\\', '/') + "/" + mod.data_location + "/" + file, DotaDir + file, true);
                    Console.WriteLine("Copied " + file);
                }
            }
            applyButton.Text = "Done!";
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 500;
            timer.Tick += (o, args) =>
            {
                timer.Stop();
                applyButton.Text = "Apply Changes";
            };
            timer.Start();
            applyButton.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string selected = null;

            if (modList.SelectedIndex != -1)
                selected = ((Mod)modList.SelectedItem).data_location;
            ScanForMods();
            CheckIfModsAreInstalled();

            if (selected != null)
            {
                int newindex = -1;
                for (int i = 0; i < modList.Items.Count; i++)
                {
                    if (((Mod)modList.Items[i]).data_location.Equals(selected))
                    {
                        newindex = i;
                        break;
                    }
                }
                modList.SelectedIndex = newindex;
            }

            SaveModOrder();

        }
        void SaveModOrder()
        {
            return;
            //THIS DOESNT WORK
            for (int i = 0; i < modList.Items.Count; i++)
            {
                ((Mod)modList.Items[i]).info.order = i;
                ((Mod)modList.Items[i]).SaveInfo();
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            int si = modList.SelectedIndex;
            if (si < 1)
                return;
            var temp = modList.Items[si - 1];
            modList.Items[si - 1] = modList.Items[si];
            modList.Items[si] = temp;

            modList.SelectedIndex = si - 1;
            SaveModOrder();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            int si = modList.SelectedIndex;
            if (si >= modList.Items.Count - 1 || si < 0)
                return;
            var temp = modList.Items[si + 1];
            modList.Items[si + 1] = modList.Items[si];
            modList.Items[si] = temp;

            modList.SelectedIndex = si + 1;
            SaveModOrder();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void modList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            /*
            if (actuallyInstalled != null)
                applyButton.Font = new Font(applyButton.Font, Enumerable.SequenceEqual<Mod>(actuallyInstalled, modList.CheckedItems.Cast<Mod>().ToList()) ? FontStyle.Bold : FontStyle.Regular);

            */
            //DOESNT WORK
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Path.Combine(Environment.CurrentDirectory, ModDir));
        }




    }
}
