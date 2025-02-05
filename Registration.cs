using EzPay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EzPay
{
    public partial class Registration : Form
    {
        EzPaycontext dbcontext;

        public Registration()
        {
            InitializeComponent();
            dbcontext = new EzPaycontext();
         


        }
       
      
        private void cb_show_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_show_CheckedChanged != null)
            {
                if (cb_show.Checked)
                {
                    txt_password.PasswordChar = '\0';
                    txt_confirmpass.PasswordChar = '\0';
                }
                else
                {
                    txt_password.PasswordChar = '*';
                    txt_confirmpass.PasswordChar = '*';

                }
            }
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_email.Text == "" || txt_phone.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Please fill all the fields.", "⚠️ Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else if (txt_password.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters.", "⚠️ Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else if (txt_phone.Text.Length < 11 || !txt_phone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be at least 11 digits.", "⚠️ Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (Regex.IsMatch(txt_email.Text, @"^[\w\.=-]+@[\w\.-]+\.[\w]{2,3}$")==false)
            {
                MessageBox.Show("Invalid Email Address.", "⚠️ Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else if (txt_password.Text != txt_confirmpass.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match.", "⚠️ Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                try
                {

                    User user = new User
                    {
                        Name = txt_username.Text,
                        Email = txt_email.Text,
                        Phone = txt_phone.Text,
                        Password = txt_password.Text,
                        Date = DateTime.Now,
                        Role = "User",
                    };
                    dbcontext.Users.Add(user);
                    dbcontext.SaveChanges();
                    MessageBox.Show($"User {txt_username.Text} registered successfully.", "✔️ Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btn_clear_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

           

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Text
            = txt_email.Text
            = txt_phone.Text
            = txt_password.Text
            = txt_confirmpass.Text = "";

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }
    }
}
