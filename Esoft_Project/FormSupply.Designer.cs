namespace Esoft_Project
{
    partial class FormSupply
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
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelAgent = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelRealEstate = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.listViewSupplySet = new System.Windows.Forms.ListView();
            this.Agent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RealEstate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxAgents = new System.Windows.Forms.ComboBox();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.comboBoxRealEstate = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(17, 348);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(306, 22);
            this.textBoxPrice.TabIndex = 0;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // labelAgent
            // 
            this.labelAgent.AutoSize = true;
            this.labelAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAgent.Location = new System.Drawing.Point(17, 80);
            this.labelAgent.Name = "labelAgent";
            this.labelAgent.Size = new System.Drawing.Size(64, 16);
            this.labelAgent.TabIndex = 1;
            this.labelAgent.Text = "Риелтор";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClient.Location = new System.Drawing.Point(17, 153);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(55, 16);
            this.labelClient.TabIndex = 2;
            this.labelClient.Text = "Клиент";
            // 
            // labelRealEstate
            // 
            this.labelRealEstate.AutoSize = true;
            this.labelRealEstate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRealEstate.Location = new System.Drawing.Point(14, 246);
            this.labelRealEstate.Name = "labelRealEstate";
            this.labelRealEstate.Size = new System.Drawing.Size(156, 16);
            this.labelRealEstate.TabIndex = 3;
            this.labelRealEstate.Text = "Объект недвижимости";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(14, 328);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(41, 16);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Цена";
            // 
            // listViewSupplySet
            // 
            this.listViewSupplySet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Agent,
            this.Client,
            this.Type,
            this.RealEstate,
            this.Price});
            this.listViewSupplySet.GridLines = true;
            this.listViewSupplySet.HideSelection = false;
            this.listViewSupplySet.Location = new System.Drawing.Point(394, 80);
            this.listViewSupplySet.MultiSelect = false;
            this.listViewSupplySet.Name = "listViewSupplySet";
            this.listViewSupplySet.Size = new System.Drawing.Size(447, 295);
            this.listViewSupplySet.TabIndex = 5;
            this.listViewSupplySet.UseCompatibleStateImageBehavior = false;
            this.listViewSupplySet.View = System.Windows.Forms.View.Details;
            this.listViewSupplySet.SelectedIndexChanged += new System.EventHandler(this.listViewSupplySet_SelectedIndexChanged);
            // 
            // Agent
            // 
            this.Agent.Text = "Риелтор";
            // 
            // Client
            // 
            this.Client.Text = "Клиент";
            // 
            // Type
            // 
            this.Type.Text = "Тип";
            // 
            // RealEstate
            // 
            this.RealEstate.Text = "Объект недвижимости";
            this.RealEstate.Width = 134;
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.White;
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(689, 396);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(17);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Padding = new System.Windows.Forms.Padding(12);
            this.buttonDel.Size = new System.Drawing.Size(164, 61);
            this.buttonDel.TabIndex = 16;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(290, 396);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(17);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Padding = new System.Windows.Forms.Padding(12);
            this.buttonAdd.Size = new System.Drawing.Size(164, 61);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxAgents
            // 
            this.comboBoxAgents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAgents.FormattingEnabled = true;
            this.comboBoxAgents.Location = new System.Drawing.Point(17, 100);
            this.comboBoxAgents.Name = "comboBoxAgents";
            this.comboBoxAgents.Size = new System.Drawing.Size(306, 24);
            this.comboBoxAgents.TabIndex = 17;
            this.comboBoxAgents.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKeyPressFalse);
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(17, 181);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(306, 24);
            this.comboBoxClients.TabIndex = 18;
            this.comboBoxClients.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKeyPressFalse);
            // 
            // comboBoxRealEstate
            // 
            this.comboBoxRealEstate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxRealEstate.FormattingEnabled = true;
            this.comboBoxRealEstate.Location = new System.Drawing.Point(21, 279);
            this.comboBoxRealEstate.Name = "comboBoxRealEstate";
            this.comboBoxRealEstate.Size = new System.Drawing.Size(303, 24);
            this.comboBoxRealEstate.TabIndex = 19;
            this.comboBoxRealEstate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKeyPressFalse);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.White;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(490, 396);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(17);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Padding = new System.Windows.Forms.Padding(12);
            this.buttonEdit.Size = new System.Drawing.Size(164, 61);
            this.buttonEdit.TabIndex = 21;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // FormSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 471);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.comboBoxRealEstate);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.comboBoxAgents);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewSupplySet);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelRealEstate);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelAgent);
            this.Controls.Add(this.textBoxPrice);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormSupply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Предложения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelRealEstate;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ListView listViewSupplySet;
        private System.Windows.Forms.ColumnHeader Agent;
        private System.Windows.Forms.ColumnHeader Client;
        private System.Windows.Forms.ColumnHeader RealEstate;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxAgents;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.ComboBox comboBoxRealEstate;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.Button buttonEdit;
    }
}