
namespace BD.Forms
{
    partial class FormPersons
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
            this.dataGridViewPersons = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPersons = new System.Windows.Forms.Button();
            this.panelPersons = new System.Windows.Forms.Panel();
            this.buttonPersonDone = new System.Windows.Forms.Button();
            this.buttonPersonClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPersonAge = new System.Windows.Forms.TextBox();
            this.textBoxPersonPosition = new System.Windows.Forms.TextBox();
            this.textBoxPersonMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxPersonLastName = new System.Windows.Forms.TextBox();
            this.textBoxPersonName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersons)).BeginInit();
            this.panelPersons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPersons
            // 
            this.dataGridViewPersons.AllowUserToAddRows = false;
            this.dataGridViewPersons.AllowUserToDeleteRows = false;
            this.dataGridViewPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column1,
            this.Column2});
            this.dataGridViewPersons.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewPersons.Name = "dataGridViewPersons";
            this.dataGridViewPersons.RowHeadersVisible = false;
            this.dataGridViewPersons.Size = new System.Drawing.Size(804, 310);
            this.dataGridViewPersons.TabIndex = 0;
            this.dataGridViewPersons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersons_CellClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Id";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Имя";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Фамилия";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Отчество";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Должность";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Возраст";
            this.Column8.Name = "Column8";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Update";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "delete";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPersons
            // 
            this.buttonPersons.Location = new System.Drawing.Point(678, 329);
            this.buttonPersons.Name = "buttonPersons";
            this.buttonPersons.Size = new System.Drawing.Size(139, 23);
            this.buttonPersons.TabIndex = 3;
            this.buttonPersons.Text = "Добавить сотрудника";
            this.buttonPersons.UseVisualStyleBackColor = true;
            this.buttonPersons.Click += new System.EventHandler(this.buttonPersons_Click);
            // 
            // panelPersons
            // 
            this.panelPersons.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelPersons.Controls.Add(this.buttonPersonDone);
            this.panelPersons.Controls.Add(this.buttonPersonClose);
            this.panelPersons.Controls.Add(this.label5);
            this.panelPersons.Controls.Add(this.label4);
            this.panelPersons.Controls.Add(this.label3);
            this.panelPersons.Controls.Add(this.label2);
            this.panelPersons.Controls.Add(this.label1);
            this.panelPersons.Controls.Add(this.textBoxPersonAge);
            this.panelPersons.Controls.Add(this.textBoxPersonPosition);
            this.panelPersons.Controls.Add(this.textBoxPersonMiddleName);
            this.panelPersons.Controls.Add(this.textBoxPersonLastName);
            this.panelPersons.Controls.Add(this.textBoxPersonName);
            this.panelPersons.Location = new System.Drawing.Point(386, 330);
            this.panelPersons.Name = "panelPersons";
            this.panelPersons.Size = new System.Drawing.Size(286, 155);
            this.panelPersons.TabIndex = 4;
            this.panelPersons.Visible = false;
            // 
            // buttonPersonDone
            // 
            this.buttonPersonDone.Location = new System.Drawing.Point(202, 122);
            this.buttonPersonDone.Name = "buttonPersonDone";
            this.buttonPersonDone.Size = new System.Drawing.Size(75, 23);
            this.buttonPersonDone.TabIndex = 11;
            this.buttonPersonDone.Text = "Добавить";
            this.buttonPersonDone.UseVisualStyleBackColor = true;
            this.buttonPersonDone.Click += new System.EventHandler(this.buttonPersonDone_Click);
            // 
            // buttonPersonClose
            // 
            this.buttonPersonClose.Location = new System.Drawing.Point(252, 0);
            this.buttonPersonClose.Name = "buttonPersonClose";
            this.buttonPersonClose.Size = new System.Drawing.Size(25, 25);
            this.buttonPersonClose.TabIndex = 10;
            this.buttonPersonClose.Text = "X";
            this.buttonPersonClose.UseVisualStyleBackColor = true;
            this.buttonPersonClose.Click += new System.EventHandler(this.buttonPersonClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Возраст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя";
            // 
            // textBoxPersonAge
            // 
            this.textBoxPersonAge.Location = new System.Drawing.Point(74, 125);
            this.textBoxPersonAge.Name = "textBoxPersonAge";
            this.textBoxPersonAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxPersonAge.TabIndex = 4;
            // 
            // textBoxPersonPosition
            // 
            this.textBoxPersonPosition.Location = new System.Drawing.Point(74, 99);
            this.textBoxPersonPosition.Name = "textBoxPersonPosition";
            this.textBoxPersonPosition.Size = new System.Drawing.Size(100, 20);
            this.textBoxPersonPosition.TabIndex = 3;
            // 
            // textBoxPersonMiddleName
            // 
            this.textBoxPersonMiddleName.Location = new System.Drawing.Point(74, 69);
            this.textBoxPersonMiddleName.Name = "textBoxPersonMiddleName";
            this.textBoxPersonMiddleName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPersonMiddleName.TabIndex = 2;
            // 
            // textBoxPersonLastName
            // 
            this.textBoxPersonLastName.Location = new System.Drawing.Point(74, 42);
            this.textBoxPersonLastName.Name = "textBoxPersonLastName";
            this.textBoxPersonLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPersonLastName.TabIndex = 1;
            // 
            // textBoxPersonName
            // 
            this.textBoxPersonName.Location = new System.Drawing.Point(74, 12);
            this.textBoxPersonName.Name = "textBoxPersonName";
            this.textBoxPersonName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPersonName.TabIndex = 0;
            // 
            // FormPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 493);
            this.Controls.Add(this.panelPersons);
            this.Controls.Add(this.buttonPersons);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewPersons);
            this.Name = "FormPersons";
            this.Text = "FormPersons";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersons)).EndInit();
            this.panelPersons.ResumeLayout(false);
            this.panelPersons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersons;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonPersons;
        private System.Windows.Forms.Panel panelPersons;
        private System.Windows.Forms.Button buttonPersonDone;
        private System.Windows.Forms.Button buttonPersonClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPersonAge;
        private System.Windows.Forms.TextBox textBoxPersonPosition;
        private System.Windows.Forms.TextBox textBoxPersonMiddleName;
        private System.Windows.Forms.TextBox textBoxPersonLastName;
        private System.Windows.Forms.TextBox textBoxPersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}