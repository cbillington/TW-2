using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrariesTest
{
    /// <summary>
    /// Static methods for validating TextBoxes in Windows Forms Applications
    /// </summary>
    public static class Validator
    {
        public static bool IsPresent(TextBox textBox)
        {
            var input = textBox.Text;

            return string.IsNullOrEmpty(input);
        }
    }
}
