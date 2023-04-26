using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankacct
{
    public partial class amountForm : Form
    {
        public string ReturnValue1 { get; set; }

        public amountForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReturnValue1 = txtDeposit.Text;
            this.Close();
        }
    }
}
