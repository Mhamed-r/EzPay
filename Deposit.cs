using EzPay.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzPay
{
    public partial class Deposit : Form
    {
        EzPaycontext dbcontext;
        int selectedUserId;
        long SelectedCardNumber;
        UserForm userForm;


        public Deposit(int userID, UserForm form)
        {
            InitializeComponent();
            dbcontext = new EzPaycontext();
            selectedUserId = userID;
            userForm = form;

            getCreditCard();
            
        }
        private void getCreditCard()
        {
            int y = 0;
            var Load_Payments=dbcontext.Payments.Where(P=>P.UserId== selectedUserId).ToList();
            foreach (var item in Load_Payments)
            {
                RadioButton radioButton= new RadioButton();
                radioButton.Text = $"Linked Card {userForm.FormatCardNumber(item.CardNumber.ToString())}";
                radioButton.Tag = item.CardNumber;
                radioButton.AutoSize = true;
                radioButton.Location = new Point(10, 10 + y);
                radioButton.BackColor = Color.Transparent;
                radioButton.ForeColor = Color.Black;
                radioButton.Font = new Font("Arial", 12);
                radioButton.CheckedChanged += (s, e) =>
                {
                    if (radioButton.Checked)
                    {
                        MessageBox.Show($"You have selected {radioButton.Text}");
                        SelectedCardNumber = (long)radioButton.Tag;
                    }
                };
                y += 40;
                panel_creditcard.Controls.Add(radioButton);

            }
        }

        private void btn_addcard_Click(object sender, EventArgs e)
        {
            if (nud_amount.Value == 0)
            {
                MessageBox.Show("Please enter an amount to deposit");
            }
            else if (nud_amount.Value > 1000)
            {
                MessageBox.Show("You can only deposit up to $1000 at a time");
            }
            else
            {
                var checkBalance = dbcontext.Payments.Where(p => p.CardNumber == SelectedCardNumber).FirstOrDefault();
                if (checkBalance.Balance < nud_amount.Value)
                {
                    MessageBox.Show($"Your Balance is {checkBalance.Balance}. You can't add this amount.", "⚠️ Deposit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    var SelectedUser = dbcontext.Users.Where(u => u.UserId == selectedUserId).FirstOrDefault();
                    checkBalance.Balance -= nud_amount.Value;
                    SelectedUser.Balance += nud_amount.Value;
                    var transaction = new Transaction
                    {
                        UserId = selectedUserId,
                        Amount = nud_amount.Value,
                        TransactionDate = DateTime.Now,
                        TransactionType = "Deposit",
                        TransactionStatus = "Success"
                    };
                    dbcontext.Transactions.Add(transaction);
                    dbcontext.SaveChanges();
                    MessageBox.Show($"${nud_amount.Value} added to your balance.\nNew Balance: ${SelectedUser.Balance}", "✔️ Deposit Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userForm.CheckBalance();
                    userForm.getTransactions();
                    Close();

                }
               
            }
        }
    }
}
