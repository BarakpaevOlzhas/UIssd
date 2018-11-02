using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace Login
{
    public partial class UserControl1 : UserControl
    {
        private int panel1ColorR = 44;
        private int panel1ColorG = 62;
        private int panel1ColorB = 80;
        public UserControl1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(panel1ColorR, panel1ColorG, panel1ColorB);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "User")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.FromArgb(69, 69, 69);
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "User";
                txtuser.ForeColor = Color.FromArgb(69, 69, 69);
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.FromArgb(69, 69, 69);
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Password";
                txtpass.ForeColor = Color.FromArgb(69, 69, 69);
                txtpass.UseSystemPasswordChar = false;
            }
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
