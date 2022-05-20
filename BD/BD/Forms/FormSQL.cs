using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD.Forms
{
    public partial class FormSQL : Form
    {
        private MySqlDataAdapter mySqlDataAdapter;
        string connStr = "server=localhost;port=368;user=root;database=bd;password=kurkodan;charset=utf8mb4";
        public FormSQL()
        {
            InitializeComponent();
        }

        private async void buttonSQL_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.IndexOf("SELECT") == -1)
                {
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        MySqlCommand sqlCommand = new MySqlCommand(textBox1.Text, conn);
                        sqlCommand.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                else
                     UpdatePersonsAsync();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            } 

            
        }

        private async void UpdatePersonsAsync()
        {
            try
            {
                
                MySqlConnection conn = new MySqlConnection(connStr);
                string sql = textBox1.Text;

                mySqlDataAdapter = new MySqlDataAdapter(sql, conn);
                int rowsGot = -1;
                DataSet DS = new DataSet();
                rowsGot = await mySqlDataAdapter.FillAsync(DS);
                dataGridViewSQL.DataSource = DS.Tables[0];               
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            
            }
        }
    }
}
