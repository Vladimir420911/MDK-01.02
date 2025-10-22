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
    public partial class ClientOrdersForm: Form
    {
        private User currentUser;
        public ClientOrdersForm(User user)
        {
            currentUser = user;
            InitializeComponent();
        }

        public void SetOrder(Order order)
        {
            /// Д.З. Сделать масштабирование колонок таблицы по размеру окна
            /// Добавить строку Итого
            /// По цене: средняя цена, по стоимости - общая сумма, остальные - прочерки
            OrdersTable.DataSource = null;
            OrdersTable.DataSource = order.GetRecords();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(currentUser.Role == UserRole.Manager)
            {
                MessageBox.Show("У вас нет прав для добавления заказов\n" +
                                "Обратитесь к адинистратору",
                                "Сообщение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (currentUser.Role == UserRole.Manager)
            {
                MessageBox.Show("У вас нет прав для удаления заказов\n" +
                                "Обратитесь к адинистратору",
                                "Сообщение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }
}
