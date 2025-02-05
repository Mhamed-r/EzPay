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

namespace EzPay
{
    public partial class UserForm : Form
    {
        SqlConnection con;
        EzPaycontext dbcontext;
        int userId;
        public UserForm(int id)
        {
            InitializeComponent();
            userId = id;
            con = new SqlConnection("Server=desktop-gtd3iip\\sqlexpress;Database=EzPay;Trusted_Connection=True;TrustServerCertificate=True");
            dbcontext = new EzPaycontext();
            string name = dbcontext.Users.Where(U => U.UserId == id).Select(U => U.Name).FirstOrDefault();
            Hello(name);


        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            getTransactions();

        }
        public void getTransactions()
        {
            var Load_Transactions = dbcontext.Transactions.Where(T => T.UserId == userId).Select(T => new { T.TransactionType, T.Amount, T.TransactionDate, T.TransactionStatus }).OrderByDescending(T => T.TransactionDate).ToList();
            dgv_recenttransactions.DataSource = Load_Transactions.ToList();

        }
        public void Hello(string name)
        {
            lb_username.Text = $"Hello, {name}";
            CheckBalance();
            Checkcard();

        }
        public void CheckBalance()
        {
            try
            {
                var query = $"SELECT Balance FROM Users WHERE UserId = @UserId";
                User selectUser = con.Query<User>(query, new { UserId = userId }).FirstOrDefault();
                if (selectUser != null)
                {
                    lb_balance.Text = selectUser.Balance.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "⚠️ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Checkcard()
        {

            try
            {
                var query = $"SELECT CardHolderName, CardNumber, ExpiryDate FROM Payments WHERE UserId = @UserId";
                Payment selectPayment = con.Query<Payment>(query, new { UserId = userId }).FirstOrDefault();
                if (selectPayment != null)
                {
                    btn_addcreditcard.Visible = false;
                    lb_cardholdername.Text = selectPayment.CardHolderName;
                    lb_cardnumber.Text = FormatCardNumber(selectPayment.CardNumber.ToString());
                    lb_expdate.Text = selectPayment.ExpiryDate.ToString("MM/yy");
                }
                else
                {
                    lb_cardholdername.Text =
                    lb_cardnumber.Text =
                    lb_expdate.Text = "";
                    btn_addcreditcard.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "⚠️ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public string FormatCardNumber(string cardNumber)
        {
            StringBuilder formattedNumber = new StringBuilder();
            for (int i = 0; i < cardNumber.Length; i++)
            {
                if (i <= cardNumber.Length - 6)
                {
                    formattedNumber.Append('*');
                    if (i > 0 && i % 4 == 0)
                    {
                        formattedNumber.Append(' ');
                    }
                }
                else
                {
                    formattedNumber.Append(cardNumber[i]);
                }
            }
            return formattedNumber.ToString();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void btn_addcreditcard_Click(object sender, EventArgs e)
        {
            AddCreditCard addCreditCard = new AddCreditCard(userId);
            addCreditCard.Show();


        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit(userId, this);
            deposit.Show();
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer(userId, this);
            transfer.Show();

        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile(userId);
            profile.ShowDialog();

            if (profile.rowAffected > 0)
            {

                this.Close();
                Login login = new Login();
                login.Show();

            }
            else
            {
                this.Show();
            }
            }
    }
}
