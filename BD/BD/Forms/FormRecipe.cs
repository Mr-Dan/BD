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
    public partial class FormRecipe : Form
    {
        List<string> dishType;
        public FormRecipe()
        {
            InitializeComponent();
            dishType = new List<string>();
        }

        int idDish = 0;
        string connStr = "server=localhost;port=368;user=root;database=bd;password=kurkodan;charset=utf8mb4";

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = idDish.ToString();
            e.Row.Cells[1].Value = "Auto";

        }

        private void buttonDishDone_Click(object sender, EventArgs e)
        {
            Dish dish = new Dish();
            dish.NameDish = textBoxDishName.Text;
            dish.ReadytTmeDish = textBoxReadytTmeDish.Text;
            dish.CostDish = textBoxCostDish.Text;
            dish.ImageDish = textBoxImage.Text;
            dish.TypeDish = textBoxTypeDish.Text;
            if (dish.IsTrue)
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO dish (NameDish,ReadytTmeDish,CostDish,ImageDish,TypeDish) VALUES (@NameDish,@ReadytTmeDish,@CostDish,@ImageDish,@TypeDish)", conn);
                        mySqlCommand.Parameters.AddWithValue("@NameDish", dish.NameDish);
                        mySqlCommand.Parameters.AddWithValue("@ReadytTmeDish", dish.ReadytTmeDish);
                        mySqlCommand.Parameters.AddWithValue("@CostDish", dish.CostDish);
                        mySqlCommand.Parameters.AddWithValue("@ImageDish", dish.ImageDish);
                        mySqlCommand.Parameters.AddWithValue("@TypeDish", dish.TypeDish);

                        mySqlCommand.ExecuteNonQuery();
                        //MessageBox.Show(mySqlCommand.LastInsertedId.ToString());
                        conn.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                UpdateDish("SELECT * FROM dish");
            }
            else { MessageBox.Show(dish.ErrorString); }
        }

        private async void UpdateDish(string cmdText)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    comboBoxTypeDish.Items.Clear();
                    comboBoxTypeDish.Text = "";
                       MySqlCommand mySqlCommand = new MySqlCommand(cmdText, conn);
                    DbDataReader reader = await mySqlCommand.ExecuteReaderAsync();
                    dataGridViewDish.Rows.Clear();
                    dishType.Clear();
                    while (reader.Read())
                    {
                        // DESCRIBE dish;
                        dataGridViewDish.Rows.Add(
                            new object[]
                            {
                            reader[0].ToString(),
                            reader[1].ToString(),
                            reader[2].ToString(),
                            reader[3].ToString(),
                            reader[4].ToString(),
                            reader[5].ToString(),
                            reader[6].ToString(),
                            });
                        // dataGridViewDish.collumn[dataGridViewDish.Rows.Count-1].
                        // dataGridViewDish.Columns[0].Name
                        // DESCRIBE  dish; 
                        if (dishType.Contains(reader[5].ToString()) == false) dishType.Add(reader[5].ToString());
                    }
                    reader.Close();
                    conn.Close();
                    comboBoxTypeDish.Items.AddRange(dishType.ToArray());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void UpdateRecipte(int idDish)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    //SELECT * FROM recipe r  INNER JOIN products p ON p.IdProducts=r.IdProducts WHERE idDish=1
                    MySqlCommand mySqlCommand = new MySqlCommand($"SELECT * FROM recipe r  INNER JOIN products p ON p.IdProducts=r.IdProducts WHERE idDish=@idDish", conn);
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
                            reader[5].ToString(),
                            reader[3].ToString(),
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
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDish("SELECT * FROM dish");
        }

        private void dataGridViewDish_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                idDish = Convert.ToInt32(dataGridViewDish.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                panelRecipe.Visible = true;
                // panelRecipe.Location = new Point(e.);
                UpdateRecipte(idDish);

            }
            //update
            else if (e.ColumnIndex == 7)
            {
                Dish dish = new Dish();
                dish.IdDish = dataGridViewDish.Rows[e.RowIndex].Cells[0].Value.ToString();
                dish.NameDish = dataGridViewDish.Rows[e.RowIndex].Cells[1].Value.ToString();
                dish.ReadytTmeDish = dataGridViewDish.Rows[e.RowIndex].Cells[2].Value.ToString();
                dish.CostDish = dataGridViewDish.Rows[e.RowIndex].Cells[3].Value.ToString();
                dish.ImageDish = dataGridViewDish.Rows[e.RowIndex].Cells[4].Value.ToString();
                dish.TypeDish = dataGridViewDish.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (dish.IsTrue)
                {
                    try
                    {
                        MySqlConnection conn = new MySqlConnection(connStr);
                        conn.Open();

                        if (conn.State == ConnectionState.Open)
                        {

                            MySqlCommand mySqlCommand = new MySqlCommand("UPDATE dish SET NameDish=@NameDish,ReadytTmeDish=@ReadytTmeDish,CostDish=@CostDish,ImageDish=@ImageDish,TypeDish=@TypeDish WHERE IdDish = @IdDish", conn);
                            mySqlCommand.Parameters.AddWithValue("@IdDish", dish.IdDish);
                            mySqlCommand.Parameters.AddWithValue("@NameDish", dish.NameDish);
                            mySqlCommand.Parameters.AddWithValue("@ReadytTmeDish", dish.ReadytTmeDish);
                            mySqlCommand.Parameters.AddWithValue("@CostDish", dish.CostDish);
                            mySqlCommand.Parameters.AddWithValue("@ImageDish", dish.ImageDish);
                            mySqlCommand.Parameters.AddWithValue("@TypeDish", dish.TypeDish);
                            mySqlCommand.ExecuteNonQuery();
                            conn.Close();
                        }
                        UpdateDish("SELECT * FROM dish");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else { MessageBox.Show(dish.ErrorString); }
            }
            //delete
            else if (e.ColumnIndex == 8)
            {
                Dish dish = new Dish();
                dish.IdDish = dataGridViewDish.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (dish.IsTrue)
                {
                    try
                    {
                        MySqlConnection conn = new MySqlConnection(connStr);
                        conn.Open();

                        if (conn.State == ConnectionState.Open)
                        {
                            MySqlCommand mySqlCommand = new MySqlCommand("DELETE FROM dish WHERE IdDish = @IdDish", conn);
                            mySqlCommand.Parameters.AddWithValue("@IdDish", dataGridViewDish.Rows[e.RowIndex].Cells[0].Value);
                            mySqlCommand.ExecuteNonQuery();
                            conn.Close();

                        }
                        UpdateDish("SELECT * FROM dish");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else { MessageBox.Show(dish.ErrorString); }
            }
        }

        private void buttonRecipeDone_Click(object sender, EventArgs e)
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
                                Recipe recipe = new Recipe();
                                recipe.Idrecipe = dataGridViewRecipe.Rows[i].Cells[1].Value.ToString();
                                recipe.IdProducts = dataGridViewRecipe.Rows[i].Cells[2].Value.ToString();
                                recipe.IdDish = dataGridViewRecipe.Rows[i].Cells[0].Value.ToString();
                                recipe.Needed_amount = dataGridViewRecipe.Rows[i].Cells[4].Value.ToString();
                                if (recipe.IsTrue)
                                {
                                    MySqlCommand mySqlCommand = new MySqlCommand("UPDATE recipe SET IdProducts=@IdProducts,IdDish=@IdDish,Needed_amount=@Needed_amount WHERE Idrecipe=@Idrecipe", conn);
                                    mySqlCommand.Parameters.AddWithValue("@Idrecipe", recipe.Idrecipe);
                                    mySqlCommand.Parameters.AddWithValue("@IdProducts", recipe.IdProducts);
                                    mySqlCommand.Parameters.AddWithValue("@IdDish", recipe.IdDish);
                                    mySqlCommand.Parameters.AddWithValue("@Needed_amount", recipe.Needed_amount);

                                    mySqlCommand.ExecuteNonQuery();
                                }
                                else { MessageBox.Show(recipe.ErrorString); }
                            }
                        }
                        else
                        {
                            if (dataGridViewRecipe.Rows[i].Cells[2].Value.ToString().Length > 0)
                            {
                                Recipe recipe = new Recipe();
                                recipe.IdProducts = dataGridViewRecipe.Rows[i].Cells[2].Value.ToString();
                                recipe.IdDish = dataGridViewRecipe.Rows[i].Cells[0].Value.ToString();
                                recipe.Needed_amount = dataGridViewRecipe.Rows[i].Cells[4].Value.ToString();
                                if (recipe.IsTrue)
                                {
                                    MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO recipe (IdProducts, IdDish,Needed_amount) VALUES (@IdProducts, @IdDish,@Needed_amount)", conn);
                                    mySqlCommand.Parameters.AddWithValue("@IdProducts", recipe.IdProducts);
                                    mySqlCommand.Parameters.AddWithValue("@IdDish", recipe.IdDish);
                                    mySqlCommand.Parameters.AddWithValue("@Needed_amount", recipe.Needed_amount);

                                    mySqlCommand.ExecuteNonQuery();
                                }
                                else { MessageBox.Show(recipe.ErrorString); }
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

            UpdateDish("SELECT * FROM dish");
        }

        private void dataGridViewRecipe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (dataGridViewRecipe.Rows[e.RowIndex].Cells[1].Value.ToString() != "Auto")
                {
                    try
                    {
                        Recipe recipe = new Recipe();
                        recipe.Idrecipe = dataGridViewRecipe.Rows[e.RowIndex].Cells[1].Value.ToString();                
                        if (recipe.IsTrue)
                        {
                            MySqlConnection conn = new MySqlConnection(connStr);
                            conn.Open();
                            if (conn.State == ConnectionState.Open)
                            {
                                MySqlCommand mySqlCommand = new MySqlCommand("DELETE FROM recipe WHERE Idrecipe=@Idrecipe", conn);
                                mySqlCommand.Parameters.AddWithValue("@Idrecipe", recipe.Idrecipe);
                                mySqlCommand.ExecuteNonQuery();
                                conn.Close();
                                UpdateRecipte(idDish);
                            }
                        }
                        else { MessageBox.Show(recipe.ErrorString); }
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
                UpdateProductAsync();
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
                        dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value,
                        dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value,
                        0,
                        dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value
                    }
                );

            panelProduct.Visible = false;
            dataGridViewRecipe.Refresh();

        }
        private async void UpdateProductAsync()
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

        private void buttonCost_Click(object sender, EventArgs e)
        {
            panelCost.Visible = true;
        }

        private void buttonCostClose_Click(object sender, EventArgs e)
        {
            panelCost.Visible = false;
        }

        private void buttonCostUp_Click(object sender, EventArgs e)
        {
            int percentage = 0;
            bool success = int.TryParse(textBoxPercentage.Text, out percentage);
            if (success) costProcedure(percentage);
            else MessageBox.Show("Ошибка в процентах");
        }

        private void buttonCostDown_Click(object sender, EventArgs e)
        {
            int percentage = 0;
            bool success = int.TryParse(textBoxPercentage.Text, out percentage);
            if (success) costProcedure(-percentage);
            else MessageBox.Show("Ошибка в процентах");
        }
       
        private void costProcedure(int Percentage)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {

                    MySqlCommand mySqlCommand = new MySqlCommand("cost_procedure", conn);
                    mySqlCommand.CommandType = CommandType.StoredProcedure;
                    mySqlCommand.Parameters.AddWithValue("@TypeD", comboBoxTypeDish.SelectedItem);
                    mySqlCommand.Parameters.AddWithValue("@persent", Percentage);
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    while(mySqlDataReader.Read())
                    {
                        MessageBox.Show(mySqlDataReader[0].ToString());

                    }
                    

                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                textBoxDishName.Text = ex.Message + "\r\n";
            }

            UpdateDish("SELECT * FROM dish");
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand($"SELECT * FROM products WHERE IdProducts LIKE @IdProducts '%' OR NameProduct LIKE @NameProduct '%' ", conn);
                    mySqlCommand.Parameters.AddWithValue("@IdProducts", textBox1.Text);
                    mySqlCommand.Parameters.AddWithValue("@NameProduct", textBox1.Text);
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

        private void buttonSortDish_Click(object sender, EventArgs e)
        {
            //ASC (по возрастанию) или DESC (по убыванию)
            string textcmd = "SELECT * FROM dish ORDER BY ";
            bool select = false;
            if (comboBox1.SelectedIndex > -1)
            {
                textcmd += GetColumnName(comboBox1.SelectedItem.ToString()) + ",";
                select = true;
            }
            if (comboBox2.SelectedIndex > -1)
            {
                textcmd += GetColumnName(comboBox2.SelectedItem.ToString()) + ",";
                select = true;
            }
            if (comboBox3.SelectedIndex > -1)
            {
                textcmd += GetColumnName(comboBox3.SelectedItem.ToString()) + ",";
                select = true;
            }
            if (comboBox4.SelectedIndex > -1)
            {
                textcmd += GetColumnName(comboBox4.SelectedItem.ToString()) + ",";
                select = true;
            }
            textcmd = textcmd.Trim(',');
            if (select == true) UpdateDish(textcmd);
        }
        // DESCRIBE  dish; 
        private string GetColumnName(string text)
        {
            if (text.Contains("Название"))
            {
                return "NameDish";
            }
            else if (text.Contains("Время приготовления"))
            {
                return "ReadytTmeDish";
            }
            else if (text.Contains("Цена"))
            {
                return "CostDish";
            }
            else if (text.Contains("Тип блюда"))
            {
                return "TypeDish";
            }
            return null;
        }

    }
}
