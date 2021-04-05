using CarManager0323.DB;
using CarManager0323.Handler;
using CarManager0323.Model;
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
        DealHandler dHandler = new DealHandler();

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
            new CarInForm(ora, dHandler).ShowDialog();
        }

        private void insertCustomer_Click(object sender, EventArgs e)
        {
            List<Deal> list = dHandler.getDealList();
            if (list[0].Customer != null)
            {
                MessageBox.Show("고객정보가 이미 저장되어있습니다.");
                return;
            }
            new CustInsForm(ora, dHandler).ShowDialog();
        }

        private void insertSeller_Click(object sender, EventArgs e)
        {
            List<Deal> list = dHandler.getDealList();
            if (list[0].Seller != null)
            {
                MessageBox.Show("판매자 정보가 이미 저장되어있습니다.");
                return;
            }
            new SellerInsForm(ora, dHandler).ShowDialog();
        }

        private void appExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void insertDeal_Click(object sender, EventArgs e)
        {
            List<Deal> list = dHandler.getDealList();
            string nullchk = "";

            if (list[0].Car == null || list[0].Customer == null
                || list[0].Seller == null)
            {
                if (list[0].Car == null) { nullchk += "car"; }
                if (list[0].Customer == null) { nullchk += ", customer"; }
                if (list[0].Seller == null) { nullchk += ", seller"; }
                MessageBox.Show($"{nullchk} 구매내역 정보가 누락되었습니다.");
                return;
            }
            //ora.insertDeal(list[0]);
            ora.insertDeal(list[0].Customer, list[0].Car, list[0].Seller);

            dHandler.dealListClear();
        }

        private void selectDeal_Click(object sender, EventArgs e)
        {
            new DealView(ora, dHandler).ShowDialog();
        }

        private void appHelp_Click(object sender, EventArgs e)
        {

        }
    }
}
