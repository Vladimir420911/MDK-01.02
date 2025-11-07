using DemoLib.Models.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDemoWin
{
    public partial class AddClientForm : Form
    {
        MySQLClientsModel model_;
        public AddClientForm(MySQLClientsModel model)
        {
            InitializeComponent();
            PictureOpenDialog.Filter = "Image Files (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png";
            model_ = model;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChoosePictureButton_Click(object sender, EventArgs e)
        {
            if(PictureOpenDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = $"../../../Resources/img/{PictureOpenDialog.SafeFileName}";
                ClientPictureBox.ImageLocation = filepath;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string description = DescriptionRichTextBox.Text;
            string phone = PhoneTextBox.Text;
            string mail = MailTextBox.Text;
            string imagePath = ClientPictureBox.ImageLocation;

            try
            {
                model_.AddClient(name, description, phone, mail, imagePath);
                MessageBox.Show("Клиент добавлен");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}");
            }
        }
    }
}
