namespace KenSmithConsulting.KenGrabScreenImage
{
    partial class DlgProcessImageOnClipboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgProcessImageOnClipboard));
            this.TitleLine = new System.Windows.Forms.Label();
            this.labelInformation = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonCloseWindow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonJPG = new System.Windows.Forms.RadioButton();
            this.radioButtonPNG = new System.Windows.Forms.RadioButton();
            this.textBoxFilenamePrefix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLine
            // 
            this.TitleLine.AutoSize = true;
            this.TitleLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLine.Location = new System.Drawing.Point(12, 9);
            this.TitleLine.Name = "TitleLine";
            this.TitleLine.Size = new System.Drawing.Size(245, 24);
            this.TitleLine.TabIndex = 8;
            this.TitleLine.Text = "Process image on clipboard";
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation.Location = new System.Drawing.Point(42, 52);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(478, 80);
            this.labelInformation.TabIndex = 9;
            this.labelInformation.Text = resources.GetString("labelInformation.Text");
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(377, 269);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(130, 23);
            this.ButtonSave.TabIndex = 10;
            this.ButtonSave.Text = "Save as image file";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "2.  You can save it as an image file in a folder you choose. \r\n";
            // 
            // ButtonCloseWindow
            // 
            this.ButtonCloseWindow.Location = new System.Drawing.Point(80, 142);
            this.ButtonCloseWindow.Name = "ButtonCloseWindow";
            this.ButtonCloseWindow.Size = new System.Drawing.Size(130, 23);
            this.ButtonCloseWindow.TabIndex = 12;
            this.ButtonCloseWindow.Text = "Close window";
            this.ButtonCloseWindow.UseVisualStyleBackColor = true;
            this.ButtonCloseWindow.Click += new System.EventHandler(this.ButtonCloseWindow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(514, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "For option 1: simply close this window and use paste command in desired applicati" +
    "on.\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.radioButtonJPG);
            this.groupBox1.Controls.Add(this.radioButtonPNG);
            this.groupBox1.Location = new System.Drawing.Point(80, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 78);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save as image type:";
            // 
            // radioButtonJPG
            // 
            this.radioButtonJPG.AutoSize = true;
            this.radioButtonJPG.Checked = true;
            this.radioButtonJPG.Location = new System.Drawing.Point(17, 19);
            this.radioButtonJPG.Name = "radioButtonJPG";
            this.radioButtonJPG.Size = new System.Drawing.Size(252, 17);
            this.radioButtonJPG.TabIndex = 1;
            this.radioButtonJPG.TabStop = true;
            this.radioButtonJPG.Text = "jpg image (much smaller file size for good quality)";
            this.radioButtonJPG.UseVisualStyleBackColor = true;
            // 
            // radioButtonPNG
            // 
            this.radioButtonPNG.AutoSize = true;
            this.radioButtonPNG.Location = new System.Drawing.Point(17, 42);
            this.radioButtonPNG.Name = "radioButtonPNG";
            this.radioButtonPNG.Size = new System.Drawing.Size(145, 17);
            this.radioButtonPNG.TabIndex = 0;
            this.radioButtonPNG.Text = "png image (higher quality)";
            this.radioButtonPNG.UseVisualStyleBackColor = true;
            // 
            // textBoxFilenamePrefix
            // 
            this.textBoxFilenamePrefix.Location = new System.Drawing.Point(172, 207);
            this.textBoxFilenamePrefix.Name = "textBoxFilenamePrefix";
            this.textBoxFilenamePrefix.Size = new System.Drawing.Size(189, 20);
            this.textBoxFilenamePrefix.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Filename prefix:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(374, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(379, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "Filename will be generated as prefix + date + time.\r\nYou can override that name w" +
    "hen you save the image.";
            // 
            // DlgProcessImageOnClipboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFilenamePrefix);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonCloseWindow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.TitleLine);
            this.Name = "DlgProcessImageOnClipboard";
            this.Text = "Ken\'s Grab Screen Image";
            this.Load += new System.EventHandler(this.DlgProcessImageOnClipboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLine;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonCloseWindow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonJPG;
        private System.Windows.Forms.RadioButton radioButtonPNG;
        private System.Windows.Forms.TextBox textBoxFilenamePrefix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}