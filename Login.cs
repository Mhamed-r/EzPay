using Dapper;
using EzPay.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EzPay
{
    public partial class Login : Form
    {
        SqlConnection con;
        public Login()
        {
            InitializeComponent();
            con = new SqlConnection("Server=desktop-gtd3iip\\sqlexpress;Database=EzPay;Trusted_Connection=True;TrustServerCertificate=True");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void btn_back_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Please fill all the fields.", "⚠️ Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    var query = $"Select * from Users where Email = @email and Password = @password";
                    User SelectedUser = con.Query<User>(query, new { email=txt_email.Text, password=txt_password.Text }).FirstOrDefault();
                    if (SelectedUser == null)
                    {
                        MessageBox.Show("Invalid Email or Password.", "⚠️ Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (SelectedUser.Role == "User")
                    {
                        MessageBox.Show($"Welcome {SelectedUser.Name}. Logged in as {SelectedUser.Role}.", "✔️ Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        UserForm newUser = new UserForm(SelectedUser.UserId, SelectedUser.Name, SelectedUser.Email, SelectedUser.Phone, SelectedUser.Password);
                        newUser.Show();
                        this.Hide();
                    }
                    else if (SelectedUser.Role == "Admin")
                    {
                        MessageBox.Show($"Welcome {SelectedUser.Name}. Logged in as {SelectedUser.Role}.", "✔️ Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Admin newAdmin = new Admin();
                        newAdmin.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void cb_show_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_show_CheckedChanged != null)
            {
                if (cb_show.Checked)
                {
                    txt_password.PasswordChar = '\0';   
                }
                else
                {
                    txt_password.PasswordChar = '*';
                }
            }
        }
    }
}
