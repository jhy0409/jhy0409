using CarManager0323.DB;
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

        MainForm(DaoOracle oracle)
        {
            InitializeComponent();
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

        private void createTB_Click(object sender, EventArgs e)
        {
            ora.createTable();
        }

        private void dropTB_Click(object sender, EventArgs e)
        {
            ora.dropTable();
        }
    }
}
