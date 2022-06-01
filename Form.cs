using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace minecraftsoundextractor
{
    public partial class GUIForm : Form
    {
        public GUIForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\assets\indexes", "*.json", SearchOption.AllDirectories);
            string[] item = files.OrderByDescending(a => a).ToArray();

            if (File.ReadAllText(item[0]).Contains(textBox1.Text) && textBox1.Text != "")
            {
                var hash = JObject.Parse(File.ReadAllText(item[0]))["objects"][textBox1.Text]["hash"];
                string dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\assets\objects\" + hash.ToString().Substring(0, 2) + @"\" + hash.ToString();
                string ext;

                if (RadioOgg.Checked) {
                    ext = ".ogg";
                }
                else if (RadioMp3.Checked) {
                    ext = ".mp3";
                }
                else {
                    ext = ".wav";
                }

                File.Copy(dir, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + hash.ToString() + ext);
            }
            else if (!File.ReadAllText(item[0]).Contains(textBox1.Text))
            {
                MessageBox.Show("ID doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Enter ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Directory.Exists(Environment.SpecialFolder.ApplicationData + @"\.minecraft"))
            {
                MessageBox.Show("Minecraft folder doesn't exist in AppData.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
