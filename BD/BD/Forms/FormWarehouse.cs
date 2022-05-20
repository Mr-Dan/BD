using BD.Models;
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
    public partial class FormWarehouse : Form
    {
        private MySqlDataAdapter mySqlDataAdapter;
        string connStr = "server=localhost;port=368;user=root;database=bd;password=kurkodan;charset=utf8mb4";
        public FormWarehouse()
        {
            InitializeComponent();
            dateTimePickerShelfLifeProduct.CustomFormat = "MM-dd-yyyy HH:mm:ss";
            dateTimePickerShelfLifeProduct.Format = DateTimePickerFormat.Custom;
        }

        private  void button1_Click(object sender, EventArgs e)
        {
             UpdateWarehouseAsync();
             UpdateProductAsync(dataGridViewProducts);

        }

        private void buttonWarehouse_Click(object sender, EventArgs e)
        {
            panelWarehouse.Visible = true;
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            panelProduct.Visible = true;
        }

        private void buttonProductClose_Click(object sender, EventArgs e)
        {
            panelProduct.Visible = false;
        }

        private  void buttonProductDone_Click(object sender, EventArgs e)
        {
            try
            {

                Products products = new Products();

                products.NameProduct = textBoxProductName.Text;
                products.UnitProduct = textBoxProductUnit.Text;
                if (products.Istrue)
                {
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO products (NameProduct, UnitProduct) VALUES (@Name, @Unit);", conn);
                        mySqlCommand.Parameters.AddWithValue("@Name", products.NameProduct);
                        mySqlCommand.Parameters.AddWithValue("@Unit", products.UnitProduct);
                        mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand.CommandText, conn);
                        mySqlCommand.ExecuteNonQuery();
                        conn.Close();

                        panelProduct.Visible = false;
                         UpdateProductAsync(dataGridViewProducts);
                    }
                }
                else MessageBox.Show(products.ErrorString);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void buttonWarehouseClose_Click(object sender, EventArgs e)
        {
            panelWarehouse.Visible = false;
            dataGridViewProductsGet.Visible = false;
        }

        private  void buttonWarehouseDone_Click(object sender, EventArgs e)
        {
            try
            {
                Warehouse warehouse = new Warehouse();
                warehouse.IdProducts = Convert.ToInt32(textBoxIdProducts.Text);
                warehouse.CountProduct = Convert.ToDouble(textBoxCountProduct.Text);
                warehouse.ShelfLifeProduct = dateTimePickerShelfLifeProduct.Text;
                if (warehouse.Istrue)
                {
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO warehouse (IdProducts, CountProduct,ShelfLifeProduct) VALUES (@IdProducts, @CountProduct,@ShelfLifeProduct)", conn);
                        mySqlCommand.Parameters.AddWithValue("@IdProducts", warehouse.IdProducts);
                        mySqlCommand.Parameters.AddWithValue("@CountProduct", warehouse.CountProduct);
                        mySqlCommand.Parameters.AddWithValue("@ShelfLifeProduct", warehouse.ShelfLifeProduct);
                        mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand.CommandText, conn);
                        mySqlCommand.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                else MessageBox.Show(warehouse.ErrorString);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
              
            }
            panelWarehouse.Visible = false;
             UpdateWarehouseAsync();
        }

        private void dataGridViewWarehouse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void UpdateWarehouseAsync()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand($"SELECT * FROM warehouse w INNER JOIN products p ON w.IdProducts=p.IdProducts", conn);
                    DbDataReader reader = await mySqlCommand.ExecuteReaderAsync();
                    dataGridViewWarehouse.Rows.Clear();
                    while (reader.Read())
                    {
                        dataGridViewWarehouse.Rows.Add(
                            new object[]
                            {
                            reader[0].ToString(),
                            reader[1].ToString(),
                            reader[2].ToString(),
                            reader[3].ToString(),
                            reader[5].ToString(),
                            reader[6].ToString()
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

        private async void UpdateProductAsync(DataGridView dataGridView)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand($"SELECT * FROM products", conn);
                    DbDataReader reader = await mySqlCommand.ExecuteReaderAsync();
                    dataGridView.Rows.Clear();
                    while (reader.Read())
                    {
                        dataGridView.Rows.Add(
                            new object[]
                            {
                            reader[0].ToString(),
                            reader[1].ToString(),
                            reader[2].ToString(),
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
        private  void dataGridViewWarehouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //update
            if (e.ColumnIndex == 6)
            {
                try
                {
                    Warehouse warehouse = new Warehouse();
                    warehouse.IdProductsWarehouse = Convert.ToInt32(dataGridViewWarehouse.Rows[e.RowIndex].Cells[0].Value);
                    warehouse.IdProducts = Convert.ToInt32(dataGridViewWarehouse.Rows[e.RowIndex].Cells[1].Value);
                    warehouse.CountProduct = Convert.ToDouble(dataGridViewWarehouse.Rows[e.RowIndex].Cells[2].Value);
                    warehouse.ShelfLifeProduct = dataGridViewWarehouse.Rows[e.RowIndex].Cells[3].Value.ToString();
                    if (warehouse.Istrue)
                    {
                        MySqlConnection conn = new MySqlConnection(connStr);
                        conn.Open();

                        if (conn.State == ConnectionState.Open)
                        {
                            MySqlCommand mySqlCommand = new MySqlCommand("UPDATE warehouse SET CountProduct=@CountProduct,ShelfLifeProduct=@ShelfLifeProduct WHERE IdProductsWarehouse = @IdProductsWarehouse", conn);
                            mySqlCommand.Parameters.AddWithValue("@IdProductsWarehouse", Convert.ToInt32(dataGridViewWarehouse.Rows[e.RowIndex].Cells[0].Value));
                            mySqlCommand.Parameters.AddWithValue("@CountProduct", warehouse.CountProduct);
                            mySqlCommand.Parameters.AddWithValue("@ShelfLifeProduct", warehouse.ShelfLifeProduct);
                            mySqlCommand.ExecuteNonQuery();
                            conn.Close();
                        }
                         UpdateWarehouseAsync();
                    }
                    else MessageBox.Show(warehouse.ErrorString);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //delete
            else if (e.ColumnIndex == 7)
            {

                try
                {
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();

                    if (conn.State == ConnectionState.Open)
                    {
                        MySqlCommand mySqlCommand = new MySqlCommand("DELETE FROM warehouse WHERE IdProductsWarehouse = @IdProductsWarehouse", conn);
                        mySqlCommand.Parameters.AddWithValue("@IdProductsWarehouse", Convert.ToInt32(dataGridViewWarehouse.Rows[e.RowIndex].Cells[0].Value));
                        mySqlCommand.ExecuteNonQuery();
                        conn.Close();

                    }
                     UpdateWarehouseAsync();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private  void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //update
            if (e.ColumnIndex == 3)
            {
                try
                {
                    Products products = new Products();
                    products.IdProducts = Convert.ToInt32(dataGridViewProducts.Rows[e.RowIndex].Cells[0].Value);
                    products.NameProduct = dataGridViewProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                    products.UnitProduct = dataGridViewProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();

                    if (conn.State == ConnectionState.Open)
                    {
                        MySqlCommand mySqlCommand = new MySqlCommand("UPDATE products SET NameProduct=@NameProduct,UnitProduct=@UnitProduct WHERE IdProducts = @IdProducts", conn);
                        mySqlCommand.Parameters.AddWithValue("@IdProducts", products.IdProducts);
                        mySqlCommand.Parameters.AddWithValue("@NameProduct", products.NameProduct);
                        mySqlCommand.Parameters.AddWithValue("@UnitProduct", products.UnitProduct);
                        mySqlCommand.ExecuteNonQuery();
                        conn.Close();
                    }
                     UpdateProductAsync(dataGridViewProducts);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //delete
            else if (e.ColumnIndex == 4)
            {

                try
                {
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();

                    if (conn.State == ConnectionState.Open)
                    {

                        MySqlCommand mySqlCommand = new MySqlCommand("DELETE FROM products WHERE IdProducts = @IdProducts", conn);
                        mySqlCommand.Parameters.AddWithValue("@IdProducts", Convert.ToInt32(dataGridViewProducts.Rows[e.RowIndex].Cells[0].Value));
                        mySqlCommand.ExecuteNonQuery();
                        conn.Close();

                    }
                     UpdateProductAsync(dataGridViewProducts);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private  void buttonGetIdProduct_Click(object sender, EventArgs e)
        {
            dataGridViewProductsGet.Visible = true;
             UpdateProductAsync(dataGridViewProductsGet);
        }

        private void dataGridViewProductsGet_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBoxIdProducts.Text = dataGridViewProductsGet.Rows[e.RowIndex].Cells[0].Value.ToString();
            dataGridViewProductsGet.Visible = false;

        }

        private  void textBoxIdProducts_Click(object sender, EventArgs e)
        {
            dataGridViewProductsGet.Visible = true;
             UpdateProductAsync(dataGridViewProductsGet);
        }
    }
}
