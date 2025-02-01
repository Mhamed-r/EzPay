using EzPay.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class Transfer : Form
    {
        EzPaycontext dbcontext;
        UserForm userForm;
        int selectedUserId;

        public Transfer(int id, UserForm form)
        {
            InitializeComponent();
            dbcontext = new EzPaycontext();
            userForm = form;
            selectedUserId = id;
            CheckBalance();
        }
        public void CheckBalance()
        {
            try
            {

                decimal SelectedBalance = dbcontext.Users.Where(U => U.UserId == selectedUserId).Select(U => U.Balance).FirstOrDefault();
                if (SelectedBalance != null)
                {
                    lb_balance.Text = $"${SelectedBalance.ToString()}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "⚠️ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            if (txt_receivername.Text == "" || txt_receiveremail.Text == "")
            {

                MessageBox.Show("Please fill all the fields.", "⚠️ Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_receivername.BorderColor = Color.Red;
                txt_receiveremail.BorderColor = Color.Red;
            }
            else if (nud_amount.Value == 0)
            {
                MessageBox.Show("Please enter an amount to transfer.", "⚠️ Missing Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nud_amount.BorderColor = Color.Red;
            }
            else
            {
                try
                {

                    User SelectedUser = dbcontext.Users.Where(U => U.Email == txt_receiveremail.Text && U.Name == txt_receivername.Text).FirstOrDefault();
                    if (SelectedUser == null)
                    {
                        MessageBox.Show("Invalid Email or Name.", "⚠️ Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {

                        User SenderUser = dbcontext.Users.Where(U => U.UserId == selectedUserId).FirstOrDefault();
                        User SelectedAdmin = dbcontext.Users.Where(u => u.Role == "Admin").FirstOrDefault();
                        if (SenderUser.Balance < nud_amount.Value)
                        {
                            MessageBox.Show("Insufficient balance.", "⚠️ Balance Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else
                        {
                            Transaction newTransaction = new Transaction();
                            newTransaction.UserId = selectedUserId;
                            newTransaction.ReceiverId = SelectedUser.UserId;
                            newTransaction.Amount = nud_amount.Value;
                            newTransaction.TransactionDate = DateTime.Now;
                            newTransaction.TransactionType = "Transfer";
                            newTransaction.TransactionStatus = "Success";
                            newTransaction.UserId = selectedUserId;
                            dbcontext.Transactions.Add(newTransaction);
                            SenderUser.Balance -= nud_amount.Value;
                            decimal adminFee = nud_amount.Value * 0.02m;
                            SelectedAdmin.Balance += adminFee;
                            SelectedUser.Balance += (nud_amount.Value - adminFee);
                            dbcontext.SaveChanges();
                            MessageBox.Show(
                          $"${nud_amount.Value - adminFee} sent to {txt_receivername.Text} ({txt_receiveremail.Text}).\n Fee: ${adminFee}\nNew Balance:${SenderUser.Balance}", "✔️ Transfer Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                            userForm.CheckBalance();
                            userForm.getTransactions();
                        }
                    }




                }
                catch (Exception ex)
                {

                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel the transfer?", "⚠️ Cancel Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
