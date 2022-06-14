namespace minecraftsoundextractor
{
    partial class GUIForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIForm));
            this.ExtractButton = new System.Windows.Forms.Button();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RadioMp3 = new System.Windows.Forms.RadioButton();
            this.RadioWav = new System.Windows.Forms.RadioButton();
            this.RadioOgg = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RadioCustom = new System.Windows.Forms.RadioButton();
            this.RadioDownl = new System.Windows.Forms.RadioButton();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.custompath = new System.Windows.Forms.Label();
            this.RadioDesktop = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlayBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExtractButton
            // 
            this.ExtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExtractButton.Location = new System.Drawing.Point(190, 293);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(111, 30);
            this.ExtractButton.TabIndex = 1;
            this.ExtractButton.Text = "Extract";
            this.ExtractButton.UseVisualStyleBackColor = true;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // IDBox
            // 
            this.IDBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IDBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.IDBox.Location = new System.Drawing.Point(26, 63);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(427, 22);
            this.IDBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter ID:";
            // 
            // RadioMp3
            // 
            this.RadioMp3.AutoSize = true;
            this.RadioMp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioMp3.Location = new System.Drawing.Point(210, 146);
            this.RadioMp3.Name = "RadioMp3";
            this.RadioMp3.Size = new System.Drawing.Size(52, 20);
            this.RadioMp3.TabIndex = 0;
            this.RadioMp3.Text = "mp3";
            this.RadioMp3.UseVisualStyleBackColor = true;
            // 
            // RadioWav
            // 
            this.RadioWav.AutoSize = true;
            this.RadioWav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadioWav.Location = new System.Drawing.Point(380, 146);
            this.RadioWav.Name = "RadioWav";
            this.RadioWav.Size = new System.Drawing.Size(50, 20);
            this.RadioWav.TabIndex = 1;
            this.RadioWav.Text = "wav";
            this.RadioWav.UseVisualStyleBackColor = true;
            // 
            // RadioOgg
            // 
            this.RadioOgg.AutoSize = true;
            this.RadioOgg.Checked = true;
            this.RadioOgg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadioOgg.Location = new System.Drawing.Point(26, 146);
            this.RadioOgg.Name = "RadioOgg";
            this.RadioOgg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RadioOgg.Size = new System.Drawing.Size(149, 20);
            this.RadioOgg.TabIndex = 2;
            this.RadioOgg.TabStop = true;
            this.RadioOgg.Text = "ogg (recommended)";
            this.RadioOgg.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "extension:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "extract directory:";
            // 
            // RadioCustom
            // 
            this.RadioCustom.AutoSize = true;
            this.RadioCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadioCustom.Location = new System.Drawing.Point(376, 3);
            this.RadioCustom.Name = "RadioCustom";
            this.RadioCustom.Size = new System.Drawing.Size(69, 20);
            this.RadioCustom.TabIndex = 6;
            this.RadioCustom.Text = "custom";
            this.RadioCustom.UseVisualStyleBackColor = true;
            this.RadioCustom.CheckedChanged += new System.EventHandler(this.RadioCustom_CheckedChanged);
            // 
            // RadioDownl
            // 
            this.RadioDownl.AutoSize = true;
            this.RadioDownl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioDownl.Location = new System.Drawing.Point(206, 3);
            this.RadioDownl.Name = "RadioDownl";
            this.RadioDownl.Size = new System.Drawing.Size(92, 20);
            this.RadioDownl.TabIndex = 5;
            this.RadioDownl.Text = "downloads";
            this.RadioDownl.UseVisualStyleBackColor = true;
            this.RadioDownl.CheckedChanged += new System.EventHandler(this.RadioDownl_CheckedChanged);
            // 
            // FolderBrowserDialog
            // 
            this.FolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.Recent;
            // 
            // custompath
            // 
            this.custompath.BackColor = System.Drawing.Color.Transparent;
            this.custompath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.custompath.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.custompath.Location = new System.Drawing.Point(1, 257);
            this.custompath.Name = "custompath";
            this.custompath.Size = new System.Drawing.Size(478, 23);
            this.custompath.TabIndex = 8;
            this.custompath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RadioDesktop
            // 
            this.RadioDesktop.AutoSize = true;
            this.RadioDesktop.Checked = true;
            this.RadioDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadioDesktop.Location = new System.Drawing.Point(22, 3);
            this.RadioDesktop.Name = "RadioDesktop";
            this.RadioDesktop.Size = new System.Drawing.Size(75, 20);
            this.RadioDesktop.TabIndex = 7;
            this.RadioDesktop.TabStop = true;
            this.RadioDesktop.Text = "desktop";
            this.RadioDesktop.UseVisualStyleBackColor = true;
            this.RadioDesktop.CheckedChanged += new System.EventHandler(this.RadioDesktop_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RadioDesktop);
            this.panel1.Controls.Add(this.RadioDownl);
            this.panel1.Controls.Add(this.RadioCustom);
            this.panel1.Location = new System.Drawing.Point(4, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 27);
            this.panel1.TabIndex = 9;
            // 
            // PlayBox
            // 
            this.PlayBox.AutoSize = true;
            this.PlayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayBox.Location = new System.Drawing.Point(130, 299);
            this.PlayBox.Name = "PlayBox";
            this.PlayBox.Size = new System.Drawing.Size(54, 20);
            this.PlayBox.TabIndex = 10;
            this.PlayBox.Text = "Play";
            this.PlayBox.UseVisualStyleBackColor = true;
            // 
            // GUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(480, 334);
            this.Controls.Add(this.PlayBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.custompath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RadioOgg);
            this.Controls.Add(this.RadioWav);
            this.Controls.Add(this.RadioMp3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.ExtractButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GUIForm";
            this.Text = "MinecraftSoundExtractor";
            this.Load += new System.EventHandler(this.GUIForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RadioOgg;
        private System.Windows.Forms.RadioButton RadioWav;
        private System.Windows.Forms.RadioButton RadioMp3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RadioCustom;
        private System.Windows.Forms.RadioButton RadioDownl;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Label custompath;
        private System.Windows.Forms.RadioButton RadioDesktop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox PlayBox;
    }
}

