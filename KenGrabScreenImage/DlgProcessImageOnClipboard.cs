using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace KenSmithConsulting.KenGrabScreenImage
{
    public partial class DlgProcessImageOnClipboard : Form
    {
        // Save image to recent folder
        public string preferredPath = null;
        public string filenamePrefix = null;

        public DlgProcessImageOnClipboard(string preferredPath, string filenamePrefix)
        {
            InitializeComponent();
            this.preferredPath = preferredPath;
            this.filenamePrefix = filenamePrefix;
            textBoxFilenamePrefix.Text = filenamePrefix;
        }
        private void DlgProcessImageOnClipboard_Load(object sender, EventArgs e)
        {
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Image image = Clipboard.GetImage();
                filenamePrefix = textBoxFilenamePrefix.Text.Trim();
                string targetFilespec = GetTargetFilespec();
                if (targetFilespec != null)
                {
                    if (radioButtonPNG.Checked)
                    {
                        image.Save(targetFilespec, ImageFormat.Png);
                    }
                    if (radioButtonJPG.Checked)
                    {
                        image.Save(targetFilespec, ImageFormat.Jpeg);
                    }
                    KenCommonMethods.DisplayInfoMessage("Image saved:"
                        + "\nFolder: " + Path.GetDirectoryName(targetFilespec)
                        + "\nFile: " + Path.GetFileName(targetFilespec));
                    this.Close();
                }
            }
            catch (Exception exc)
            {
                KenCommonMethods.DisplayExceptionMessage(exc);
            }
        }
        private string GetTargetFilespec()
        {
            string targetFilespec = null;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                // User specifies where to save
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                // Construct reasonable filename 
                string dateStub = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                saveFileDialog.FileName = filenamePrefix + "_" + dateStub + ".jpg";
                if (radioButtonPNG.Checked)
                {
                    saveFileDialog.FileName = filenamePrefix + "_" + dateStub + ".png";
                }
                saveFileDialog.InitialDirectory = preferredPath;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.Filter = "JPG files (*.jpg)|*.jpg";
                if (radioButtonPNG.Checked)
                {
                    saveFileDialog.Filter = "PNG files (*.png)|*.png";
                }

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    targetFilespec = saveFileDialog.FileName;
                    // Save image to recent folder
                    preferredPath = Path.GetDirectoryName(targetFilespec);
                }
            }
            catch (Exception exc)
            {
                KenCommonMethods.DisplayExceptionMessage(exc);
            }
            finally
            {
                Cursor.Current = Cursors.Arrow;
            }
            return targetFilespec;
        }
        // 3/18/2017 Fix bug where button did nothing
        private void ButtonCloseWindow_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
