﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace UserInterface
{
    public partial class UsersWindow : Form
    {
        public UsersWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User newUser = new User();

            try
            {
                newUser.Mail = textBoxMail.Text;
                newUser.Username = textBoxUsername.Text;
                newUser.Password = textBoxPassword.Text;
                if (textBoxPassword.Text == textBoxConfirm.Text)
                {
                    MessageBox.Show("User created", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    panelLogin.Show();
                    panelRegister.Hide();
                    ClearTextBoxes();
                    label7.Hide();
                }
                else { label7.Show();
                }
            }
            catch(BusinessLogicException exc1)
            {
                MessageBox.Show(exc1.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(ArgumentNullException exc2)
            {
                MessageBox.Show(exc2.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                MenuWindow newWindow = new MenuWindow();
                newWindow.Show();
            }
            catch(BusinessLogicException exc)
            {
                ClearTextBoxes();
                MessageBox.Show(exc.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            panelLogin.Hide();
            panelRegister.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearTextBoxes();
            panelRegister.Hide();
            panelLogin.Show();
        }
    }
}