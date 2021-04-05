using CarManager0323.DB;
using CarManager0323.Model;
using MaterialSkin.Controls;
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
        public SellerInsForm()
        {
            InitializeComponent();
        }

        public SellerInsForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        private void sellerOk_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller(sellerName.Text,sellerTel.Text,
                sellerEmail.Text,sellerJikwi.Text,sellerOffice.Text);

            oracle.insertSeller(seller);
            Console.WriteLine("Seller 입력이 완료되었습니다.");

            Close();
        }

        private void sellerCancle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
