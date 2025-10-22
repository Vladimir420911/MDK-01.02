using DemoLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class AddOrderRecordForm : Form
    {
        Order currentOrder;
        public AddOrderRecordForm(Order order)
        {
            currentOrder = order;
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(NameTextBox.Text) || PriceNumericUpDown.Value == 0 || CountNumericUpDown.Value == 0)
            {
                MessageBox.Show("Поля не должны быть пустыми", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult = DialogResult.OK;

                OrderRecord orderRecord = new OrderRecord();

                orderRecord.NameProduct = NameTextBox.Text;
                orderRecord.SaleDate = SaleDatePicker.Value;
                orderRecord.Price = (double)PriceNumericUpDown.Value;
                orderRecord.Count = (int)CountNumericUpDown.Value;

                currentOrder.AddRecord(orderRecord);
            }
        }
    }
}
