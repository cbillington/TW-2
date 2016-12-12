using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrariesTest;

namespace TW_2
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {

            InitializeComponent();
        }

        private void toolStripButton1_Click( object sender, EventArgs e )
        {

        }

        private void toolStripLabel1_Click( object sender, EventArgs e )
        {

        }

        private void radioButton3_CheckedChanged( object sender, EventArgs e )
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
        }

        private void tabPage1_Click( object sender, EventArgs e )
        {
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];
        }

       
    }
}
