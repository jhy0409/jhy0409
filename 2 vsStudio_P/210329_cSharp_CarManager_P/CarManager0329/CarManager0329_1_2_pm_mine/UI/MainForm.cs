using CarManager0323.DB;
using CarManager0323.UI;
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

namespace CarManager0323
{
    public partial class MainForm : MaterialForm
    {
        DaoOracle ora = new DaoOracle();
        public MainForm()
        {
            InitializeComponent();
            // mvp, mvvm
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //ora.dbConnect();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // x버튼 종료시점
            //ora.dbClose();
        }

             
        private void btn_mainTableDel_Click(object sender, EventArgs e)
        {
            //ora.dropTable();
            ora.dropAllTB();
        }

        private void btn_mainTableAdd_Click(object sender, EventArgs e) //createTB_Click
        {
            /*ora.createTable();
            ora.makeTbCustomer();
            ora.makeTbCar();
            ora.makeTbSeller();
            ora.makeTbDeal();
             */
            ora.createAllTB();
        }

        private void insertAll_Click(object sender, EventArgs e)
        {
            ora.insertCar();
            ora.insertCustomer();
            ora.insertSeller();
            ora.insertDeal();
        }

        private void insertCar_Click(object sender, EventArgs e)
        {
            new CarInForm(ora).ShowDialog();
        }

        private void insertCustomer_Click(object sender, EventArgs e)
        {
            new CustInsForm(ora).ShowDialog();
        }

        private void insertSeller_Click(object sender, EventArgs e)
        {
            new SellerInsForm(ora).ShowDialog();
        }

        private void appExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
