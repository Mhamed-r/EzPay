using EzPay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzPay
{
    public partial class AddCreditCard : Form
    {
        EzPaycontext dbcontext;
        UserForm userForm;
        int SelectedUserId;
        public AddCreditCard(int userId, UserForm form)
        {
            InitializeComponent();
            SelectedUserId = userId;
            dbcontext = new EzPaycontext();
            userForm = form;

        }
        public AddCreditCard(int userId) 
        {
            InitializeComponent();
            SelectedUserId = userId;
            dbcontext = new EzPaycontext();
            userForm =new UserForm(userId);
        }

        private void btn_addcard_Click(object sender, EventArgs e)
        {
            if (txt_cardholdername.Text == "" || txt_cardnumber.Text == "" || txt_expdate.Text == "")
            {
                MessageBox.Show("Please fill in all fields.", "⚠️ Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_cardholdername.BorderColor = Color.Red;
                txt_cardnumber.BorderColor = Color.Red;
                txt_expdate.BorderColor = Color.Red;
                txt_cvv.BorderColor = Color.Red;
            }
            else if (txt_cardnumber.Text.Length != 16)
            {
                MessageBox.Show("Card number must be 16 digits.", "⚠️ Invalid Card Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_expdate.Text.Length !=5)
            {
                MessageBox.Show("Expiry date must be in MM/YY format.", "⚠️ Invalid Expiry Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (Regex.IsMatch(txt_cardholdername.Text, @"(?<! )[-a-zA-Z' ]{2,26}") == false)
            {
                MessageBox.Show("Card holder name must be letters only.", "⚠️ Invalid Card Holder Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!txt_cardnumber.Text.All(char.IsDigit))
            {
                MessageBox.Show("Card number must be numbers only.", "⚠️ Invalid Card Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (Regex.IsMatch(txt_expdate.Text, @"^(0[1-9]|1[0-2])\/([0-9]{2})$")==false)
            {
                MessageBox.Show("Expiry date must be in MM/YY format.", "⚠️ Invalid Expiry Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (DateTime.Parse($"01/{txt_expdate.Text}") < DateTime.Now)
            {
                MessageBox.Show("Expiry date must be in the future.", "⚠️ Invalid Expiry Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (dbcontext.Payments.Any(p => p.CardNumber == long.Parse(txt_cardnumber.Text)))
            {
                MessageBox.Show("Card number already exists.", "⚠️ Duplicate Card Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    Payment payment = new Payment
                    {
                        CardHolderName = txt_cardholdername.Text,
                        Cvv = int.Parse(txt_cvv.Text),
                        CardNumber = long.Parse(txt_cardnumber.Text),
                        ExpiryDate = DateTime.Parse($"01/{txt_expdate.Text}"),
                        UserId = SelectedUserId
                    };
                    dbcontext.Payments.Add(payment);
                    dbcontext.SaveChanges();
                    MessageBox.Show("Card added successfully.", "✔️ Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                    userForm.Checkcard();
      
                    this.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "⚠️ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }        


        }
    }
}
