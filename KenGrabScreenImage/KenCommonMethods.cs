using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KenSmithConsulting.KenGrabScreenImage
{
    public class KenCommonMethods
    {
        public static void DisplayInfoMessage(string message)
        {
            MessageBox.Show(message, Constants.windowShortTitleText, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void DisplayErrorMessage(string message)
        {
            MessageBox.Show(message, Constants.windowShortTitleText, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void DisplayExceptionMessage(Exception exc)
        {
            string primaryMessage = exc.Message;
            string innerMessage = (exc.InnerException == null) ? null : exc.InnerException.Message;
            string message = primaryMessage + ((innerMessage == null) ? "" : "\n" + innerMessage);
            message = message + "\nStack trace:\n" + exc.StackTrace;
            MessageBox.Show(message, Constants.windowShortTitleText, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult AskYesNoQuestion(string question)
        {
            DialogResult result = MessageBox.Show(question, Constants.windowShortTitleText,
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result;
        }
        public static DialogResult AskIfDialogStaysOpenAfterSave(string message)
        {
            if (message == null) { message = String.Empty; }
            string question = message + "\n\nDo you want to keep this window open?";
            DialogResult result = MessageBox.Show(question, Constants.windowShortTitleText,
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result;
        }

    }
}
