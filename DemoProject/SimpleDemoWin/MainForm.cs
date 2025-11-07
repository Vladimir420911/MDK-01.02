using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DemoLib;
using DemoLib.Models.Clients;

namespace SimpleDemoWin
{
    public partial class MainForm : Form
    {
        MySQLClientsModel model;
        private List<Client> allClients_ = new List<Client>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            model = new MySQLClientsModel();
            RefreshClientListBox();
        }

        private void ClientsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ClientsListBox.SelectedItem;
            if (item == null)
            {
                return;
            }

            Client client = item as Client;
            if (client == null)
            {

                return;
            }

            Card.ShowClientInfo(client);
        }

        private void ShowClients(List<Client> clients)
        {
            ClientsListBox.DataSource = null;
            ClientsListBox.DataSource = clients;
            ClientsListBox.DisplayMember = "Name";
        }

        private void FilterAndSearch()
        {
            if (IsNotSettedFilterAndSearch())
            {
                ShowClients(allClients_);
                return;
            }

            string searchingText = SearchByNameTextBox.Text; // это условие поиска
            string alphabetText = AlphabetComboBox.Text; // это условие фильтра


            List<Client> resultClients = new List<Client>();
            foreach (Client client in allClients_)
            {
                if ((String.IsNullOrEmpty(searchingText)
                     || client.Name.ToLower().Contains(searchingText.ToLower()))
                    && (String.IsNullOrEmpty(alphabetText)
                     || client.Name[0] == alphabetText[0]))
                {
                    resultClients.Add(client);
                }
            }

            ShowClients(resultClients);
        }

        private void SearchByNameTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterAndSearch();
        }

        private bool IsNotSettedFilterAndSearch()
        {
            return string.IsNullOrEmpty(AlphabetComboBox.Text)
                        && string.IsNullOrEmpty(SearchByNameTextBox.Text);
        }

        private void AlphabetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterAndSearch();
        }

        private void AlphabetComboBox_TextChanged(object sender, EventArgs e)
        {
            FilterAndSearch();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addClientForm = new AddClientForm(model);
            if (addClientForm.ShowDialog() == DialogResult.OK)
            {
                RefreshClientListBox();
                MessageBox.Show("Клиент добавлен");
            }

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ClientsListBox.SelectedItems.Count > 0)
            {
                string name = ClientsListBox.Text;

                foreach(var client in allClients_)
                {
                    if(client.Name == name)
                    {
                        try
                        {
                            model.DeleteClientById(client.ID);
                            RefreshClientListBox();
                            MessageBox.Show("Клиент удален");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка: {ex.Message}");
                        }
                    }
                }
            }
        }

        private void RefreshClientListBox()
        {
            try
            {
                allClients_ = model.ReadAllClients();
                ShowClients(allClients_);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ОшибкаЖ {ex.Message}");
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            foreach(var client in allClients_)
            {
                if(client.Name == ClientsListBox.Text)
                {
                    var UpdateForm = new UpdateClientForm(client, model);
                    if(UpdateForm.ShowDialog() == DialogResult.OK)
                    {
                        RefreshClientListBox();
                        MessageBox.Show("Данные клиента обновлены");
                    }
                }
            }
        }
    }
}
