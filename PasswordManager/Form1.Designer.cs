
namespace PasswordManager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pwManagerDBDataSet = new PasswordManager.pwManagerDBDataSet();
            this.Change = new System.Windows.Forms.Button();
            this.userDetailsTableAdapter = new PasswordManager.pwManagerDBDataSetTableAdapters.userDetailsTableAdapter();
            this.tableAdapterManager = new PasswordManager.pwManagerDBDataSetTableAdapters.TableAdapterManager();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwManagerDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(119, 172);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(97, 34);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(222, 172);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(97, 34);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(119, 44);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(200, 22);
            this.textBoxUser.TabIndex = 3;
            // 
            // textBoxPW
            // 
            this.textBoxPW.Location = new System.Drawing.Point(119, 82);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.Size = new System.Drawing.Size(200, 22);
            this.textBoxPW.TabIndex = 4;
            this.textBoxPW.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // TextBoxLocation
            // 
            this.TextBoxLocation.Location = new System.Drawing.Point(119, 123);
            this.TextBoxLocation.Name = "TextBoxLocation";
            this.TextBoxLocation.Size = new System.Drawing.Size(200, 22);
            this.TextBoxLocation.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Site/App";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.applicationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(368, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 313);
            this.dataGridView1.TabIndex = 9;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "userID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "userName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // applicationDataGridViewTextBoxColumn
            // 
            this.applicationDataGridViewTextBoxColumn.DataPropertyName = "application";
            this.applicationDataGridViewTextBoxColumn.HeaderText = "application";
            this.applicationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.applicationDataGridViewTextBoxColumn.Name = "applicationDataGridViewTextBoxColumn";
            this.applicationDataGridViewTextBoxColumn.Width = 125;
            // 
            // userDetailsBindingSource
            // 
            this.userDetailsBindingSource.DataMember = "userDetails";
            this.userDetailsBindingSource.DataSource = this.pwManagerDBDataSet;
            // 
            // pwManagerDBDataSet
            // 
            this.pwManagerDBDataSet.DataSetName = "pwManagerDBDataSet";
            this.pwManagerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(148, 212);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(141, 34);
            this.Change.TabIndex = 10;
            this.Change.Text = "Change password";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // userDetailsTableAdapter
            // 
            this.userDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = PasswordManager.pwManagerDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userDetailsTableAdapter = this.userDetailsTableAdapter;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 399);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPW);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwManagerDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Change;
        private pwManagerDBDataSet pwManagerDBDataSet;
        private System.Windows.Forms.BindingSource userDetailsBindingSource;
        private pwManagerDBDataSetTableAdapters.userDetailsTableAdapter userDetailsTableAdapter;
        private pwManagerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
    }
}

