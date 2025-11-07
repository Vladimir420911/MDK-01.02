using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoLib;
using DemoLib.Models.Clients;

namespace SimpleDemoWin
{
    public partial class UpdateClientForm : Form
    {
        MySQLClientsModel model_;
        Client client_;
        public UpdateClientForm(Client client, MySQLClientsModel model)
        {
            InitializeComponent();
            model_ = model;
            client_ = client;

            PictureOpenDialog.Filter = "Image Files (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png";

            NameTextBox.Text = client.Name;
            DescriptionRichTextBox.Text = client.Description;
            PhoneTextBox.Text = client.Phone;
            MailTextBox.Text = client.Mail;
            ClientPictureBox.ImageLocation = client.ImagePath;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string newName = NameTextBox.Text;
            string newDecription = DescriptionRichTextBox.Text;
            string newPhone = PhoneTextBox.Text;
            string newMail = MailTextBox.Text;
            string newImagePath = ClientPictureBox.ImageLocation;
            
            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newDecription)
                || string.IsNullOrWhiteSpace(newPhone) || string.IsNullOrWhiteSpace(newMail) || string.IsNullOrWhiteSpace(newImagePath)) 
            {
                MessageBox.Show("Поля не могут быть пустыми");
                return;
            }

            try
            {
                model_.UpdateClientById(client_.ID, newName, newDecription, newPhone, newMail, newImagePath);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void ChoosePictureButton_Click(object sender, EventArgs e)
        {
            if (PictureOpenDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = $"../../../Resources/img/{PictureOpenDialog.SafeFileName}";
                ClientPictureBox.ImageLocation = filepath;
            }
        }
    }
}
