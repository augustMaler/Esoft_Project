namespace Esoft_Project
{
    partial class FormDeal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSupply = new System.Windows.Forms.Label();
            this.labelDemand = new System.Windows.Forms.Label();
            this.labelSellerCompanyDeductions = new System.Windows.Forms.Label();
            this.labelAgentSellerDeductions = new System.Windows.Forms.Label();
            this.labelCustomerCompanyDeductions = new System.Windows.Forms.Label();
            this.labelAgentCustomerDeductions = new System.Windows.Forms.Label();
            this.textBoxSellerCompanyDeductions = new System.Windows.Forms.TextBox();
            this.textBoxAgentSellerDeductions = new System.Windows.Forms.TextBox();
            this.textBoxCustomerDeductions = new System.Windows.Forms.TextBox();
            this.textBoxAgentCustomerDeductions = new System.Windows.Forms.TextBox();
            this.comboBoxDemand = new System.Windows.Forms.ComboBox();
            this.listViewDealSet = new System.Windows.Forms.ListView();
            this.ClientSeller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AgentClientSeller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientBuyer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AgentClientBueyer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddresRealEstate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxSupply = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelSupply
            // 
            this.labelSupply.AutoSize = true;
            this.labelSupply.Location = new System.Drawing.Point(-1, 79);
            this.labelSupply.Name = "labelSupply";
            this.labelSupply.Size = new System.Drawing.Size(99, 16);
            this.labelSupply.TabIndex = 0;
            this.labelSupply.Text = "Предложение";
            // 
            // labelDemand
            // 
            this.labelDemand.AutoSize = true;
            this.labelDemand.Location = new System.Drawing.Point(-1, 135);
            this.labelDemand.Name = "labelDemand";
            this.labelDemand.Size = new System.Drawing.Size(94, 16);
            this.labelDemand.TabIndex = 1;
            this.labelDemand.Text = "Потребность";
            // 
            // labelSellerCompanyDeductions
            // 
            this.labelSellerCompanyDeductions.AutoSize = true;
            this.labelSellerCompanyDeductions.Location = new System.Drawing.Point(-1, 213);
            this.labelSellerCompanyDeductions.Name = "labelSellerCompanyDeductions";
            this.labelSellerCompanyDeductions.Size = new System.Drawing.Size(269, 16);
            this.labelSellerCompanyDeductions.TabIndex = 2;
            this.labelSellerCompanyDeductions.Text = "Стоимость услуг для клиента-продавца";
            // 
            // labelAgentSellerDeductions
            // 
            this.labelAgentSellerDeductions.AutoSize = true;
            this.labelAgentSellerDeductions.Location = new System.Drawing.Point(-1, 269);
            this.labelAgentSellerDeductions.Name = "labelAgentSellerDeductions";
            this.labelAgentSellerDeductions.Size = new System.Drawing.Size(278, 16);
            this.labelAgentSellerDeductions.TabIndex = 3;
            this.labelAgentSellerDeductions.Text = "Отчисления риелтору клиента-продавца";
            // 
            // labelCustomerCompanyDeductions
            // 
            this.labelCustomerCompanyDeductions.AutoSize = true;
            this.labelCustomerCompanyDeductions.Location = new System.Drawing.Point(-1, 348);
            this.labelCustomerCompanyDeductions.Name = "labelCustomerCompanyDeductions";
            this.labelCustomerCompanyDeductions.Size = new System.Drawing.Size(282, 16);
            this.labelCustomerCompanyDeductions.TabIndex = 4;
            this.labelCustomerCompanyDeductions.Text = "Стоимость услуг для клиента-покупателя";
            // 
            // labelAgentCustomerDeductions
            // 
            this.labelAgentCustomerDeductions.AutoSize = true;
            this.labelAgentCustomerDeductions.Location = new System.Drawing.Point(-1, 402);
            this.labelAgentCustomerDeductions.Name = "labelAgentCustomerDeductions";
            this.labelAgentCustomerDeductions.Size = new System.Drawing.Size(291, 16);
            this.labelAgentCustomerDeductions.TabIndex = 5;
            this.labelAgentCustomerDeductions.Text = "Отчисления риелтору клиента-покупателя";
            // 
            // textBoxSellerCompanyDeductions
            // 
            this.textBoxSellerCompanyDeductions.Location = new System.Drawing.Point(2, 231);
            this.textBoxSellerCompanyDeductions.Name = "textBoxSellerCompanyDeductions";
            this.textBoxSellerCompanyDeductions.Size = new System.Drawing.Size(221, 22);
            this.textBoxSellerCompanyDeductions.TabIndex = 7;
            this.textBoxSellerCompanyDeductions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumberSellerClient);
            // 
            // textBoxAgentSellerDeductions
            // 
            this.textBoxAgentSellerDeductions.Location = new System.Drawing.Point(2, 287);
            this.textBoxAgentSellerDeductions.Name = "textBoxAgentSellerDeductions";
            this.textBoxAgentSellerDeductions.Size = new System.Drawing.Size(221, 22);
            this.textBoxAgentSellerDeductions.TabIndex = 8;
            this.textBoxAgentSellerDeductions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumberAgentSellerClient);
            // 
            // textBoxCustomerDeductions
            // 
            this.textBoxCustomerDeductions.Location = new System.Drawing.Point(2, 366);
            this.textBoxCustomerDeductions.Name = "textBoxCustomerDeductions";
            this.textBoxCustomerDeductions.Size = new System.Drawing.Size(221, 22);
            this.textBoxCustomerDeductions.TabIndex = 9;
            this.textBoxCustomerDeductions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumberClientBuyer);
            // 
            // textBoxAgentCustomerDeductions
            // 
            this.textBoxAgentCustomerDeductions.Location = new System.Drawing.Point(2, 420);
            this.textBoxAgentCustomerDeductions.Name = "textBoxAgentCustomerDeductions";
            this.textBoxAgentCustomerDeductions.Size = new System.Drawing.Size(221, 22);
            this.textBoxAgentCustomerDeductions.TabIndex = 10;
            this.textBoxAgentCustomerDeductions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyBuyerAgentClientBuyer);
            // 
            // comboBoxDemand
            // 
            this.comboBoxDemand.FormattingEnabled = true;
            this.comboBoxDemand.Location = new System.Drawing.Point(2, 153);
            this.comboBoxDemand.Name = "comboBoxDemand";
            this.comboBoxDemand.Size = new System.Drawing.Size(221, 24);
            this.comboBoxDemand.TabIndex = 12;
            this.comboBoxDemand.SelectedIndexChanged += new System.EventHandler(this.comboBoxDemand_SelectedIndexChanged);
            this.comboBoxDemand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxPressFalse);
            // 
            // listViewDealSet
            // 
            this.listViewDealSet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClientSeller,
            this.AgentClientSeller,
            this.ClientBuyer,
            this.AgentClientBueyer,
            this.AddresRealEstate,
            this.Price});
            this.listViewDealSet.GridLines = true;
            this.listViewDealSet.HideSelection = false;
            this.listViewDealSet.Location = new System.Drawing.Point(261, 90);
            this.listViewDealSet.Name = "listViewDealSet";
            this.listViewDealSet.Size = new System.Drawing.Size(936, 353);
            this.listViewDealSet.TabIndex = 13;
            this.listViewDealSet.UseCompatibleStateImageBehavior = false;
            this.listViewDealSet.View = System.Windows.Forms.View.Details;
            this.listViewDealSet.SelectedIndexChanged += new System.EventHandler(this.listViewDealSet_SelectedIndexChanged);
            // 
            // ClientSeller
            // 
            this.ClientSeller.Text = "Клиент-продавец";
            this.ClientSeller.Width = 132;
            // 
            // AgentClientSeller
            // 
            this.AgentClientSeller.Text = "Риелтор клиента-продавца";
            this.AgentClientSeller.Width = 190;
            // 
            // ClientBuyer
            // 
            this.ClientBuyer.Text = "Клиент-покупатель";
            this.ClientBuyer.Width = 135;
            // 
            // AgentClientBueyer
            // 
            this.AgentClientBueyer.Text = "Риелтор клиента-покупателя";
            this.AgentClientBueyer.Width = 188;
            // 
            // AddresRealEstate
            // 
            this.AddresRealEstate.Text = "Адрес объекта недвижимости";
            this.AddresRealEstate.Width = 203;
            // 
            // Price
            // 
            this.Price.Text = "Стоимость";
            this.Price.Width = 93;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.White;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(725, 453);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(17);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Padding = new System.Windows.Forms.Padding(12);
            this.buttonEdit.Size = new System.Drawing.Size(164, 61);
            this.buttonEdit.TabIndex = 24;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.White;
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(924, 453);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(17);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Padding = new System.Windows.Forms.Padding(12);
            this.buttonDel.Size = new System.Drawing.Size(164, 61);
            this.buttonDel.TabIndex = 23;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(525, 453);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(17);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Padding = new System.Windows.Forms.Padding(12);
            this.buttonAdd.Size = new System.Drawing.Size(164, 61);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxSupply
            // 
            this.comboBoxSupply.FormattingEnabled = true;
            this.comboBoxSupply.Location = new System.Drawing.Point(2, 97);
            this.comboBoxSupply.Name = "comboBoxSupply";
            this.comboBoxSupply.Size = new System.Drawing.Size(221, 24);
            this.comboBoxSupply.TabIndex = 25;
            this.comboBoxSupply.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupply_SelectedIndexChanged);
            this.comboBoxSupply.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxPressFalse);
            // 
            // FormDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 528);
            this.Controls.Add(this.comboBoxSupply);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewDealSet);
            this.Controls.Add(this.comboBoxDemand);
            this.Controls.Add(this.textBoxAgentCustomerDeductions);
            this.Controls.Add(this.textBoxCustomerDeductions);
            this.Controls.Add(this.textBoxAgentSellerDeductions);
            this.Controls.Add(this.textBoxSellerCompanyDeductions);
            this.Controls.Add(this.labelAgentCustomerDeductions);
            this.Controls.Add(this.labelCustomerCompanyDeductions);
            this.Controls.Add(this.labelAgentSellerDeductions);
            this.Controls.Add(this.labelSellerCompanyDeductions);
            this.Controls.Add(this.labelDemand);
            this.Controls.Add(this.labelSupply);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormDeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сделки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSupply;
        private System.Windows.Forms.Label labelDemand;
        private System.Windows.Forms.Label labelSellerCompanyDeductions;
        private System.Windows.Forms.Label labelAgentSellerDeductions;
        private System.Windows.Forms.Label labelCustomerCompanyDeductions;
        private System.Windows.Forms.Label labelAgentCustomerDeductions;
        private System.Windows.Forms.TextBox textBoxSellerCompanyDeductions;
        private System.Windows.Forms.TextBox textBoxAgentSellerDeductions;
        private System.Windows.Forms.TextBox textBoxCustomerDeductions;
        private System.Windows.Forms.TextBox textBoxAgentCustomerDeductions;
        private System.Windows.Forms.ComboBox comboBoxDemand;
        private System.Windows.Forms.ListView listViewDealSet;
        private System.Windows.Forms.ColumnHeader ClientSeller;
        private System.Windows.Forms.ColumnHeader AgentClientSeller;
        private System.Windows.Forms.ColumnHeader ClientBuyer;
        private System.Windows.Forms.ColumnHeader AgentClientBueyer;
        private System.Windows.Forms.ColumnHeader AddresRealEstate;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxSupply;
    }
}