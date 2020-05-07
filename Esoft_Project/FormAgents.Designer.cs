namespace Esoft_Project
{
    partial class FormAgents
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
            this.listViewAgents = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MIddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DealShare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxNameAgent = new System.Windows.Forms.TextBox();
            this.textBoxLastNameAgent = new System.Windows.Forms.TextBox();
            this.textBoxMiddleNameAgent = new System.Windows.Forms.TextBox();
            this.textBoxDealShare = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelDealShare = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewAgents
            // 
            this.listViewAgents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.MIddleName,
            this.DealShare});
            this.listViewAgents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewAgents.GridLines = true;
            this.listViewAgents.HideSelection = false;
            this.listViewAgents.Location = new System.Drawing.Point(179, 67);
            this.listViewAgents.Name = "listViewAgents";
            this.listViewAgents.Size = new System.Drawing.Size(412, 201);
            this.listViewAgents.TabIndex = 0;
            this.listViewAgents.UseCompatibleStateImageBehavior = false;
            this.listViewAgents.View = System.Windows.Forms.View.Details;
            this.listViewAgents.SelectedIndexChanged += new System.EventHandler(this.listViewAgents_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // FirstName
            // 
            this.FirstName.Text = "Имя";
            // 
            // LastName
            // 
            this.LastName.Text = "Фамилия";
            this.LastName.Width = 78;
            // 
            // MIddleName
            // 
            this.MIddleName.Text = "Отчество";
            this.MIddleName.Width = 78;
            // 
            // DealShare
            // 
            this.DealShare.Text = "Доля от комисии";
            this.DealShare.Width = 116;
            // 
            // textBoxNameAgent
            // 
            this.textBoxNameAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameAgent.Location = new System.Drawing.Point(22, 81);
            this.textBoxNameAgent.Name = "textBoxNameAgent";
            this.textBoxNameAgent.Size = new System.Drawing.Size(100, 22);
            this.textBoxNameAgent.TabIndex = 1;
            // 
            // textBoxLastNameAgent
            // 
            this.textBoxLastNameAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastNameAgent.Location = new System.Drawing.Point(22, 135);
            this.textBoxLastNameAgent.Name = "textBoxLastNameAgent";
            this.textBoxLastNameAgent.Size = new System.Drawing.Size(100, 22);
            this.textBoxLastNameAgent.TabIndex = 2;
            // 
            // textBoxMiddleNameAgent
            // 
            this.textBoxMiddleNameAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMiddleNameAgent.Location = new System.Drawing.Point(22, 184);
            this.textBoxMiddleNameAgent.Name = "textBoxMiddleNameAgent";
            this.textBoxMiddleNameAgent.Size = new System.Drawing.Size(100, 22);
            this.textBoxMiddleNameAgent.TabIndex = 3;
            // 
            // textBoxDealShare
            // 
            this.textBoxDealShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDealShare.Location = new System.Drawing.Point(22, 238);
            this.textBoxDealShare.Name = "textBoxDealShare";
            this.textBoxDealShare.Size = new System.Drawing.Size(100, 22);
            this.textBoxDealShare.TabIndex = 4;
            this.textBoxDealShare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDealShare_KeyPress);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(19, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(34, 16);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Имя";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(19, 119);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(67, 16);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "Фамилия";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleName.Location = new System.Drawing.Point(19, 168);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(71, 16);
            this.labelMiddleName.TabIndex = 7;
            this.labelMiddleName.Text = "Отчество";
            // 
            // labelDealShare
            // 
            this.labelDealShare.AutoSize = true;
            this.labelDealShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDealShare.Location = new System.Drawing.Point(19, 222);
            this.labelDealShare.Name = "labelDealShare";
            this.labelDealShare.Size = new System.Drawing.Size(116, 16);
            this.labelDealShare.TabIndex = 8;
            this.labelDealShare.Text = "Доля от комисии";
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.White;
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(450, 286);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(15);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Padding = new System.Windows.Forms.Padding(10);
            this.buttonDel.Size = new System.Drawing.Size(141, 53);
            this.buttonDel.TabIndex = 16;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.White;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(299, 286);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(15);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Padding = new System.Windows.Forms.Padding(10);
            this.buttonEdit.Size = new System.Drawing.Size(141, 53);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(151, 286);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(15);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Padding = new System.Windows.Forms.Padding(10);
            this.buttonAdd.Size = new System.Drawing.Size(141, 53);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 357);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelDealShare);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxDealShare);
            this.Controls.Add(this.textBoxMiddleNameAgent);
            this.Controls.Add(this.textBoxLastNameAgent);
            this.Controls.Add(this.textBoxNameAgent);
            this.Controls.Add(this.listViewAgents);
            this.Name = "FormAgents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Риелторы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAgents;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader MIddleName;
        private System.Windows.Forms.ColumnHeader DealShare;
        private System.Windows.Forms.TextBox textBoxNameAgent;
        private System.Windows.Forms.TextBox textBoxLastNameAgent;
        private System.Windows.Forms.TextBox textBoxMiddleNameAgent;
        private System.Windows.Forms.TextBox textBoxDealShare;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelDealShare;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
    }
}