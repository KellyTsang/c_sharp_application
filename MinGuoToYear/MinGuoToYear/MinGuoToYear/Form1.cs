using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinGuoToYear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMinGuo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnYearsOld_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMinGuo.Clear();
            txtYearsOld.Clear();

        }

        private void btnConverToMinGuo_Click(object sender, EventArgs e)
        {
            int answer;
            answer = DateTime.Now.Year - 1912 - Convert.ToInt32(txtYearsOld.Text);
            txtMinGuo.Text = answer.ToString();
            
        }

        private void btnConvertToYear_Click(object sender, EventArgs e)
        {
            int answer;
            int minguo = Convert.ToInt32(txtMinGuo.Text);
            answer = DateTime.Now.Year - (1912 + minguo);
            txtYearsOld.Text = answer.ToString();
        }
    }
}
