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
    partial class SellerInsForm : MaterialForm
    {
        private DaoOracle oracle;
        private DealHandler dHandler;
        private MainForm main;

        public SellerInsForm()
        {
            InitializeComponent();
        }


        public SellerInsForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        public SellerInsForm(DaoOracle oracle, DealHandler dHandler)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
        }

        public SellerInsForm(DaoOracle oracle, DealHandler dHandler, MainForm main)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
            this.main = main;
        }

        private void sellerOk_Click(object sender, EventArgs e)
        {
            if (sellerName.Text == "" || sellerTel.Text == "" ||
                sellerEmail.Text == "" || sellerJikwi.Text == "" ||
                sellerOffice.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n" +
                    "올바르게 입력하세요.");
                return;
            }

            List<Deal> list = dHandler.getDealList();

            try
            {
                Seller seller = new Seller(
                    sellerName.Text, 
                    sellerTel.Text, 
                    sellerEmail.Text, 
                    sellerJikwi.Text, 
                    sellerOffice.Text);
                oracle.insertSeller(seller);

                list[0].Seller = seller;
                Console.WriteLine("Seller 입력완료");

                UISymbolButton[] btn = main.getButton();
                Color c = Color.FromArgb(52, 105, 170);
                btn[2].FillColor = c;
                btn[2].RectColor = c;

                Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("객체정보를 확인하세요");
            }
        }

        private void sellerCancle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
