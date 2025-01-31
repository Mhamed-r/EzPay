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
        public AddCreditCard(int userId , UserForm form)
        {
            InitializeComponent();
            SelectedUserId = userId;
            dbcontext = new EzPaycontext();
            userForm = form;

        }

        private void btn_addcard_Click(object sender, EventArgs e)
        {
            if (txt_cardholdername.Text == "" || txt_cardnumber.Text == "" || txt_expdate.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
                txt_cardholdername.BackColor = Color.Red;
                txt_cardnumber.BackColor = Color.Red;
                txt_expdate.BackColor = Color.Red;
                txt_cvv.BackColor = Color.Red;
            }
            else if (txt_cardnumber.Text.Length != 16)
            {
                MessageBox.Show("Card number must be 16 digits");
            } else if (txt_expdate.Text.Length !=5)
            {
                MessageBox.Show("Expiry date must be in MM/YY format");
            } else if (!txt_cardholdername.Text.All(char.IsLetter))
            {
                MessageBox.Show("Card holder name must be letters only");
            } else if (!txt_cardnumber.Text.All(char.IsDigit))
            {
                MessageBox.Show("Card number must be numbers only");
            }
            else if (Regex.IsMatch(txt_expdate.Text, @"^(0[1-9]|1[0-2])\/([0-9]{2})$")==false)
            {
                MessageBox.Show("Expiry date must be in MM/YY format");
            }
            else if (DateTime.Parse($"01/{txt_expdate.Text}") < DateTime.Now)
            {
                MessageBox.Show("Expiry date must be in the future");
            } else if (dbcontext.Payments.Any(p => p.CardNumber == long.Parse(txt_cardnumber.Text)))
            {
                MessageBox.Show("Card number already exists");
            }
            else
            {
                //try
                //{
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
                    MessageBox.Show("Card added successfully");
                    userForm.Checkcard(SelectedUserId);
                    this.Close();


                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
                }        


        }
    }
}
