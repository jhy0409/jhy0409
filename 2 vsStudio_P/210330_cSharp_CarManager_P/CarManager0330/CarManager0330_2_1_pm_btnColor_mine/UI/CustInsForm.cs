using CarManager0323.DB;
using CarManager0323.Handler;
using CarManager0323.Model;
using MaterialSkin.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager0323.UI
{
    partial class CustInsForm : MaterialForm
    {
        private DaoOracle oracle;
        private DealHandler dHandler;
        private MainForm main;

        public CustInsForm()
        {
            InitializeComponent();
        }

        public CustInsForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        public CustInsForm(DaoOracle oracle, DealHandler dHandler)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
        }

        public CustInsForm(DaoOracle oracle, DealHandler dHandler, MainForm main)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
            this.main = main;
        }


        private void custOk_Click(object sender, EventArgs e)
        {
            if (custName.Text == "" || custTel.Text == "" ||
                custAddr.Text == "" || custEmail.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n" +
                    "올바르게 입력하세요.");
                return;
            }

            List<Deal> list = dHandler.getDealList();

            try
            {
                Customer cust = new Customer(
                    custName.Text,
                    custTel.Text,
                    custAddr.Text,
                    custEmail.Text);

                list[0].Customer = cust;
                oracle.insertCustomer(cust);
                Console.WriteLine("Customer 입력완료");

                UISymbolButton[] btn = main.getButton();
                Color c = Color.FromArgb(52, 105, 170);
                btn[1].FillColor = c;
                btn[1].RectColor = c;
                Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("객체 정보를 확인");
            }
        }

        private void custCancle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
