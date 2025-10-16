namespace DemoProject
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ClientsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SearchByNameLabel = new System.Windows.Forms.ToolStripLabel();
            this.SearchByClientNameTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripAddClientButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDeleteClientButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientsLayout
            // 
            this.ClientsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientsLayout.Location = new System.Drawing.Point(0, 0);
            this.ClientsLayout.Margin = new System.Windows.Forms.Padding(30);
            this.ClientsLayout.Name = "ClientsLayout";
            this.ClientsLayout.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.ClientsLayout.Size = new System.Drawing.Size(800, 450);
            this.ClientsLayout.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddClientButton,
            this.toolStripDeleteClientButton,
            this.SearchByNameLabel,
            this.SearchByClientNameTextBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 35);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SearchByNameLabel
            // 
            this.SearchByNameLabel.Name = "SearchByNameLabel";
            this.SearchByNameLabel.Size = new System.Drawing.Size(148, 32);
            this.SearchByNameLabel.Text = "Поиск по имени клиента:";
            // 
            // SearchByClientNameTextBox
            // 
            this.SearchByClientNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchByClientNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchByClientNameTextBox.Name = "SearchByClientNameTextBox";
            this.SearchByClientNameTextBox.Size = new System.Drawing.Size(100, 35);
            this.SearchByClientNameTextBox.TextChanged += new System.EventHandler(this.SearchByClientNameTextBox_TextChanged);
            // 
            // toolStripAddClientButton
            // 
            this.toolStripAddClientButton.AutoSize = false;
            this.toolStripAddClientButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAddClientButton.Image = global::DemoProject.Properties.Resources.AddIcon;
            this.toolStripAddClientButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAddClientButton.Name = "toolStripAddClientButton";
            this.toolStripAddClientButton.Size = new System.Drawing.Size(32, 32);
            this.toolStripAddClientButton.Text = "toolStripButton1";
            this.toolStripAddClientButton.ToolTipText = "Позволит добавить нового клиента";
            this.toolStripAddClientButton.Click += new System.EventHandler(this.toolStripAddClientButton_Click);
            // 
            // toolStripDeleteClientButton
            // 
            this.toolStripDeleteClientButton.AutoSize = false;
            this.toolStripDeleteClientButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDeleteClientButton.Image = global::DemoProject.Properties.Resources.RemoveIcon;
            this.toolStripDeleteClientButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDeleteClientButton.Name = "toolStripDeleteClientButton";
            this.toolStripDeleteClientButton.Size = new System.Drawing.Size(32, 32);
            this.toolStripDeleteClientButton.Text = "toolStripButton2";
            this.toolStripDeleteClientButton.ToolTipText = "Позволит удалить клиента";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ClientsLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Управление клиентами ОАО \"Цемент-Строй\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel ClientsLayout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel SearchByNameLabel;
        private System.Windows.Forms.ToolStripTextBox SearchByClientNameTextBox;
        private System.Windows.Forms.ToolStripButton toolStripAddClientButton;
        private System.Windows.Forms.ToolStripButton toolStripDeleteClientButton;
    }
}

