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
        public UserForm(int id, string name, string Email, string Phone, string password, decimal Balance)
        {
            InitializeComponent();
            userId = id;
            con = new SqlConnection("Server=desktop-gtd3iip\\sqlexpress;Database=EzPay;Trusted_Connection=True;TrustServerCertificate=True");
            Hello(id, name, Balance);
            dbcontext = new EzPaycontext();
            dgv_recenttransactions.DataSource = dbcontext.Users.ToList();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
        public void Hello(int id, string name, decimal Balance)
        {
            lb_username.Text = $"Hello, {name}";
            CheckBalance(id);
            Checkcard(id);

        }
        public void CheckBalance(int id)
        {
            try
            {
                var query = $"SELECT Balance FROM Users WHERE UserId = @UserId";
                User selectUser = con.Query<User>(query, new { UserId = id }).FirstOrDefault();
                if (selectUser != null)
                {
                    lb_balance.Text = selectUser.Balance.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        public void Checkcard(int id)
        {

            try
            {
                var query = $"SELECT CardHolderName, CardNumber, ExpiryDate FROM Payments WHERE UserId = @UserId";
                Payment selectPayment = con.Query<Payment>(query, new { UserId = id }).FirstOrDefault();
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
                MessageBox.Show($"An error occurred: {ex.Message}");
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
            //for (int i = 0; i < cardNumber.Length; i++)
            //{
            //    if (i > 0 && i % 4 == 0)
            //    {
            //        formattedNumber.Append(' ');
            //    }
            //    formattedNumber.Append(cardNumber[i]);
            //}



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
            AddCreditCard addCreditCard = new AddCreditCard(userId, this);
            addCreditCard.Show();


        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit(userId, this);
            deposit.Show();
        }
    }
}
