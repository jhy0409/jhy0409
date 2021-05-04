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

            ///* 문자열 길이 확인 */
            //int cmodel = Encoding.Default.GetBytes(carModel.Text).Length;
            //int cColor = Encoding.Default.GetBytes(carColor.Text).Length;
            //int ccompany = Encoding.Default.GetBytes(carCompany.Text).Length;
            //int cYear = Encoding.Default.GetBytes(carYear.Text).Length;

            //if (cmodel > 10 || cColor > 10 || ccompany > 10 || cYear > 20) 
            //{
            //    MessageBox.Show("문자열 길이를 초과합니다.\n" +
            //        "(단위 : bytes)\n" +
            //        "모델: 10\n" +
            //        "색상: 10\n" +
            //        "회사: 10\n" +
            //        "연식: 20");
            //    return;
            //}

            List<Deal> list = dHandler.getDealList();
            try
            {
                Car car = new Car(carModel.Text,
                Int32.Parse(carPrice.Text),
                carColor.Text,
                carCompany.Text,
                carYear.Text);

                if (list[0].Car == null)
                {
                    list[0].Car = car;
                    oracle.insertCar(car);
                    Console.WriteLine("Car 입력완료");
                }
                else
                {
                    MessageBox.Show("차량정보가 이미 저장되었습니다.");
                    Close();
                    return;
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
