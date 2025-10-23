using ClientCard;
using DemoLib;
using DemoLib.Models;
using DemoLib.Models.Clients;
using DemoLib.Presenters;
using DemoLib.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DemoProject
{
    public partial class MainForm : Form
    {
        private User currentUser_ = null;
        private ClientPresenter presenter_;
        public MainForm(User user)
        {
            currentUser_ = user;
            InitializeComponent();

            MySQLClientsModel model = new MySQLClientsModel();

            int countClients = 0;
            try
            {
                countClients = model.GetClientsCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Ошибка работы с БД",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            List<IClientView> cards = new List<IClientView>();
            /// Д.З Сделать нормальный вид карточек
            for (int i = 0; i < countClients; i++)
            {
                ClientView card = new ClientView(); /// наклепали пустую карточку
                card.SelectedClient += Card_SelectedClient;
                ClientsLayout.Controls.Add(card); /// добавляем карточку на главную форму в layout
                cards.Add(card);
            }

            presenter_ = new ClientPresenter(model, cards);
        }

        private void Card_SelectedClient(Client obj)
        {
            if(obj == null)
            {
                return;
            }

            if (isLowRoleUser())
            {
                MessageBox.Show("У Вас не хватает прав, чтобы посмотреть заказы.\n" +
                                "Обратитесь, пожалуйста, к администратору",
                                "Сообщение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                ClientOrdersForm ordersForm = new ClientOrdersForm(currentUser_, obj);
                ordersForm.Text = "Заказы клиента " + obj.Name;
                ordersForm.SetOrder(obj.order);
                ordersForm.ShowDialog();
            }
        }

        private void SearchByClientNameTextBox_TextChanged(object sender, System.EventArgs e)
        {
            string searchingText = SearchByClientNameTextBox.Text;
            
            presenter_.SearchClientsByPartialName(searchingText);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private bool isLowRoleUser()
        {
            /// currentUser_ == null - это гость
            return currentUser_.Role == UserRole.Client || currentUser_ == null;
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            if(isLowRoleUser())
            {
                this.SearchByClientNameTextBox.Enabled = false;
                this.SearchByNameLabel.Text = "Поиск по клиенту Вам недоступен";
                this.SearchByNameLabel.ForeColor = System.Drawing.Color.Red;
            }

            if (currentUser_ != null)
            {
                Text = this.Text + " - " + currentUser_.Login;
            }
        }

        private void toolStripAddClientButton_Click(object sender, System.EventArgs e)
        {
            if(isLowRoleUser())
            {
                MessageBox.Show("У вас нет прав для добавления клиентов\n" +
                                "Обратитесь к адинистратору",
                                "Сообщение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

            AddClientForm addClientForm = new AddClientForm();
            addClientForm.Show();
        }
    }
}
