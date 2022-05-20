using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD.Forms
{
    public partial class FormOrders : Form
    {
        string connStr = "server=localhost;port=368;user=root;database=bd;password=kurkodan;charset=utf8mb4";
        public FormOrders()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             UpdateOrders();
        }

        private async void UpdateOrders()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand($"SELECT * FROM orders", conn);
                    DbDataReader reader = await mySqlCommand.ExecuteReaderAsync();
                    dataGridViewOrders.Rows.Clear();
                    while (reader.Read())
                    {
                        dataGridViewOrders.Rows.Add(
                            new object[]
                            {
                            reader[0].ToString(),
                            reader[1].ToString(),
                            reader[2].ToString(),
                            reader[3].ToString()
                            });
                    }
                    reader.Close();
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private async void UpdateOrdersList(int idOrder)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand($"SELECT * FROM bd.orders_dish WHERE IdOrder=@IdOrder", conn);
                    mySqlCommand.Parameters.AddWithValue("@IdOrder", idOrder);
                    DbDataReader reader = await mySqlCommand.ExecuteReaderAsync();
                    dataGridViewOrdersList.Rows.Clear();
                    while (reader.Read())
                    {
                        dataGridViewOrdersList.Rows.Add(
                            new object[]
                            {
                            reader[0].ToString(),
                            reader[1].ToString(),
                            reader[2].ToString(),
                            reader[3].ToString(),
                            reader[4].ToString()
                            });
                    }
                    reader.Close();
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private  void dataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                 UpdateOrdersList(Convert.ToInt32(dataGridViewOrders.Rows[e.RowIndex].Cells[0].Value));

            }
            if (e.ColumnIndex == 4)
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();

                    if (conn.State == ConnectionState.Open)
                    {
                        MySqlCommand mySqlCommand = new MySqlCommand("DELETE FROM orders WHERE IdOrder = @IdOrder", conn);
                        mySqlCommand.Parameters.AddWithValue("@IdOrder", Convert.ToInt32(dataGridViewOrders.Rows[e.RowIndex].Cells[0].Value));
                        mySqlCommand.ExecuteNonQuery();
                        conn.Close();
                         UpdateOrders();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            /* else if(e.ColumnIndex ==5)
             {

                 MySqlConnection conn = new MySqlConnection(connStr);
                 conn.Open();

                 if (conn.State == ConnectionState.Open)
                 {
                     MySqlCommand mySqlCommand = new MySqlCommand("UPDATE bd.order SET OrderStatus=@OrderStatus,Total=@Total,DataTimeOrder=@DataTimeOrder WHERE IdOrder = @IdOrder", conn);
                     mySqlCommand.Parameters.AddWithValue("@OrderStatus", dataGridViewOrders.Rows[e.RowIndex].Cells[1].Value);
                      mySqlCommand.Parameters.AddWithValue("@Total", dataGridViewOrders.Rows[e.RowIndex].Cells[2].Value);
                     mySqlCommand.Parameters.AddWithValue("@DataTimeOrder", dataGridViewOrders.Rows[e.RowIndex].Cells[3].Value);
                     mySqlCommand.Parameters.AddWithValue("@IdOrder", dataGridViewOrders.Rows[e.RowIndex].Cells[0].Value);
                     mySqlCommand.ExecuteNonQuery();
                     conn.Close();
                 }
                 await UpdateOrders();
             }*/

        }

        private  void dataGridViewOrdersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open(); if (conn.State == ConnectionState.Open)
                    {
                        int idOrders = Convert.ToInt32(dataGridViewOrdersList.Rows[e.RowIndex].Cells[2].Value);
                        MySqlCommand mySqlCommand = new MySqlCommand($"UPDATE bd.orders_dish SET StatusDish=@StatusDish WHERE IdOrders_dish=@IdOrders_dish", conn);
                        mySqlCommand.Parameters.AddWithValue("@StatusDish", "Готово");
                        mySqlCommand.Parameters.AddWithValue("@IdOrders_dish", dataGridViewOrdersList.Rows[e.RowIndex].Cells[0].Value);
                        mySqlCommand.ExecuteNonQuery();
                        mySqlCommand = new MySqlCommand("SELECT COUNT(IdOrders_dish) FROM bd.orders_dish WHERE StatusDish=@StatusDish AND IdOrder=@IdOrder", conn);
                        mySqlCommand.Parameters.AddWithValue("@StatusDish", "В процессе");
                        mySqlCommand.Parameters.AddWithValue("@IdOrder", idOrders);
                        object count = mySqlCommand.ExecuteScalar();

                        if (Convert.ToInt32(count) == 0)
                        {
                            mySqlCommand = new MySqlCommand($"UPDATE orders SET OrderStatus=@OrderStatus WHERE IdOrder=@IdOrder", conn);
                            mySqlCommand.Parameters.AddWithValue("@OrderStatus", "Готово");
                            mySqlCommand.Parameters.AddWithValue("@IdOrder", dataGridViewOrdersList.Rows[e.RowIndex].Cells[2].Value);
                            mySqlCommand.ExecuteNonQuery();
                             UpdateOrders();
                        }
                        conn.Close();
                         UpdateOrdersList(Convert.ToInt32(dataGridViewOrdersList.Rows[e.RowIndex].Cells[2].Value));
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
