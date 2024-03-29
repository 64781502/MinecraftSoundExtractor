﻿using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Media;
using System.Threading;

namespace minecraftsoundextractor
{
    public partial class GUIForm : Form
    {
        public GUIForm()
        {
            InitializeComponent();
        }

        private void ExtractButton_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\assets\indexes", "*.json", SearchOption.AllDirectories);
            string[] version = files.OrderByDescending(a => a).ToArray();
            string read = File.ReadAllText(version[0]).Substring(12);

            if (JObject.Parse(read.Substring(0, read.Length - 1)).ContainsKey(IDBox.Text))
            {
                var hash = JObject.Parse(File.ReadAllText(version[0]))["objects"][IDBox.Text]["hash"];
                string dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\assets\objects\" + hash.ToString().Substring(0, 2) + @"\" + hash.ToString();
                string ext;
                int from = IDBox.Text.IndexOf("minecraft/sounds/") + "minecraft/sounds/".Length;
                int ogg = IDBox.Text.LastIndexOf(".ogg");

                if (RadioOgg.Checked) {
                    ext = ".ogg";
                }
                else if (RadioMp3.Checked) {
                    ext = ".mp3";
                }
                else {
                    ext = ".wav";
                }

                try
                {
                    if (PlayBox.Checked)
                    {
                        string[] path = Environment.GetEnvironmentVariable("PATH").Split(';');

                        if (!string.Join(" ", path).Contains("ffmpeg"))
                        {
                            MessageBox.Show("Ffmpeg not installed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            File.Copy(dir, Path.GetTempPath() + "temp.ogg");
                            Process.Start("cmd.exe", "/c ffmpeg -i " + Path.GetTempPath() + "temp.ogg " + Path.GetTempPath() + "play.wav");
                            Thread.Sleep(200);
                            new SoundPlayer(Path.GetTempPath() + "play.wav").Play();
                        }
                    }
                }
                catch (IOException) //stupid
                {
                    File.Delete(Path.GetTempPath() + "temp.ogg");
                    File.Delete(Path.GetTempPath() + "play.wav");
                    File.Copy(dir, Path.GetTempPath() + "temp.ogg");
                    Process.Start("cmd.exe", "/c ffmpeg -i " + Path.GetTempPath() + "temp.ogg " + Path.GetTempPath() + "play.wav");
                    Thread.Sleep(200);
                    new SoundPlayer(Path.GetTempPath() + "play.wav").Play();

                }
                catch (Exception)
                {
                    MessageBox.Show("Unknown error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    string name = IDBox.Text.Substring(from, ogg - from);
                    File.Copy(dir, custompath.Text + @"\" + name.Replace("/", ".") + ext);
                    MessageBox.Show("Sound extracted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    File.Delete(Path.GetTempPath() + "temp.ogg");
                    File.Delete(Path.GetTempPath() + "play.wav");
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("ID is not sound.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IOException)
                {
                    MessageBox.Show("File already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Unknown error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
   
            }
            else if (!JObject.Parse(read.Substring(0, read.Length - 1)).ContainsKey(IDBox.Text))
            {
                MessageBox.Show("ID doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Directory.Exists(Environment.SpecialFolder.ApplicationData + @"\.minecraft"))
            {
                MessageBox.Show("Minecraft folder doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Unknown error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RadioCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioCustom.Checked)
            {
                FolderBrowserDialog folderDlg = new FolderBrowserDialog { ShowNewFolderButton = true };
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    custompath.Text = folderDlg.SelectedPath;
                }
            }
        }

        private Point lastPoint;
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e) { lastPoint = new Point(e.X, e.Y); }
        private void RadioDesktop_CheckedChanged(object sender, EventArgs e) { custompath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); }
        private void RadioDownl_CheckedChanged(object sender, EventArgs e) { custompath.Text = @"C:\Users\" + Environment.UserName + @"\Downloads"; }
        private void GUIForm_Load(object sender, EventArgs e) { custompath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); }
    }
}
