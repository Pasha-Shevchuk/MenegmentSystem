using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenegmentSystem
{
    internal static class FormActions
    {
        public static void ExitForm(Form obj)
        {
            DialogResult res = MessageBox.Show("Are you really sure you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
            else
            {
                obj.Show();
            }
        }

        public static void ClearTxts (params TextBox[] args)
        {
            foreach (var arg in args)
            {
                arg.Clear();
            }
        }

        public static void ShowPas(CheckBox checkShowPas, params TextBox[] args) // textsboxes to show (params)
        {
            char paschar = (checkShowPas.Checked) ? '\0' : '*';
            foreach (var arg in args)
            {
                arg.PasswordChar = paschar;
            }
        }

        public static bool EmailValidator(string emailtext)
        {
            if(emailtext.Contains("@gmail.com") && emailtext.Replace("@","").Replace(".","").All(char.IsLetterOrDigit))
            {
                return true;
            }
            else
            {
               if( emailtext.Length > 0 ) MessageBox.Show("Email isn't valid", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
    }
}
