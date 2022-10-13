using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class MenuWindow : Form
    {
        private UserRepo userList;
        private CredentialsManager credentials;
        public MenuWindow(UserRepo newUserList, CredentialsManager newCredentials)
        {
            InitializeComponent();
            panel2.Show();
            btnMovies.Show();
            btnGenres.Show();
            userList = newUserList;
            credentials = newCredentials;
            if (credentials.UserLogged.IsAdmin)
            {
                btnMovies.Show();
                btnGenres.Show();
            }
        }
        private void button1_Click_3(object sender, EventArgs e)
        {
            panel2.Show();
            panel3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            credentials.Logout();
            this.Close();
        }
    }
}
