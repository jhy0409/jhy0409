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
    partial class CustInsForm : MaterialForm
    {
        private DaoOracle oracle;
        public CustInsForm()
        {
            InitializeComponent();
        }

        public CustInsForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        private void custOk_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(custName.Text,
                custTel.Text,custAddr.Text,custEmail.Text);
            oracle.insertCustomer(customer);
            Console.WriteLine("Customer 입력완료");
            Close();
        }

        private void custCancle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
