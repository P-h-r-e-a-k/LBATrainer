﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBATrainer
{
    public partial class frmTrainer
    {
        const ushort LBA1_Offset_Key = 0xE26;
        private HotKey hotkeyF7;
        //private HotKey hotkeyF8;
        private HotKey hotkeyF9;
        ItemCheckedEventHandler icehLVLBA1SGChecked;

        private void Savegame_Load(object sender, EventArgs e, Options opt)
        {
            txtLBA1SaveFileDirectory.Text = opt.LBADir;
            icehLVLBA1SGChecked = new System.Windows.Forms.ItemCheckedEventHandler(this.LvLBA1SaveGames_ItemChecked);
        }
        private void Savegame_FormClosed(object sender, FormClosedEventArgs e)
        {
            unregisterHotkeys();
        }
        private void LBA1SGLoadSaves()
        {
            this.lvLBA1SaveGames.ItemChecked -= icehLVLBA1SGChecked;
            lvLBA1SaveGames.Items.Clear();
            if (string.IsNullOrEmpty(txtLBA1SaveFileDirectory.Text)) return;
            if (string.IsNullOrWhiteSpace(txtLBA1SaveFileDirectory.Text)) return;
            if (!System.IO.Directory.Exists(txtLBA1SaveFileDirectory.Text)) return;
            string[] filePaths = Directory.GetFiles(txtLBA1SaveFileDirectory.Text, "*.lba");
            ListViewItem lviFile;
            FileInfo fi;
            for (int i = 0; i < filePaths.Length; i++)
            {
                lviFile = new ListViewItem();
                fi = new FileInfo(filePaths[i]);
                fi.LastWriteTime.ToString();
                lviFile.Checked = new FileInfo(filePaths[i]).IsReadOnly;
                lviFile.SubItems.Add(getLBA1FriendlyFileName(filePaths[i]));
                lviFile.SubItems.Add(fi.LastWriteTime.ToString());
                lviFile.Tag = filePaths[i];
                lvLBA1SaveGames.Items.Add(lviFile);
            }
            this.lvLBA1SaveGames.ItemChecked += icehLVLBA1SGChecked;
            lvLBA1SaveGames.Columns[0].Width = -2;
            lvLBA1SaveGames.Columns[2].Width = -2;
        }
        private void BtnLBA1SaveGameEnableDisable_Click(object sender, EventArgs e)
        {
            LBA1SGLoadSaves();

            if (null == hotkeyF7 || null == hotkeyF9)
            {
                registerHotKeys();
                btnLBA1SaveGameEnableDisable.Text = "Disable";
            }
            else
            {
                unregisterHotkeys();
                btnLBA1SaveGameEnableDisable.Text = "Enable";
            }

        }
        protected override void WndProc(ref Message keyPressed)
        {
            if (keyPressed.Msg == 0x0312)
            {
                if (118 == (int)keyPressed.WParam)
                {
                    SaveGame sg = new SaveGame();
                    if (!sg.save(txtLBA1SaveFileDirectory.Text)) MessageBox.Show("Unable to save game, is DOSBox running?");
                }
                /*if (119 == (int)keyPressed.WParam)
                    MessageBox.Show("F8");*/
                //Add a key :-)
                if (120 == (int)keyPressed.WParam)
                    memRoutines.WriteVal(LBA_ONE, LBA1_Offset_Key, 1, 1);
            }
            base.WndProc(ref keyPressed);
        }

        //changes the status of the file pointed to by filePath and returns the new status
        private bool toggleReadOnly(string filePath)
        {
            FileInfo fi = new FileInfo(filePath);
            fi.IsReadOnly = !fi.IsReadOnly;
            fi.Refresh();
            return fi.IsReadOnly;
        }
        private void LvLBA1SaveGames_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            e.Item.Checked = toggleReadOnly((string)e.Item.Tag);
        }

        private void BtnLBA1SGRefresh_Click(object sender, EventArgs e)
        {
            LBA1SGLoadSaves();
        }
        private string getLBA1FriendlyFileName(string filePath)
        {
            if (!File.Exists(filePath)) return null;
            FileStream fsStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            char b = (char)fsStream.ReadByte();//Read and discard the opening byte (03)
            string friendlyName = "";

            while (0 != (b = (char)fsStream.ReadByte()))
                friendlyName += b;

            fsStream.Close();
            fsStream.Dispose();
            return friendlyName;
        }
        private void BtnSetSaveFileDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdLBADir = new FolderBrowserDialog();
            fbdLBADir.ShowDialog();
            txtLBA1SaveFileDirectory.Text = fbdLBADir.SelectedPath;
            fbdLBADir.Dispose();
            Options opt = new Options();
            opt.LBADir = txtLBA1SaveFileDirectory.Text;
            opt.save();
        }

        private void unregisterHotkeys()
        {
            try
            {
                if (null != hotkeyF7)
                {
                    hotkeyF7.UnRegisterHotKeys();
                    hotkeyF7 = null;
                }
                //hotkeyF8.UnRegisterHotKeys();
                if (null != hotkeyF9)
                {
                    hotkeyF9.UnRegisterHotKeys();
                    hotkeyF9 = null;
                }
            }
            catch { };
        }

        private void registerHotKeys()
        {
            hotkeyF7 = new HotKey(this.Handle);
            hotkeyF7.RegisterHotKeys((int)Keys.F7, (uint)Keys.F7);
            /*
            hotkeyF8 = new HotKey(this.Handle);
            hotkeyF8.RegisterHotKeys((int)Keys.F8, (uint)Keys.F8);*/
            hotkeyF9 = new HotKey(this.Handle);
            hotkeyF9.RegisterHotKeys((int)Keys.F9, (uint)Keys.F9);
        }
    }
}