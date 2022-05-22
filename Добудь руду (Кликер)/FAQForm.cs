using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Развиваемся
{
    public partial class FAQForm : Form
    {
        public FAQForm()
        {
            InitializeComponent();
        }

        private void CloseButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
