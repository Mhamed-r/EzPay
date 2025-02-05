using Dapper;
using EzPay.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
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
using System.Text.RegularExpressions;

namespace EzPay
{
    public partial class Profile : Form
    {
        int selectedId = 0;
        SqlConnection con;

        public Profile(int id)
        {
            InitializeComponent();
            con = new SqlConnection("Server=desktop-gtd3iip\\sqlexpress;Database=EzPay;Trusted_Connection=True;TrustServerCertificate=True");
            selectedId = id;
            getInfo();

        }

        public void getInfo()
        {
            try
            {
                var query = $"SELECT * FROM Users WHERE UserId = @UserId";
                User SelectedUser = con.Query<User>(query, new { UserId = selectedId }).FirstOrDefault();

                txt_username.Text = SelectedUser.Name;
                txt_email.Text = SelectedUser.Email;
                txt_phone.Text = SelectedUser.Phone.ToString();



            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "⚠️ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        public int rowAffected = 0;
        public bool getEmails(string email)
        {
            List<string> Emails = con.Query<string>("select Email from Users where UserId != @UserId", new { UserId = selectedId }).ToList();
            return Emails.Contains(email) ? true : false;
        }
        private void btn_update_Click(object sender, EventArgs e)
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
            else if (Regex.IsMatch(txt_email.Text, @"^[\w\.=-]+@[\w\.-]+\.[\w]{2,3}$") == false)
            {
                MessageBox.Show("Invalid Email Address.", "⚠️ Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else if (txt_password.Text != txt_confirmpass.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match.", "⚠️ Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else if (getEmails(txt_email.Text) == true)
            {

                MessageBox.Show("Email already exists.", "⚠️ Email Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    var query = $"update Users set Name=@Name,Email=@Email,Phone=@Phone,Password=@Password where UserId = @UserId";

                    rowAffected = con.Execute(query, new { Name = txt_username.Text, Email = txt_email.Text, Phone = txt_phone.Text, Password = txt_password.Text, UserId = selectedId });
                    try
                    {
                        if (rowAffected > 0)
                        {
                            MessageBox.Show($"User {txt_username.Text} Updated successfully.", "✔️ Updated Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"An error occurred: {ex.Message}", "⚠️ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                catch { }
            }
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

        private void btn_addcreditcard_Click(object sender, EventArgs e)
        {
            AddCreditCard addCreditCard = new AddCreditCard(selectedId);
            addCreditCard.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
