using Newtonsoft.Json;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SQLDataToObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            tbx_ConnectionStatus.Text = ConnectionStatus;
            tbx_ConnectionStatus.ForeColor = Color.Red;

            if (ConnectionStatus != "CONNECTED!")
            {
                groupbox_sqlTable.Enabled = false;
            }
            else
            {
                groupbox_sqlTable.Enabled = true;
            }




            if (cbmbox_Tables.SelectedIndex == -1)
            {
                btn_Create.Enabled = false;
            }
            else
            {
                btn_Create.Enabled = true;
            }

            tbx_DataTableCrated.Text = "NOT CREATED";
            btn_ViewDataTable.Enabled = false;
            btn_DataTabletoJSON.Enabled = false;
            groupBox_JSONtoSQL.Enabled = false;

            btn_CreateDTfromJSON.Enabled = false;   
            btn_ViewDTfromJSON.Enabled = false;
            comboBox_SQLTablefromJSON.Enabled = false;
            btn_InsertIntoSql.Enabled = false;  


        }       
        //-----------------------------------------------//
        public string ConnectionStatus = "NOT CONNECTED!";
        private DataTable dataTable = new DataTable();
        private DataTable JSONdataTable = new DataTable();

        private string JSONString = "";


        //-----------------------------------------------//
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ChangedText

            tbx_ConnectionStatus.ForeColor = Color.Red;
            tbx_ConnectionStatus.Text = "NOT CONNECTED!";

        }

        private void chb_IntegratedSecurity_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbx_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_ServerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_TestConnection_Click(object sender, EventArgs e)
        {
            //Test Connection Button

            tbx_ConnectionStatus.ForeColor = Color.Orange;
            tbx_ConnectionStatus.Text = "CONNECTING...";


            ConnectionString.ServerName = tbx_ServerName.Text;
            ConnectionString.UserName = tbx_Database.Text;
            ConnectionString.Password = tbx_Password.Text;
            ConnectionString.IntegratedSecurity = chb_IntegratedSecurity.Checked;
            ConnectionString.Database = tbx_Database.Text;


            try
            {
                SqlConnection cnn;
                cnn = new SqlConnection(ConnectionString.GetConnectionString());

                if (tbx_Database.Text != null || tbx_Database.Text != System.String.Empty)
                {
                    
                    cnn.Open();
                    
                    ConnectionStatus = "CONNECTED!";
                    tbx_ConnectionStatus.Text = ConnectionStatus;
                    tbx_ConnectionStatus.ForeColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Database name cannot be empty", "FAILED!");
                }
                
               

                if (ConnectionStatus != "CONNECTED!")
                {
                    groupbox_sqlTable.Enabled = false;
                    groupBox_JSONtoSQL.Enabled = false;
                }
                else
                {
                    groupbox_sqlTable.Enabled = true;
                    groupBox_JSONtoSQL.Enabled = true;

                    //Get All Tables
                    DataTable dt_tables = cnn.GetSchema("Tables");

                   
                    cbmbox_Tables.Items.Clear();
                    comboBox_SQLTablefromJSON.Items.Clear();

                    for (int i = 0; i <= dt_tables.Rows.Count-1; i++)
                    {
                        cbmbox_Tables.Items.Add(dt_tables.Rows[i][2].ToString());
                    }

                    for (int i = 0; i <= dt_tables.Rows.Count - 1; i++)
                    {
                        comboBox_SQLTablefromJSON.Items.Add(dt_tables.Rows[i][2].ToString());
                    }

                                       

                }
                //--------------


                


                cnn.Close();
            }
            catch(Exception exc)
            {
                //------------------
                tbx_ConnectionStatus.ForeColor = Color.Red;
                ConnectionStatus = "FAILED!";
                tbx_ConnectionStatus.Text = ConnectionStatus;

                if (ConnectionStatus != "CONNECTED!")
                {
                    groupbox_sqlTable.Enabled = false;
                    groupBox_JSONtoSQL.Enabled = false;
                }
                else
                {
                    groupbox_sqlTable.Enabled = true;
                    groupBox_JSONtoSQL.Enabled = true;
                }
                //-------------------
                //
                MessageBox.Show(exc.Message, "CONNECTION FAILED");
            }


        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            //-----   CREATE DATA TABLE FROM SQL TABLE  ------////

            if(ConnectionStatus == "CONNECTED!") //Connected
            {
                if(cbmbox_Tables.SelectedItem.ToString() != null || cbmbox_Tables.SelectedItem.ToString() != System.String.Empty) //Table Name not Empty
                {
                    try
                    {
                        string query = "SELECT * FROM " + cbmbox_Tables.SelectedItem.ToString();

                        SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString());
                        SqlCommand cmd = new SqlCommand(query, conn);
                        conn.Open();

                        // create data adapter
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        // this will query your database and return the result to your datatable
                        
                        dataTable.Clear();
                        dataTable.Columns.Clear();
                        //dataTable.Rows.Clear();
                      
                        da.Fill(dataTable);
                        conn.Close();
                        da.Dispose();


                        MessageBox.Show("DATA TABLE CREATED");

                        tbx_DataTableCrated.Text = "CREATED!";
                        btn_ViewDataTable.Enabled = true;
                        btn_DataTabletoJSON.Enabled = true;

                        label_RowsColumnsCount.Text = "Columns: " + dataTable.Columns.Count.ToString() + " ;Rows: " + dataTable.Rows.Count.ToString();

                    }
                    catch(Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
                else 
                {
                    MessageBox.Show("NO TABLE NAME");
                }               
            }
            else
            {
                MessageBox.Show("NOT CONNECTED");
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

        private void cbmbox_Tables_Click(object sender, EventArgs e)
        {

            if (cbmbox_Tables.SelectedIndex == -1)
            {
                btn_Create.Enabled = false;
            }
            else
            {
                btn_Create.Enabled = true;
            }
        }

        private void cbmbox_Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmbox_Tables.SelectedIndex == -1)
            {
                btn_Create.Enabled = false;
            }
            else
            {
                btn_Create.Enabled = true;
            }
        }


        public static string DataTableNewtonsoftJsonNet(DataTable dataTable)
        {
            if (dataTable == null)
            {
                return string.Empty;
            }
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataTable);
        }

        private void btn_DataTabletoJSON_Click(object sender, EventArgs e)
        {
            ///CREATE JSON FROM DATA TABLE

            try
            {


                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.ShowNewFolderButton = true;
                // Show the FolderBrowserDialog.  
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //textBox1.Text = folderDlg.SelectedPath;
                    Environment.SpecialFolder root = folderDlg.RootFolder;

                    //------------------------------------------------/////

                    string FileName = cbmbox_Tables.Text.ToString() + "_" + DateTime.Now.ToString() + "_JSON.txt";



                    FileName = FileName.Replace(@"/", "-");
                    FileName = FileName.Replace(@":", "-");
                    FileName = FileName.Replace(@" ", "_");


                    string path = folderDlg.SelectedPath + @"\" + FileName; // path to file
                    using (FileStream fs = File.Create(path))
                    {
                        // writing data in string
                        string dataasstring = DataTableNewtonsoftJsonNet(dataTable); //your data
                        byte[] info = new UTF8Encoding(true).GetBytes(dataasstring);
                        fs.Write(info, 0, info.Length);

                        // writing data in bytes already
                        byte[] data = new byte[] { 0x0 };
                        fs.Write(data, 0, data.Length);

                        MessageBox.Show("COMPLETED! \nJSON file created as "+ FileName, "SUCCESS!");

                    }
                    //------------------------------------------------/////

                }

            }
            catch(Exception CreateJSONFileException)
            {
                MessageBox.Show(CreateJSONFileException.Message);
            }







        }

        private void btn_SelectJSONFile_Click(object sender, EventArgs e)
        {
            try
            {
                //Select JSON File
                var FD = new System.Windows.Forms.OpenFileDialog();
                if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileToOpen = FD.FileName;

                    System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);

                    label_JSONFilePath.Text = File.Name;


                    System.IO.StreamReader reader = new System.IO.StreamReader(fileToOpen);

                    btn_CreateDTfromJSON.Enabled = true;
                    btn_ViewDTfromJSON.Enabled = false;
                    comboBox_SQLTablefromJSON.Enabled = false;

                    JSONString = reader.ReadToEnd();

                    

                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
            

        }

        private void groupBox_JSONtoSQL_Enter(object sender, EventArgs e)
        {

        }

        private void btn_CreateDTfromJSON_Click(object sender, EventArgs e)
        {
            //CREATE DATA TABLE from JSON String

            try
            {
                JSONdataTable.Clear();
                JSONdataTable.Columns.Clear();


                JSONdataTable = (DataTable)JsonConvert.DeserializeObject(JSONString, (typeof(DataTable)));

                //Rows & Columns
                label_RowsandColumnsJSON.Text = "Columns: " + JSONdataTable.Columns.Count.ToString() + " ;Rows: " + JSONdataTable.Rows.Count.ToString();


                btn_ViewDTfromJSON.Enabled = true;
                comboBox_SQLTablefromJSON.Enabled = true;
            }
            catch(Exception eee)
            {
                MessageBox.Show(eee.Message);
            }

            

        }

        private void btn_ViewDTfromJSON_Click(object sender, EventArgs e)
        {
            //View Data Table from JSON File

            Form form2 = new Form();
            form2.WindowState = FormWindowState.Maximized;

            DataGridView dataGrid = new DataGridView();


            dataGrid.DataSource = JSONdataTable;
            dataGrid.Height = 900;
            dataGrid.Width = 1800;

            form2.Controls.Add(dataGrid);


            form2.ShowDialog();

        }

        private void comboBox_SQLTablefromJSON_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_SQLTablefromJSON.SelectedIndex == -1)
            {
                btn_InsertIntoSql.Enabled = false;
            }
            else
            {
                btn_InsertIntoSql.Enabled = true;
            }
        }

        private void btn_InsertIntoSql_Click(object sender, EventArgs e)
        {
            //INSERT INTO SQL SERVER TABLE FROM JSON DATA TABLE



            SqlBulkCopy bulkcopy = new SqlBulkCopy(ConnectionString.GetConnectionString());

            bulkcopy.DestinationTableName = comboBox_SQLTablefromJSON.Text; //table.TableName;
            try
            {
                bulkcopy.WriteToServer(JSONdataTable);

                MessageBox.Show("COMPLETED! \nCHECK DATABASE FOR RESULTS", "SUCCESS!");
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message, "FAILED");
            }


        }

        private void btn_MultipleTables_Click(object sender, EventArgs e)
        {
            ScriptMultipleTables scriptMultipleTables = new ScriptMultipleTables();
            scriptMultipleTables.ShowDialog();
        }

        private void tbx_Database_KeyDown(object sender, KeyEventArgs e)
        {
            //Database KeyDown

           
        }
    }
}