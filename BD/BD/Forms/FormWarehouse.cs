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

        string connStr = "server=localhost;port=368;user=root;database=bd;password=kurkodan;charset=utf8mb4";
        public FormWarehouse()
        {
            InitializeComponent();
            dateTimePickerShelfLifeProduct.CustomFormat = "MM-dd-yyyy HH:mm:ss";
            dateTimePickerShelfLifeProduct.Format = DateTimePickerFormat.Custom;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void buttonProductDone_Click(object sender, EventArgs e)
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

        private void buttonWarehouseDone_Click(object sender, EventArgs e)
        {
            try
            {
                Warehouse warehouse = new Warehouse();
                warehouse.IdProducts = textBoxIdProducts.Text;
                warehouse.CountProduct = textBoxCountProduct.Text;
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
        private void dataGridViewWarehouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //update
            if (e.ColumnIndex == 6)
            {
                try
                {
                    Warehouse warehouse = new Warehouse();
                    warehouse.IdProductsWarehouse = dataGridViewWarehouse.Rows[e.RowIndex].Cells[0].Value.ToString();
                    warehouse.IdProducts = dataGridViewWarehouse.Rows[e.RowIndex].Cells[1].Value.ToString();
                    warehouse.CountProduct = dataGridViewWarehouse.Rows[e.RowIndex].Cells[2].Value.ToString();
                    warehouse.ShelfLifeProduct = dataGridViewWarehouse.Rows[e.RowIndex].Cells[3].Value.ToString();
                    if (warehouse.Istrue)
                    {
                        MySqlConnection conn = new MySqlConnection(connStr);
                        conn.Open();

                        if (conn.State == ConnectionState.Open)
                        {
                            MySqlCommand mySqlCommand = new MySqlCommand("UPDATE warehouse SET CountProduct=@CountProduct,ShelfLifeProduct=@ShelfLifeProduct WHERE IdProductsWarehouse = @IdProductsWarehouse", conn);
                            mySqlCommand.Parameters.AddWithValue("@IdProductsWarehouse", warehouse.IdProductsWarehouse);
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
                Warehouse warehouse = new Warehouse();
                warehouse.IdProductsWarehouse = dataGridViewWarehouse.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (warehouse.Istrue)
                {
                    try
                    {
                        MySqlConnection conn = new MySqlConnection(connStr);
                        conn.Open();

                        if (conn.State == ConnectionState.Open)
                        {
                            MySqlCommand mySqlCommand = new MySqlCommand("DELETE FROM warehouse WHERE IdProductsWarehouse = @IdProductsWarehouse", conn);
                            mySqlCommand.Parameters.AddWithValue("@IdProductsWarehouse", warehouse.IdProductsWarehouse);
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
                else MessageBox.Show(warehouse.ErrorString);
            }

        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //update
            if (e.ColumnIndex == 3)
            {
                Products products = new Products();
                products.IdProducts = dataGridViewProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                products.NameProduct = dataGridViewProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                products.UnitProduct = dataGridViewProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (products.Istrue)
                {
                    try
                    {

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
                else { MessageBox.Show(products.ErrorString); }
            }
            //delete
            else if (e.ColumnIndex == 4)
            {
                Products products = new Products();
                products.IdProducts = dataGridViewProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (products.Istrue)
                {
                    try
                    {
                        MySqlConnection conn = new MySqlConnection(connStr);
                        conn.Open();

                        if (conn.State == ConnectionState.Open)
                        {

                            MySqlCommand mySqlCommand = new MySqlCommand("DELETE FROM products WHERE IdProducts = @IdProducts", conn);
                            mySqlCommand.Parameters.AddWithValue("@IdProducts", products.IdProducts);
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
                else { MessageBox.Show(products.ErrorString); }
            }

        }

        private void buttonGetIdProduct_Click(object sender, EventArgs e)
        {
            dataGridViewProductsGet.Visible = true;
            UpdateProductAsync(dataGridViewProductsGet);
        }

        private void dataGridViewProductsGet_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBoxIdProducts.Text = dataGridViewProductsGet.Rows[e.RowIndex].Cells[0].Value.ToString();
            dataGridViewProductsGet.Visible = false;

        }

        private void textBoxIdProducts_Click(object sender, EventArgs e)
        {
            dataGridViewProductsGet.Visible = true;
            UpdateProductAsync(dataGridViewProductsGet);
        }
    }
}
