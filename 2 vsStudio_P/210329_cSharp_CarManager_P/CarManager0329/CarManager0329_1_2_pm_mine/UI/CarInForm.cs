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
    partial class CarInForm : MaterialForm
    {
        private DaoOracle oracle;
        public CarInForm()
        {
            InitializeComponent();
        }

        public CarInForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        private void carOK_Click(object sender, EventArgs e)
        {
            Car car = new Car(carModel.Text, 
                Int32.Parse(carPrice.Text),
                carColor.Text,
                carCompany.Text,
                carYear.Text);
            oracle.insertCar(car);
            Console.WriteLine("Car 입력완료");
            Close();
        }

        private void carCancle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
