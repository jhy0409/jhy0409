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
    partial class CarInForm : MaterialForm
    {
        private DaoOracle oracle;
        private DealHandler dHandler;

        public CarInForm()
        {
            InitializeComponent();
        }

        public CarInForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        public CarInForm(DaoOracle oracle, DealHandler dHandler)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
        }


        private void carOK_Click(object sender, EventArgs e)
        {
            if (carModel.Text == "" || carPrice.Text == "" ||
                carColor.Text == "" || carCompany.Text == "" ||
                carYear.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n" +
                    "올바르게 입력하세요.");
                return;
            }

            List<Deal> list = dHandler.getDealList();
            try
            {
                Car car = new Car(carModel.Text,
                Int32.Parse(carPrice.Text),
                carColor.Text,
                carCompany.Text,
                carYear.Text);

                if(list[0].Car == null)
                {
                    list[0].Car = car;
                    oracle.insertCar(car);
                    Console.WriteLine("Car 입력완료");
                }
                else
                {
                    MessageBox.Show("차량정보가 이미 저장되었습니다.");
                }

                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("가격을 올바른 숫자로 입력하세요");
            }
        }

        private void carCancle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
