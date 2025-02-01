using EzPay.Models;
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
    public partial class Admin : Form
    {
        EzPaycontext dbcontext;
        public Admin()
        {
            InitializeComponent();
            dbcontext = new EzPaycontext();
        }

        private void btn_totalusers_Click(object sender, EventArgs e)
        {
            var totalusers = dbcontext.Users.Where(T => T.Role == "User").Select(T => new { T.Email, UserName = T.Name,T.Phone, DateJoined = T.Date }).ToList();
            dgv_showdata.DataSource = totalusers;

        }

        private void btn_totalbalance_Click(object sender, EventArgs e)
        {
            var totalbalance = dbcontext.Users.Where(T => T.Role == "User" && T.Balance != 0).Select(T => new { T.Email, UserName = T.Name, T.Balance }).ToList();
            dgv_showdata.DataSource = totalbalance;

        }

        private void btn_zerocards_Click(object sender, EventArgs e)
        {
            var zerocards = dbcontext.Users.Where(T => T.Role == "User" && T.Balance == 0).Select(T => new { T.Email, UserName = T.Name, T.Balance }).ToList();
            dgv_showdata.DataSource = zerocards;
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            var deposit = dbcontext.Transactions.Where(T => T.TransactionType == "Deposit").Select(T => new { T.User.Email, UserName = T.User.Name, T.Amount, T.TransactionDate }).ToList();
            dgv_showdata.DataSource = deposit;
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            var transfer = dbcontext.Transactions
                .Where(T => T.TransactionType == "Transfer")
                .Select(T => new
                {
                    Sender = T.User.Name,
                    Receiver = dbcontext.Users.Where(U => U.UserId == T.ReceiverId).Select(U => U.Name).FirstOrDefault(),
                    T.Amount,
                    T.TransactionDate
                })
                .ToList();
            dgv_showdata.DataSource = transfer;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            
        }
    }
}
