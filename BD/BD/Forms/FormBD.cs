using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD.Forms
{
    public partial class FormBD : Form
    {
        private MySqlDataAdapter mySqlDataAdapter;
        public FormBD()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // строка подключения к БД
                string connStr = "server=localhost;port=368;user=root;database=bd;password=kurkodan";
                // создаём объект для подключения к БД
                MySqlConnection conn = new MySqlConnection(connStr);
                // запрос
                string sql = "SELECT * FROM products;";
                // объект для чтения ответа сервера
                mySqlDataAdapter = new MySqlDataAdapter(sql, conn);
                int rowsGot = -1;
                DataSet DS = new DataSet();

                rowsGot = await mySqlDataAdapter.FillAsync(DS);
                dataGridView1.DataSource = DS.Tables[0];
                if (rowsGot != -1)
                    textBoxLog.Text += "Rows got from select: " + rowsGot.ToString() + "\r\n";
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                textBoxLog.Text += ex.Message + "\r\n";
                
            }
        }
    }
}
