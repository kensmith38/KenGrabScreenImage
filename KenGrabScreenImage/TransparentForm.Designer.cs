namespace KenSmithConsulting.KenGrabScreenImage
{
    partial class TransparentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransparentForm));
            this.labelInformation2 = new System.Windows.Forms.Label();
            this.ButtonBegin = new System.Windows.Forms.Button();
            this.TitleLine = new System.Windows.Forms.Label();
            this.labelInformation = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.checkBoxShowDlgProcessImage = new System.Windows.Forms.CheckBox();
            this.panelUserSetting = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUserSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInformation2
            // 
            this.labelInformation2.AutoSize = true;
            this.labelInformation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation2.ForeColor = System.Drawing.Color.Blue;
            this.labelInformation2.Location = new System.Drawing.Point(157, 376);
            this.labelInformation2.Name = "labelInformation2";
            this.labelInformation2.Size = new System.Drawing.Size(538, 48);
            this.labelInformation2.TabIndex = 9;
            this.labelInformation2.Text = resources.GetString("labelInformation2.Text");
            // 
            // ButtonBegin
            // 
            this.ButtonBegin.Location = new System.Drawing.Point(76, 389);
            this.ButtonBegin.Name = "ButtonBegin";
            this.ButtonBegin.Size = new System.Drawing.Size(75, 23);
            this.ButtonBegin.TabIndex = 8;
            this.ButtonBegin.Text = "Begin";
            this.ButtonBegin.UseVisualStyleBackColor = true;
            this.ButtonBegin.Click += new System.EventHandler(this.ButtonBegin_Click);
            // 
            // TitleLine
            // 
            this.TitleLine.AutoSize = true;
            this.TitleLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLine.Location = new System.Drawing.Point(26, 26);
            this.TitleLine.Name = "TitleLine";
            this.TitleLine.Size = new System.Drawing.Size(361, 24);
            this.TitleLine.TabIndex = 7;
            this.TitleLine.Text = "Ken Smith Consulting: Grab screen image";
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation.Location = new System.Drawing.Point(27, 69);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(746, 176);
            this.labelInformation.TabIndex = 6;
            this.labelInformation.Text = resources.GetString("labelInformation.Text");
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(27, 50);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(69, 13);
            this.labelVersion.TabIndex = 10;
            this.labelVersion.Text = "Version 1.1.0";
            // 
            // checkBoxShowDlgProcessImage
            // 
            this.checkBoxShowDlgProcessImage.AutoSize = true;
            this.checkBoxShowDlgProcessImage.Location = new System.Drawing.Point(18, 14);
            this.checkBoxShowDlgProcessImage.Name = "checkBoxShowDlgProcessImage";
            this.checkBoxShowDlgProcessImage.Size = new System.Drawing.Size(120, 17);
            this.checkBoxShowDlgProcessImage.TabIndex = 17;
            this.checkBoxShowDlgProcessImage.Text = "Show special dialog";
            this.checkBoxShowDlgProcessImage.UseVisualStyleBackColor = true;
            // 
            // panelUserSetting
            // 
            this.panelUserSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUserSetting.Controls.Add(this.label2);
            this.panelUserSetting.Controls.Add(this.label1);
            this.panelUserSetting.Controls.Add(this.checkBoxShowDlgProcessImage);
            this.panelUserSetting.Location = new System.Drawing.Point(69, 266);
            this.panelUserSetting.Name = "panelUserSetting";
            this.panelUserSetting.Size = new System.Drawing.Size(663, 97);
            this.panelUserSetting.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(154, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "If all images will simply be pasted into another application such as Paint or Wor" +
    "d,\r\nthen you do not need to show the special dialog.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(154, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "If you intend to save any images to a file,\r\nthen you MUST show the special dialo" +
    "g!";
            // 
            // TransparentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.panelUserSetting);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelInformation2);
            this.Controls.Add(this.ButtonBegin);
            this.Controls.Add(this.TitleLine);
            this.Controls.Add(this.labelInformation);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "TransparentForm";
            this.Text = "Ken\'s Grab Screen Image";
            this.Load += new System.EventHandler(this.TransparentForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TransparentForm_Paint);
            this.DoubleClick += new System.EventHandler(this.TransparentForm_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TransparentForm_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TransparentForm_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TransparentForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TransparentForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TransparentForm_MouseUp);
            this.panelUserSetting.ResumeLayout(false);
            this.panelUserSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInformation2;
        private System.Windows.Forms.Button ButtonBegin;
        private System.Windows.Forms.Label TitleLine;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.CheckBox checkBoxShowDlgProcessImage;
        private System.Windows.Forms.Panel panelUserSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

