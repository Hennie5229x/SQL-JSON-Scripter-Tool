using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SQLDataToObject
{
    public partial class ScriptMultipleTables : Form
    {
        public ScriptMultipleTables()
        {
            InitializeComponent();

            FillCheckBoxList();

            FillComboBox_AllTables();


            btn_ViewDataTable.Enabled = false;

        }

        private DataTable dataTable = new DataTable();

        
        StringBuilder stringBuilder = new StringBuilder("The following files have been created:" +Environment.NewLine + Environment.NewLine);

        void FillCheckBoxList()
        {
            try
            {
                SqlConnection cnn;
                cnn = new SqlConnection(ConnectionString.GetConnectionString());
                cnn.Open();

                DataTable SchemaTables = new DataTable();

                SchemaTables = cnn.GetSchema("Tables");

                checkedListBox_AllTables.Items.Clear();

                for (int i = 0; i <= SchemaTables.Rows.Count - 1; i++)
                {
                    checkedListBox_AllTables.Items.Add(SchemaTables.Rows[i][2].ToString());
                }




            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
        }

        void FillComboBox_AllTables()
        {
            //Fill ComboBox Dropdown:
            comboBox_AllTables.Items.Clear();

            for (int i = 0; i <= checkedListBox_AllTables.Items.Count - 1; i++)
            {
                if (checkedListBox_AllTables.GetItemChecked(i) == false)
                {
                    comboBox_AllTables.Items.Add(checkedListBox_AllTables.Items[i].ToString());
                }

            }
        }

        void FillComboBox_ViewTable()
        {
            //Fill ComboBox Dropdown:
            comboBox_Tables.Items.Clear();

            for (int i = 0; i <= checkedListBox_AllTables.Items.Count - 1; i++)
            {
                if (checkedListBox_AllTables.GetItemChecked(i) == true)
                {
                    comboBox_Tables.Items.Add(checkedListBox_AllTables.Items[i].ToString());
                }

            }
        }

        void CheckedTableCount()
        {

            int count = 0;
            
            for (int i = 0; i <= checkedListBox_AllTables.Items.Count - 1; i++)
            {
                if (checkedListBox_AllTables.GetItemChecked(i) == true)
                {
                    count++;
                }
            }

            label_tableCount.Text = "Table Count: " + count.ToString();

        }



        private void checkedListBox_AllTables_SizeChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox_AllTables_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            FillComboBox_ViewTable();
            FillComboBox_AllTables();
            CheckedTableCount();
        }

        private void checkedListBox_AllTables_Click(object sender, EventArgs e)
        {
            FillComboBox_ViewTable();
            FillComboBox_AllTables();
            CheckedTableCount();
        }

        private void checkedListBox_AllTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillComboBox_ViewTable();
            FillComboBox_AllTables();
            CheckedTableCount();
        }

        private void btn_createDataTable_Click(object sender, EventArgs e)
        {
            //Create DataTable from Selected Value

            if (comboBox_Tables.SelectedItem.ToString() != null || comboBox_Tables.SelectedItem.ToString() != System.String.Empty) //Table Name not Empty
            {
                try
                {
                    string query = "SELECT * FROM " + comboBox_Tables.SelectedItem.ToString();

                    SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString());
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    dataTable.Clear();
                    dataTable.Columns.Clear();


                    da.Fill(dataTable);
                    conn.Close();
                    da.Dispose();

                    MessageBox.Show("DATA TABLE CREATED");

                    btn_ViewDataTable.Enabled = true;

                    label_RowsColumns.Text = "Columns: " + dataTable.Columns.Count.ToString() + " ;Rows: " + dataTable.Rows.Count.ToString();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void btn_ViewDataTable_Click(object sender, EventArgs e)
        {
            //View DataTable

            Form form = new Form();
            form.WindowState = FormWindowState.Maximized;

            DataGridView dataGrid = new DataGridView();


            dataGrid.DataSource = dataTable;
            dataGrid.Height = 900;
            dataGrid.Width = 1800;

            form.Controls.Add(dataGrid);

            form.ShowDialog();

        }

        public static string DataTableNewtonsoftJsonNet(DataTable dataTable)
        {
            if (dataTable == null)
            {
                return string.Empty;
            }
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataTable);
        }

        string FileName = "";
        void CreateJSONFile(int index, string filePath)
        {
            
            ///CREATE JSON FROM DATA TABLE

            try
            {
               
                //-----------------------------///

                string query = "SELECT * FROM [" + checkedListBox_AllTables.Items[index].ToString()+"]";

                SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString());
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                dataTable.Clear();
                dataTable.Columns.Clear();


                da.Fill(dataTable);
                conn.Close();
                da.Dispose();


                //---------------------------///

               FileName = checkedListBox_AllTables.Items[index].ToString() + "_" + DateTime.Now.ToString() + "_JSON.txt";

                FileName = FileName.Replace(@"/", "-");
                FileName = FileName.Replace(@":", "-");
                FileName = FileName.Replace(@" ", "_");
                FileName = FileName.Replace(@"-", "_");


                string path = Path.Combine(filePath,FileName); // path to file

                using (FileStream fs = File.Create(path))
                {
                    // writing data in string
                    string dataasstring = DataTableNewtonsoftJsonNet(dataTable); //your data
                    byte[] info = new UTF8Encoding(true).GetBytes(dataasstring);
                    fs.Write(info, 0, info.Length);

                    // writing data in bytes already
                    byte[] data = new byte[] { 0x0 };
                    fs.Write(data, 0, data.Length);


                    stringBuilder.AppendLine(FileName);
                    
                    //ScriptOutPutMessage += FileName + "\n";                    

                }                    
                
            }
            catch (Exception CreateJSONFileException)
            {
                MessageBox.Show(CreateJSONFileException.Message + FileName);
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {

                //-----------//

                for (int i = 0; i <= checkedListBox_AllTables.Items.Count - 1; i++)
                {
                    if (checkedListBox_AllTables.GetItemChecked(i) == true)
                    {
                        CreateJSONFile(i, folderDlg.SelectedPath);
                    }
                }

                MessageBox.Show(stringBuilder.ToString(), "COMPLETED!");


            }


                


        }

        private void checkBox_SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            //SELECT OR UNSELECT ALL
                        
            for (int i = 0; i <= checkedListBox_AllTables.Items.Count - 1; i++)
            {
               checkedListBox_AllTables.SetItemChecked(i, checkBox_SelectAll.Checked);
            }
        }

        private void btn_CheckTable_Click(object sender, EventArgs e)
        {
            //Mark as Checked

            string TableToCheck = comboBox_AllTables.Text;

            int Table_Index = checkedListBox_AllTables.Items.IndexOf(TableToCheck);
            checkedListBox_AllTables.SetItemChecked(Table_Index, true);


            CheckedTableCount();

        }
    }
}
