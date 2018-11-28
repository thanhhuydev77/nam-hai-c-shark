using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class welcome_form : Form
    {
        
        public welcome_form()
        {
             InitializeComponent();
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            play_form f1 = new play_form();
            f1.Show();
        }

        private void welcome_form_Load(object sender, EventArgs e)
        {

        }
    }
}
