using ClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extreme2
{
    public partial class Form1 : Form
    {
        CarRepo repo = new CarRepo();
        public Form1()
        {
            repo.AddCar(new Car() { Name = "abc1", Model = "cool", Year = 1965});
            repo.AddCar(new Car() { Name = "abc2", Model = "col", Year = 1967 });
            repo.AddCar(new Car() { Name = "abc3", Model = "cl", Year = 1969 });
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repo.GetAllCars();
        }
    }
}
