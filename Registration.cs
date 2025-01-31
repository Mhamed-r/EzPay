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
            GetPhoneCode();


        }
        public void GetPhoneCode()
        {
            List<PhoneCode> codes = new List<PhoneCode>
            {
                new PhoneCode { Code = 93, Country = "Afghanistan +93" },
                new PhoneCode { Code = 355, Country = "Albania +355" },
                new PhoneCode { Code = 213, Country = "Algeria +213" },
                new PhoneCode { Code = 376, Country = "Andorra +376" },
                new PhoneCode { Code = 244, Country = "Angola +244" },
                new PhoneCode { Code = 672, Country = "Antarctica +672" },
                new PhoneCode { Code = 54, Country = "Argentina +54" },
                new PhoneCode { Code = 374, Country = "Armenia +374" },
                new PhoneCode { Code = 297, Country = "Aruba +297" },
                new PhoneCode { Code = 61, Country = "Australia +61" },
                new PhoneCode { Code = 43, Country = "Austria +43" },
                new PhoneCode { Code = 994, Country = "Azerbaijan +994" },
                new PhoneCode { Code = 973, Country = "Bahrain +973" },
                new PhoneCode { Code = 880, Country = "Bangladesh +880" },
                new PhoneCode { Code = 375, Country = "Belarus +375" },
                new PhoneCode { Code = 32, Country = "Belgium +32" },
                new PhoneCode { Code = 501, Country = "Belize +501" },
                new PhoneCode { Code = 229, Country = "Benin +229" },
                new PhoneCode { Code = 975, Country = "Bhutan +975" },
                new PhoneCode { Code = 591, Country = "Bolivia +591" },
                new PhoneCode { Code = 267, Country = "Botswana +267" },
                new PhoneCode { Code = 55, Country = "Brazil +55" },
                new PhoneCode { Code = 673, Country = "Brunei +673" },
                new PhoneCode { Code = 359, Country = "Bulgaria +359" },
                new PhoneCode { Code = 226, Country = "Burkina Faso +226" },
                new PhoneCode { Code = 257, Country = "Burundi +257" },
                new PhoneCode { Code = 855, Country = "Cambodia +855" },
                new PhoneCode { Code = 237, Country = "Cameroon +237" },
                new PhoneCode { Code = 1, Country = "Canada +1" },
                new PhoneCode { Code = 238, Country = "Cape Verde +238" },
                new PhoneCode { Code = 235, Country = "Chad +235" },
                new PhoneCode { Code = 56, Country = "Chile +56" },
                new PhoneCode { Code = 86, Country = "China +86" },
                new PhoneCode { Code = 61, Country = "Christmas Island +61" },
                new PhoneCode { Code = 57, Country = "Colombia +57" },
                new PhoneCode { Code = 269, Country = "Comoros +269" },
                new PhoneCode { Code = 242, Country = "Congo +242" },
                new PhoneCode { Code = 682, Country = "Cook Islands +682" },
                new PhoneCode { Code = 506, Country = "Costa Rica +506" },
                new PhoneCode { Code = 385, Country = "Croatia +385" },
                new PhoneCode { Code = 53, Country = "Cuba +53" },
                new PhoneCode { Code = 537, Country = "Cyprus +537" },
                new PhoneCode { Code = 420, Country = "Czech Republic +420" },
                new PhoneCode { Code = 45, Country = "Denmark +45" },
                new PhoneCode { Code = 253, Country = "Djibouti +253" },
                new PhoneCode { Code = 593, Country = "Ecuador +593" },
                new PhoneCode { Code = 20, Country = "Egypt +20" },
                new PhoneCode { Code = 503, Country = "El Salvador +503" },
                new PhoneCode { Code = 240, Country = "Equatorial Guinea +240" },
                new PhoneCode { Code = 291, Country = "Eritrea +291" },
                new PhoneCode { Code = 372, Country = "Estonia +372" },
                new PhoneCode { Code = 251, Country = "Ethiopia +251" },
                new PhoneCode { Code = 500, Country = "Falkland Islands +500" },
                new PhoneCode { Code = 298, Country = "Faroe Islands +298" },
                new PhoneCode { Code = 679, Country = "Fiji +679" },
                new PhoneCode { Code = 358, Country = "Finland +358" },
                new PhoneCode { Code = 33, Country = "France +33" },
                new PhoneCode { Code = 594, Country = "French Guiana +594" },
                new PhoneCode { Code = 689, Country = "French Polynesia +689" },
                new PhoneCode { Code = 241, Country = "Gabon +241" },
                new PhoneCode { Code = 220, Country = "Gambia +220" },
                new PhoneCode { Code = 995, Country = "Georgia +995" },
                new PhoneCode { Code = 49, Country = "Germany +49" },




            };
            cb_code.DataSource = codes;
            cb_code.DisplayMember = "Country";
            cb_code.ValueMember = "code";
            cb_code.SelectedValue = 20;

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
                MessageBox.Show("Please fill all the fields");

            }
            else if (txt_password.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters");

            }
            else if (txt_phone.Text.Length < 10 || !txt_phone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be at least 10 numbers");
            }
            else if (Regex.IsMatch(txt_email.Text, @"^[\w\.=-]+@[\w\.-]+\.[\w]{2,3}$")==false)
            {
                MessageBox.Show("Invalid Email Address");

            }
            else if (txt_password.Text != txt_confirmpass.Text)
            {
                MessageBox.Show("Password and Confirm Password does not match");

            }
            else
            {
                try
                {

                    User user = new User
                    {
                        Name = txt_username.Text,
                        Email = txt_email.Text,
                        Phone = cb_code.SelectedValue + txt_phone.Text,
                        Password = txt_password.Text,
                        Date = DateTime.Now,
                        Role = "User",
                    };
                    dbcontext.Users.Add(user);
                    dbcontext.SaveChanges();
                    MessageBox.Show($"User {txt_username.Text} Registered Successfully");
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
