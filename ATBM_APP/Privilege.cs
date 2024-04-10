using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATBM_APP
{
    public partial class Privilege : Form
    {
        public Privilege()
        {
            InitializeComponent();
            privCB.DropDownStyle = ComboBoxStyle.DropDownList;
            colCB.Enabled = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(usrTB.Text) && (privCB.SelectedItem.ToString() == "Select" || privCB.SelectedItem.ToString() == "Update"))
            {
                colCB.Enabled = true;
            }
            else
            {
                colCB.Enabled = false;
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {

        }

        private void roleTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void usrTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
