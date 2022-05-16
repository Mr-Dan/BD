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
    public partial class FormRecipe : Form
    {
        MySqlDataAdapter mySqlDataAdapter;
        public FormRecipe()
        {
            InitializeComponent();
        }

        int idDish = 0;
        string nameDish = "";
        string connStr = "server=localhost;port=368;user=root;database=bd;password=kurkodan;charset=utf8mb4";

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = idDish.ToString();
            e.Row.Cells[1].Value = "Auto";

        }

        private async void buttonDishDone_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO dish (NameDish,ReadytTmeDish,CostDish,ImageDish) VALUES (@NameDish,@ReadytTmeDish,@CostDish,@ImageDish)", conn);
                    mySqlCommand.Parameters.AddWithValue("@NameDish", textBoxDishName.Text);
                    mySqlCommand.Parameters.AddWithValue("@ReadytTmeDish", Convert.ToDouble(textBoxReadytTmeDish.Text));
                    mySqlCommand.Parameters.AddWithValue("@CostDish", textBoxCostDish.Text);
                    mySqlCommand.Parameters.AddWithValue("@ImageDish", textBoxImage.Text);
                    mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand.CommandText, conn);
                    mySqlCommand.ExecuteNonQuery();
                    //MessageBox.Show(mySqlCommand.LastInsertedId.ToString());
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            await UpdateDish();
        }

        private async Task UpdateDish()
        {        
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand($"SELECT * FROM dish", conn);
                    DbDataReader reader = await mySqlCommand.ExecuteReaderAsync();
                    dataGridViewDish.Rows.Clear();
                    while (reader.Read())
                    {
                        dataGridViewDish.Rows.Add(
                            new object[]
                            {
                            reader[0].ToString(),
                            reader[1].ToString(),
                            reader[2].ToString(),
                            reader[3].ToString(),
                            reader[4].ToString(),
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

        private async Task UpdateRecipte(int idDish)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string mySql = $"SELECT * FROM recipe WHERE idDish={idDish}";
                    MySqlCommand mySqlCommand = new MySqlCommand($"SELECT * FROM recipe WHERE idDish=@idDish", conn);
                    mySqlCommand.Parameters.AddWithValue("@idDish", idDish);
                    DbDataReader reader = await mySqlCommand.ExecuteReaderAsync();
                    dataGridViewRecipe.Rows.Clear();
                    while (reader.Read())
                    {
                        dataGridViewRecipe.Rows.Add(
                            new object[]
                            {
                            reader[2].ToString(),
                            reader[0].ToString(),
                            reader[1].ToString(),
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
        private async void button1_Click(object sender, EventArgs e)
        {
            await UpdateDish();
        }

        private async void dataGridViewDish_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                idDish = Convert.ToInt32(dataGridViewDish.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                nameDish = dataGridViewDish.Rows[e.RowIndex].Cells[1].Value.ToString();
                panelRecipe.Visible = true;
               // panelRecipe.Location = new Point(e.);
                await UpdateRecipte(idDish);

            }
            //update
            else if (e.ColumnIndex == 5)
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();

                    if (conn.State == ConnectionState.Open)
                    {

                        MySqlCommand mySqlCommand = new MySqlCommand("UPDATE dish SET NameDish=@NameDish,ReadytTmeDish=@ReadytTmeDish,CostDish=@CostDish,ImageDish=@ImageDish WHERE IdDish = @IdDish", conn);
                        mySqlCommand.Parameters.AddWithValue("@IdDish", dataGridViewDish.Rows[e.RowIndex].Cells[0].Value);
                        mySqlCommand.Parameters.AddWithValue("@NameDish", dataGridViewDish.Rows[e.RowIndex].Cells[1].Value);
                        mySqlCommand.Parameters.AddWithValue("@ReadytTmeDish", dataGridViewDish.Rows[e.RowIndex].Cells[2].Value);
                        mySqlCommand.Parameters.AddWithValue("@CostDish", Convert.ToDouble(dataGridViewDish.Rows[e.RowIndex].Cells[3].Value));
                        mySqlCommand.Parameters.AddWithValue("@ImageDish", dataGridViewDish.Rows[e.RowIndex].Cells[4].Value);
                        mySqlCommand.ExecuteNonQuery();
                        conn.Close();
                    }
                    await UpdateDish();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //delete
            else if (e.ColumnIndex == 6)
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();

                    if (conn.State == ConnectionState.Open)
                    {
                        MySqlCommand mySqlCommand = new MySqlCommand("DELETE FROM dish WHERE IdDish = @IdDish", conn);
                        mySqlCommand.Parameters.AddWithValue("@IdDish", Convert.ToInt32(dataGridViewDish.Rows[e.RowIndex].Cells[0].Value));
                        mySqlCommand.ExecuteNonQuery();
                        conn.Close();

                    }
                    await UpdateDish();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void buttonRecipeDone_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    for (int i = 0; i < dataGridViewRecipe.Rows.Count - 1; i++)
                    {
                        if (dataGridViewRecipe.Rows[i].Cells[1].Value.ToString() != "Auto")
                        {
                            if (dataGridViewRecipe.Rows[i].Cells[2].Value.ToString().Length > 0)
                            {
                                MySqlCommand mySqlCommand = new MySqlCommand("UPDATE recipe SET IdProducts=@IdProducts,IdDish=@IdDish,Needed_amount=@Needed_amount WHERE Idrecipe=@Idrecipe", conn);
                                mySqlCommand.Parameters.AddWithValue("@Idrecipe", Convert.ToInt32(dataGridViewRecipe.Rows[i].Cells[1].Value));
                                mySqlCommand.Parameters.AddWithValue("@IdProducts", Convert.ToInt32(dataGridViewRecipe.Rows[i].Cells[2].Value));
                                mySqlCommand.Parameters.AddWithValue("@IdDish", Convert.ToInt32(dataGridViewRecipe.Rows[i].Cells[0].Value));
                                mySqlCommand.Parameters.AddWithValue("@Needed_amount", Convert.ToDouble(dataGridViewRecipe.Rows[i].Cells[3].Value));
                                mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand.CommandText, conn);
                                mySqlCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            if (dataGridViewRecipe.Rows[i].Cells[2].Value.ToString().Length > 0)
                            {
                                MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO recipe (IdProducts, IdDish,Needed_amount) VALUES (@IdProducts, @IdDish,@Needed_amount)", conn);
                                mySqlCommand.Parameters.AddWithValue("@IdProducts", Convert.ToInt32(dataGridViewRecipe.Rows[i].Cells[2].Value));
                                mySqlCommand.Parameters.AddWithValue("@IdDish", Convert.ToInt32(dataGridViewRecipe.Rows[i].Cells[0].Value));
                                mySqlCommand.Parameters.AddWithValue("@Needed_amount", Convert.ToDouble(dataGridViewRecipe.Rows[i].Cells[3].Value));
                                mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand.CommandText, conn);
                                mySqlCommand.ExecuteNonQuery();
                            }
                        }

                    }
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                textBoxDishName.Text = ex.Message + "\r\n";
            }

            await UpdateDish();
        }

        private async void dataGridViewRecipe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (dataGridViewRecipe.Rows[e.RowIndex].Cells[1].Value.ToString() != "Auto")
                {
                    try
                    {
                        MySqlConnection conn = new MySqlConnection(connStr);
                        conn.Open();
                        if (conn.State == ConnectionState.Open)
                        {
                            MySqlCommand mySqlCommand = new MySqlCommand("DELETE FROM recipe WHERE Idrecipe=@Idrecipe", conn);
                            mySqlCommand.Parameters.AddWithValue("@Idrecipe", Convert.ToInt32(dataGridViewRecipe.Rows[e.RowIndex].Cells[1].Value));
                            mySqlCommand.ExecuteNonQuery();
                            conn.Close();
                            await UpdateRecipte(idDish);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    if (dataGridViewRecipe.Rows[e.RowIndex].Cells[2].Value != null && dataGridViewRecipe.Rows[e.RowIndex].Cells[0].Value != null && dataGridViewRecipe.Rows[e.RowIndex].Cells[1].Value != null)
                    {
                        dataGridViewRecipe.Rows.RemoveAt(e.RowIndex);
                        dataGridViewRecipe.Refresh();
                    }
                }
            }
            else if (e.ColumnIndex == 2)
            {
                await UpdateProductAsync();
                panelProduct.Visible = true;
                idProductRow = e.RowIndex;
            }
        }

        int idProductRow = 0;
        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewRecipe.Rows.Add(
                    new object[]
                    {
                        idDish,
                        "Auto",
                        dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value
                    }
                );

            panelProduct.Visible = false;
            dataGridViewRecipe.Refresh();

        }
        private async Task UpdateProductAsync()
        {      
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {                 
                    MySqlCommand mySqlCommand = new MySqlCommand($"SELECT * FROM products", conn);
                    DbDataReader reader = await mySqlCommand.ExecuteReaderAsync();
                    dataGridViewProduct.Rows.Clear();
                    while (reader.Read())
                    {
                        dataGridViewProduct.Rows.Add(
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

        private void buttonProductClose_Click(object sender, EventArgs e)
        {
            panelProduct.Visible = false;
        }

        private void buttonRecipeClose_Click(object sender, EventArgs e)
        {
            panelRecipe.Visible = false;
        }

        private void buttonDishClose_Click(object sender, EventArgs e)
        {
            panelDish.Visible = false;
        }

        private void buttonDishAdd_Click(object sender, EventArgs e)
        {
            panelDish.Visible = true;
            panelDish.BringToFront();
        }
    }
}
