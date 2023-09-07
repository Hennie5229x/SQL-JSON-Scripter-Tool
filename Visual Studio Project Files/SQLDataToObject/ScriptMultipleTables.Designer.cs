namespace SQLDataToObject
{
    partial class ScriptMultipleTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptMultipleTables));
            this.checkedListBox_AllTables = new System.Windows.Forms.CheckedListBox();
            this.groupBox_Tables = new System.Windows.Forms.GroupBox();
            this.checkBox_SelectAll = new System.Windows.Forms.CheckBox();
            this.groupBox_ViewTables = new System.Windows.Forms.GroupBox();
            this.label_RowsColumns = new System.Windows.Forms.Label();
            this.btn_ViewDataTable = new System.Windows.Forms.Button();
            this.btn_createDataTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Tables = new System.Windows.Forms.ComboBox();
            this.groupBoxScript = new System.Windows.Forms.GroupBox();
            this.label_tableCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_CheckTable = new System.Windows.Forms.Button();
            this.comboBox_AllTables = new System.Windows.Forms.ComboBox();
            this.groupBox_Tables.SuspendLayout();
            this.groupBox_ViewTables.SuspendLayout();
            this.groupBoxScript.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox_AllTables
            // 
            this.checkedListBox_AllTables.FormattingEnabled = true;
            this.checkedListBox_AllTables.Location = new System.Drawing.Point(6, 27);
            this.checkedListBox_AllTables.Name = "checkedListBox_AllTables";
            this.checkedListBox_AllTables.Size = new System.Drawing.Size(371, 378);
            this.checkedListBox_AllTables.TabIndex = 0;
            this.checkedListBox_AllTables.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_AllTables_ItemCheck);
            this.checkedListBox_AllTables.Click += new System.EventHandler(this.checkedListBox_AllTables_Click);
            this.checkedListBox_AllTables.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_AllTables_SelectedIndexChanged);
            this.checkedListBox_AllTables.SizeChanged += new System.EventHandler(this.checkedListBox_AllTables_SizeChanged);
            // 
            // groupBox_Tables
            // 
            this.groupBox_Tables.Controls.Add(this.checkedListBox_AllTables);
            this.groupBox_Tables.Location = new System.Drawing.Point(11, 12);
            this.groupBox_Tables.Name = "groupBox_Tables";
            this.groupBox_Tables.Size = new System.Drawing.Size(383, 440);
            this.groupBox_Tables.TabIndex = 1;
            this.groupBox_Tables.TabStop = false;
            this.groupBox_Tables.Text = "Tables";
            // 
            // checkBox_SelectAll
            // 
            this.checkBox_SelectAll.AutoSize = true;
            this.checkBox_SelectAll.Location = new System.Drawing.Point(6, 27);
            this.checkBox_SelectAll.Name = "checkBox_SelectAll";
            this.checkBox_SelectAll.Size = new System.Drawing.Size(93, 24);
            this.checkBox_SelectAll.TabIndex = 1;
            this.checkBox_SelectAll.Text = "Select All";
            this.checkBox_SelectAll.UseVisualStyleBackColor = true;
            this.checkBox_SelectAll.CheckedChanged += new System.EventHandler(this.checkBox_SelectAll_CheckedChanged);
            // 
            // groupBox_ViewTables
            // 
            this.groupBox_ViewTables.Controls.Add(this.label_RowsColumns);
            this.groupBox_ViewTables.Controls.Add(this.btn_ViewDataTable);
            this.groupBox_ViewTables.Controls.Add(this.btn_createDataTable);
            this.groupBox_ViewTables.Controls.Add(this.label1);
            this.groupBox_ViewTables.Controls.Add(this.comboBox_Tables);
            this.groupBox_ViewTables.Location = new System.Drawing.Point(401, 141);
            this.groupBox_ViewTables.Name = "groupBox_ViewTables";
            this.groupBox_ViewTables.Size = new System.Drawing.Size(250, 157);
            this.groupBox_ViewTables.TabIndex = 2;
            this.groupBox_ViewTables.TabStop = false;
            this.groupBox_ViewTables.Text = "View a Table (Checked)";
            // 
            // label_RowsColumns
            // 
            this.label_RowsColumns.AutoSize = true;
            this.label_RowsColumns.Location = new System.Drawing.Point(6, 91);
            this.label_RowsColumns.Name = "label_RowsColumns";
            this.label_RowsColumns.Size = new System.Drawing.Size(111, 20);
            this.label_RowsColumns.TabIndex = 4;
            this.label_RowsColumns.Text = "Rows: ;Columns";
            // 
            // btn_ViewDataTable
            // 
            this.btn_ViewDataTable.Location = new System.Drawing.Point(6, 115);
            this.btn_ViewDataTable.Name = "btn_ViewDataTable";
            this.btn_ViewDataTable.Size = new System.Drawing.Size(238, 29);
            this.btn_ViewDataTable.TabIndex = 3;
            this.btn_ViewDataTable.Text = "View Data Table";
            this.btn_ViewDataTable.UseVisualStyleBackColor = true;
            this.btn_ViewDataTable.Click += new System.EventHandler(this.btn_ViewDataTable_Click);
            // 
            // btn_createDataTable
            // 
            this.btn_createDataTable.Location = new System.Drawing.Point(6, 57);
            this.btn_createDataTable.Name = "btn_createDataTable";
            this.btn_createDataTable.Size = new System.Drawing.Size(238, 29);
            this.btn_createDataTable.TabIndex = 2;
            this.btn_createDataTable.Text = "Create Data Table";
            this.btn_createDataTable.UseVisualStyleBackColor = true;
            this.btn_createDataTable.Click += new System.EventHandler(this.btn_createDataTable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table:";
            // 
            // comboBox_Tables
            // 
            this.comboBox_Tables.FormattingEnabled = true;
            this.comboBox_Tables.Location = new System.Drawing.Point(59, 23);
            this.comboBox_Tables.Name = "comboBox_Tables";
            this.comboBox_Tables.Size = new System.Drawing.Size(185, 28);
            this.comboBox_Tables.TabIndex = 0;
            // 
            // groupBoxScript
            // 
            this.groupBoxScript.Controls.Add(this.label_tableCount);
            this.groupBoxScript.Controls.Add(this.button1);
            this.groupBoxScript.Location = new System.Drawing.Point(401, 307);
            this.groupBoxScript.Name = "groupBoxScript";
            this.groupBoxScript.Size = new System.Drawing.Size(250, 145);
            this.groupBoxScript.TabIndex = 3;
            this.groupBoxScript.TabStop = false;
            this.groupBoxScript.Text = "Script Tables to JSON";
            // 
            // label_tableCount
            // 
            this.label_tableCount.AutoSize = true;
            this.label_tableCount.Location = new System.Drawing.Point(7, 81);
            this.label_tableCount.Name = "label_tableCount";
            this.label_tableCount.Size = new System.Drawing.Size(94, 20);
            this.label_tableCount.TabIndex = 1;
            this.label_tableCount.Text = "Table Count: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Script all Selected Tables";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_CheckTable);
            this.groupBox1.Controls.Add(this.comboBox_AllTables);
            this.groupBox1.Controls.Add(this.checkBox_SelectAll);
            this.groupBox1.Location = new System.Drawing.Point(401, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 124);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find a Table (Unchecked)";
            // 
            // btn_CheckTable
            // 
            this.btn_CheckTable.Location = new System.Drawing.Point(6, 89);
            this.btn_CheckTable.Name = "btn_CheckTable";
            this.btn_CheckTable.Size = new System.Drawing.Size(238, 29);
            this.btn_CheckTable.TabIndex = 5;
            this.btn_CheckTable.Text = "Mark Table as Checked";
            this.btn_CheckTable.UseVisualStyleBackColor = true;
            this.btn_CheckTable.Click += new System.EventHandler(this.btn_CheckTable_Click);
            // 
            // comboBox_AllTables
            // 
            this.comboBox_AllTables.FormattingEnabled = true;
            this.comboBox_AllTables.Location = new System.Drawing.Point(6, 56);
            this.comboBox_AllTables.Name = "comboBox_AllTables";
            this.comboBox_AllTables.Size = new System.Drawing.Size(238, 28);
            this.comboBox_AllTables.TabIndex = 5;
            // 
            // ScriptMultipleTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 457);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxScript);
            this.Controls.Add(this.groupBox_ViewTables);
            this.Controls.Add(this.groupBox_Tables);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScriptMultipleTables";
            this.Text = "ScriptMultipleTables";
            this.groupBox_Tables.ResumeLayout(false);
            this.groupBox_ViewTables.ResumeLayout(false);
            this.groupBox_ViewTables.PerformLayout();
            this.groupBoxScript.ResumeLayout(false);
            this.groupBoxScript.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox checkedListBox_AllTables;
        private GroupBox groupBox_Tables;
        private GroupBox groupBox_ViewTables;
        private GroupBox groupBoxScript;
        private Label label1;
        private ComboBox comboBox_Tables;
        private Button btn_createDataTable;
        private Label label_RowsColumns;
        private Button btn_ViewDataTable;
        private Button button1;
        private CheckBox checkBox_SelectAll;
        private GroupBox groupBox1;
        private Button btn_CheckTable;
        private ComboBox comboBox_AllTables;
        private Label label_tableCount;
    }
}