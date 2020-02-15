namespace theCatalyst
{
    partial class Run
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
            this.skinningManager1 = new NeoGeniX.Skinning.SkinningManager();
            this.darkLabel1 = new NeoGeniX.Controls.DarkLabel();
            this.darkButton1 = new NeoGeniX.Controls.DarkButton();
            this.darkButton2 = new NeoGeniX.Controls.DarkButton();
            this.darkButton3 = new NeoGeniX.Controls.DarkButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.darkTextBox1 = new NeoGeniX.Controls.DarkTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinningManager1
            // 
            this.skinningManager1.DefaultSkin = NeoGeniX.Skinning.DefaultSkin.NeoGeniX;
            this.skinningManager1.MaxBtn = true;
            this.skinningManager1.MinBtn = true;
            this.skinningManager1.ParentForm = null;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(78, 9);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(279, 26);
            this.darkLabel1.TabIndex = 1;
            this.darkLabel1.Text = "Type the name of a program, folder, document, or Internet\r\nresource, and Catalyst" +
    " will open it for you.";
            this.darkLabel1.Click += new System.EventHandler(this.darkLabel1_Click);
            // 
            // darkButton1
            // 
            this.darkButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.darkButton1.Location = new System.Drawing.Point(120, 64);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(75, 23);
            this.darkButton1.TabIndex = 2;
            this.darkButton1.Text = "OK";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // darkButton2
            // 
            this.darkButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.darkButton2.Location = new System.Drawing.Point(201, 64);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton2.Size = new System.Drawing.Size(75, 23);
            this.darkButton2.TabIndex = 3;
            this.darkButton2.Text = "Cancel";
            this.darkButton2.Click += new System.EventHandler(this.darkButton2_Click);
            // 
            // darkButton3
            // 
            this.darkButton3.Location = new System.Drawing.Point(282, 64);
            this.darkButton3.Name = "darkButton3";
            this.darkButton3.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton3.Size = new System.Drawing.Size(75, 23);
            this.darkButton3.TabIndex = 4;
            this.darkButton3.Text = "Browse...";
            this.darkButton3.Click += new System.EventHandler(this.darkButton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::theCatalyst.Properties.Resources.Proshell;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // darkTextBox1
            // 
            this.darkTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox1.Location = new System.Drawing.Point(81, 38);
            this.darkTextBox1.Name = "darkTextBox1";
            this.darkTextBox1.Size = new System.Drawing.Size(276, 20);
            this.darkTextBox1.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Run
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 93);
            this.Controls.Add(this.darkTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.darkButton3);
            this.Controls.Add(this.darkButton2);
            this.Controls.Add(this.darkButton1);
            this.Controls.Add(this.darkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Run";
            this.Text = "Run";
            this.Load += new System.EventHandler(this.Run_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NeoGeniX.Skinning.SkinningManager skinningManager1;
        private NeoGeniX.Controls.DarkLabel darkLabel1;
        private NeoGeniX.Controls.DarkButton darkButton1;
        private NeoGeniX.Controls.DarkButton darkButton2;
        private NeoGeniX.Controls.DarkButton darkButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private NeoGeniX.Controls.DarkTextBox darkTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}