namespace SQLDataToObject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_ConnectionStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_TestConnection = new System.Windows.Forms.Button();
            this.tbx_Database = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chb_IntegratedSecurity = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_ServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupbox_sqlTable = new System.Windows.Forms.GroupBox();
            this.btn_MultipleTables = new System.Windows.Forms.Button();
            this.btn_DataTabletoJSON = new System.Windows.Forms.Button();
            this.label_RowsColumnsCount = new System.Windows.Forms.Label();
            this.tbx_DataTableCrated = new System.Windows.Forms.TextBox();
            this.cbmbox_Tables = new System.Windows.Forms.ComboBox();
            this.btn_ViewDataTable = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_JSONtoSQL = new System.Windows.Forms.GroupBox();
            this.btn_InsertIntoSql = new System.Windows.Forms.Button();
            this.label_RowsandColumnsJSON = new System.Windows.Forms.Label();
            this.btn_ViewDTfromJSON = new System.Windows.Forms.Button();
            this.btn_CreateDTfromJSON = new System.Windows.Forms.Button();
            this.comboBox_SQLTablefromJSON = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_JSONFilePath = new System.Windows.Forms.Label();
            this.btn_SelectJSONFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupbox_sqlTable.SuspendLayout();
            this.groupBox_JSONtoSQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_ConnectionStatus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_TestConnection);
            this.groupBox1.Controls.Add(this.tbx_Database);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chb_IntegratedSecurity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbx_Password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbx_UserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbx_ServerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(229, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Connection";
            // 
            // tbx_ConnectionStatus
            // 
            this.tbx_ConnectionStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbx_ConnectionStatus.Location = new System.Drawing.Point(85, 204);
            this.tbx_ConnectionStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_ConnectionStatus.Name = "tbx_ConnectionStatus";
            this.tbx_ConnectionStatus.Size = new System.Drawing.Size(138, 27);
            this.tbx_ConnectionStatus.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Status:";
            // 
            // btn_TestConnection
            // 
            this.btn_TestConnection.Location = new System.Drawing.Point(21, 241);
            this.btn_TestConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TestConnection.Name = "btn_TestConnection";
            this.btn_TestConnection.Size = new System.Drawing.Size(192, 31);
            this.btn_TestConnection.TabIndex = 11;
            this.btn_TestConnection.Text = "Connect";
            this.btn_TestConnection.UseVisualStyleBackColor = true;
            this.btn_TestConnection.Click += new System.EventHandler(this.btn_TestConnection_Click);
            // 
            // tbx_Database
            // 
            this.tbx_Database.Location = new System.Drawing.Point(85, 169);
            this.tbx_Database.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_Database.Name = "tbx_Database";
            this.tbx_Database.Size = new System.Drawing.Size(137, 27);
            this.tbx_Database.TabIndex = 10;
            this.tbx_Database.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbx_Database.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_Database_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Database:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // chb_IntegratedSecurity
            // 
            this.chb_IntegratedSecurity.AutoSize = true;
            this.chb_IntegratedSecurity.Location = new System.Drawing.Point(194, 144);
            this.chb_IntegratedSecurity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chb_IntegratedSecurity.Name = "chb_IntegratedSecurity";
            this.chb_IntegratedSecurity.Size = new System.Drawing.Size(18, 17);
            this.chb_IntegratedSecurity.TabIndex = 8;
            this.chb_IntegratedSecurity.UseVisualStyleBackColor = true;
            this.chb_IntegratedSecurity.CheckedChanged += new System.EventHandler(this.chb_IntegratedSecurity_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Integrated Security:";
            // 
            // tbx_Password
            // 
            this.tbx_Password.Location = new System.Drawing.Point(85, 96);
            this.tbx_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_Password.Name = "tbx_Password";
            this.tbx_Password.Size = new System.Drawing.Size(137, 27);
            this.tbx_Password.TabIndex = 6;
            this.tbx_Password.TextChanged += new System.EventHandler(this.tbx_Password_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pass:";
            // 
            // tbx_UserName
            // 
            this.tbx_UserName.Location = new System.Drawing.Point(85, 57);
            this.tbx_UserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_UserName.Name = "tbx_UserName";
            this.tbx_UserName.Size = new System.Drawing.Size(137, 27);
            this.tbx_UserName.TabIndex = 4;
            this.tbx_UserName.TextChanged += new System.EventHandler(this.tbx_UserName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "User:";
            // 
            // tbx_ServerName
            // 
            this.tbx_ServerName.Location = new System.Drawing.Point(85, 21);
            this.tbx_ServerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_ServerName.Name = "tbx_ServerName";
            this.tbx_ServerName.Size = new System.Drawing.Size(137, 27);
            this.tbx_ServerName.TabIndex = 2;
            this.tbx_ServerName.TextChanged += new System.EventHandler(this.tbx_ServerName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // groupbox_sqlTable
            // 
            this.groupbox_sqlTable.Controls.Add(this.btn_MultipleTables);
            this.groupbox_sqlTable.Controls.Add(this.btn_DataTabletoJSON);
            this.groupbox_sqlTable.Controls.Add(this.label_RowsColumnsCount);
            this.groupbox_sqlTable.Controls.Add(this.tbx_DataTableCrated);
            this.groupbox_sqlTable.Controls.Add(this.cbmbox_Tables);
            this.groupbox_sqlTable.Controls.Add(this.btn_ViewDataTable);
            this.groupbox_sqlTable.Controls.Add(this.btn_Create);
            this.groupbox_sqlTable.Controls.Add(this.label7);
            this.groupbox_sqlTable.Location = new System.Drawing.Point(248, 16);
            this.groupbox_sqlTable.Name = "groupbox_sqlTable";
            this.groupbox_sqlTable.Size = new System.Drawing.Size(291, 280);
            this.groupbox_sqlTable.TabIndex = 1;
            this.groupbox_sqlTable.TabStop = false;
            this.groupbox_sqlTable.Text = "SQL Table to JSON";
            // 
            // btn_MultipleTables
            // 
            this.btn_MultipleTables.Location = new System.Drawing.Point(6, 243);
            this.btn_MultipleTables.Name = "btn_MultipleTables";
            this.btn_MultipleTables.Size = new System.Drawing.Size(277, 29);
            this.btn_MultipleTables.TabIndex = 22;
            this.btn_MultipleTables.Text = "Advanced -> Script Multiple Tables";
            this.btn_MultipleTables.UseVisualStyleBackColor = true;
            this.btn_MultipleTables.Click += new System.EventHandler(this.btn_MultipleTables_Click);
            // 
            // btn_DataTabletoJSON
            // 
            this.btn_DataTabletoJSON.Location = new System.Drawing.Point(6, 157);
            this.btn_DataTabletoJSON.Name = "btn_DataTabletoJSON";
            this.btn_DataTabletoJSON.Size = new System.Drawing.Size(277, 29);
            this.btn_DataTabletoJSON.TabIndex = 21;
            this.btn_DataTabletoJSON.Text = "Script Table to JSON File";
            this.btn_DataTabletoJSON.UseVisualStyleBackColor = true;
            this.btn_DataTabletoJSON.Click += new System.EventHandler(this.btn_DataTabletoJSON_Click);
            // 
            // label_RowsColumnsCount
            // 
            this.label_RowsColumnsCount.AutoSize = true;
            this.label_RowsColumnsCount.Location = new System.Drawing.Point(9, 96);
            this.label_RowsColumnsCount.Name = "label_RowsColumnsCount";
            this.label_RowsColumnsCount.Size = new System.Drawing.Size(114, 20);
            this.label_RowsColumnsCount.TabIndex = 20;
            this.label_RowsColumnsCount.Text = "Columns: ;Rows:";
            // 
            // tbx_DataTableCrated
            // 
            this.tbx_DataTableCrated.Enabled = false;
            this.tbx_DataTableCrated.Location = new System.Drawing.Point(174, 63);
            this.tbx_DataTableCrated.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_DataTableCrated.Name = "tbx_DataTableCrated";
            this.tbx_DataTableCrated.Size = new System.Drawing.Size(111, 27);
            this.tbx_DataTableCrated.TabIndex = 19;
            // 
            // cbmbox_Tables
            // 
            this.cbmbox_Tables.FormattingEnabled = true;
            this.cbmbox_Tables.Location = new System.Drawing.Point(87, 27);
            this.cbmbox_Tables.Name = "cbmbox_Tables";
            this.cbmbox_Tables.Size = new System.Drawing.Size(198, 28);
            this.cbmbox_Tables.TabIndex = 18;
            this.cbmbox_Tables.SelectedIndexChanged += new System.EventHandler(this.cbmbox_Tables_SelectedIndexChanged);
            this.cbmbox_Tables.Click += new System.EventHandler(this.cbmbox_Tables_Click);
            // 
            // btn_ViewDataTable
            // 
            this.btn_ViewDataTable.Location = new System.Drawing.Point(9, 123);
            this.btn_ViewDataTable.Name = "btn_ViewDataTable";
            this.btn_ViewDataTable.Size = new System.Drawing.Size(277, 29);
            this.btn_ViewDataTable.TabIndex = 17;
            this.btn_ViewDataTable.Text = "View Data Table";
            this.btn_ViewDataTable.UseVisualStyleBackColor = true;
            this.btn_ViewDataTable.Click += new System.EventHandler(this.btn_ViewDataTable_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(9, 61);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(159, 29);
            this.btn_Create.TabIndex = 16;
            this.btn_Create.Text = "Create Data Table";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "SQL Table:";
            // 
            // groupBox_JSONtoSQL
            // 
            this.groupBox_JSONtoSQL.Controls.Add(this.btn_InsertIntoSql);
            this.groupBox_JSONtoSQL.Controls.Add(this.label_RowsandColumnsJSON);
            this.groupBox_JSONtoSQL.Controls.Add(this.btn_ViewDTfromJSON);
            this.groupBox_JSONtoSQL.Controls.Add(this.btn_CreateDTfromJSON);
            this.groupBox_JSONtoSQL.Controls.Add(this.comboBox_SQLTablefromJSON);
            this.groupBox_JSONtoSQL.Controls.Add(this.label8);
            this.groupBox_JSONtoSQL.Controls.Add(this.label_JSONFilePath);
            this.groupBox_JSONtoSQL.Controls.Add(this.btn_SelectJSONFile);
            this.groupBox_JSONtoSQL.Location = new System.Drawing.Point(545, 16);
            this.groupBox_JSONtoSQL.Name = "groupBox_JSONtoSQL";
            this.groupBox_JSONtoSQL.Size = new System.Drawing.Size(277, 280);
            this.groupBox_JSONtoSQL.TabIndex = 2;
            this.groupBox_JSONtoSQL.TabStop = false;
            this.groupBox_JSONtoSQL.Text = "JSON to SQL Table";
            this.groupBox_JSONtoSQL.Enter += new System.EventHandler(this.groupBox_JSONtoSQL_Enter);
            // 
            // btn_InsertIntoSql
            // 
            this.btn_InsertIntoSql.Location = new System.Drawing.Point(6, 241);
            this.btn_InsertIntoSql.Name = "btn_InsertIntoSql";
            this.btn_InsertIntoSql.Size = new System.Drawing.Size(264, 29);
            this.btn_InsertIntoSql.TabIndex = 26;
            this.btn_InsertIntoSql.Text = "INSERT DataTable into SQL Table";
            this.btn_InsertIntoSql.UseVisualStyleBackColor = true;
            this.btn_InsertIntoSql.Click += new System.EventHandler(this.btn_InsertIntoSql_Click);
            // 
            // label_RowsandColumnsJSON
            // 
            this.label_RowsandColumnsJSON.AutoSize = true;
            this.label_RowsandColumnsJSON.Location = new System.Drawing.Point(6, 125);
            this.label_RowsandColumnsJSON.Name = "label_RowsandColumnsJSON";
            this.label_RowsandColumnsJSON.Size = new System.Drawing.Size(114, 20);
            this.label_RowsandColumnsJSON.TabIndex = 22;
            this.label_RowsandColumnsJSON.Text = "Columns: ;Rows:";
            // 
            // btn_ViewDTfromJSON
            // 
            this.btn_ViewDTfromJSON.Location = new System.Drawing.Point(6, 157);
            this.btn_ViewDTfromJSON.Name = "btn_ViewDTfromJSON";
            this.btn_ViewDTfromJSON.Size = new System.Drawing.Size(264, 29);
            this.btn_ViewDTfromJSON.TabIndex = 25;
            this.btn_ViewDTfromJSON.Text = "View Data Table from JSON";
            this.btn_ViewDTfromJSON.UseVisualStyleBackColor = true;
            this.btn_ViewDTfromJSON.Click += new System.EventHandler(this.btn_ViewDTfromJSON_Click);
            // 
            // btn_CreateDTfromJSON
            // 
            this.btn_CreateDTfromJSON.Location = new System.Drawing.Point(6, 91);
            this.btn_CreateDTfromJSON.Name = "btn_CreateDTfromJSON";
            this.btn_CreateDTfromJSON.Size = new System.Drawing.Size(264, 29);
            this.btn_CreateDTfromJSON.TabIndex = 24;
            this.btn_CreateDTfromJSON.Text = "Create Data Table from JSON";
            this.btn_CreateDTfromJSON.UseVisualStyleBackColor = true;
            this.btn_CreateDTfromJSON.Click += new System.EventHandler(this.btn_CreateDTfromJSON_Click);
            // 
            // comboBox_SQLTablefromJSON
            // 
            this.comboBox_SQLTablefromJSON.FormattingEnabled = true;
            this.comboBox_SQLTablefromJSON.Location = new System.Drawing.Point(89, 200);
            this.comboBox_SQLTablefromJSON.Name = "comboBox_SQLTablefromJSON";
            this.comboBox_SQLTablefromJSON.Size = new System.Drawing.Size(181, 28);
            this.comboBox_SQLTablefromJSON.TabIndex = 23;
            this.comboBox_SQLTablefromJSON.SelectedIndexChanged += new System.EventHandler(this.comboBox_SQLTablefromJSON_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "SQL Table:";
            // 
            // label_JSONFilePath
            // 
            this.label_JSONFilePath.AutoSize = true;
            this.label_JSONFilePath.Location = new System.Drawing.Point(6, 65);
            this.label_JSONFilePath.Name = "label_JSONFilePath";
            this.label_JSONFilePath.Size = new System.Drawing.Size(64, 20);
            this.label_JSONFilePath.TabIndex = 22;
            this.label_JSONFilePath.Text = "File Path";
            // 
            // btn_SelectJSONFile
            // 
            this.btn_SelectJSONFile.Location = new System.Drawing.Point(6, 27);
            this.btn_SelectJSONFile.Name = "btn_SelectJSONFile";
            this.btn_SelectJSONFile.Size = new System.Drawing.Size(264, 29);
            this.btn_SelectJSONFile.TabIndex = 22;
            this.btn_SelectJSONFile.Text = "Select JSON File";
            this.btn_SelectJSONFile.UseVisualStyleBackColor = true;
            this.btn_SelectJSONFile.Click += new System.EventHandler(this.btn_SelectJSONFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 309);
            this.Controls.Add(this.groupBox_JSONtoSQL);
            this.Controls.Add(this.groupbox_sqlTable);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SQL JSON Scripter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupbox_sqlTable.ResumeLayout(false);
            this.groupbox_sqlTable.PerformLayout();
            this.groupBox_JSONtoSQL.ResumeLayout(false);
            this.groupBox_JSONtoSQL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbx_Database;
        private Label label5;
        private CheckBox chb_IntegratedSecurity;
        private Label label4;
        private TextBox tbx_Password;
        private Label label3;
        private TextBox tbx_UserName;
        private Label label2;
        private TextBox tbx_ServerName;
        private Label label1;
        private Button btn_TestConnection;
        private TextBox tbx_ConnectionStatus;
        private Label label6;
        private GroupBox groupbox_sqlTable;
        private Button btn_Create;
        private Label label7;
        private Button btn_ViewDataTable;
        private ComboBox cbmbox_Tables;
        private TextBox tbx_DataTableCrated;
        private Label label_RowsColumnsCount;
        private Button btn_DataTabletoJSON;
        private GroupBox groupBox_JSONtoSQL;
        private Label label_JSONFilePath;
        private Button btn_SelectJSONFile;
        private ComboBox comboBox_SQLTablefromJSON;
        private Label label8;
        private Button btn_ViewDTfromJSON;
        private Button btn_CreateDTfromJSON;
        private Label label_RowsandColumnsJSON;
        private Button btn_InsertIntoSql;
        private Button btn_MultipleTables;
    }
}