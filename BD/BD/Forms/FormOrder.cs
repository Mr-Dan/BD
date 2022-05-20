using BD.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD.Forms
{
    public partial class FormOrder : Form
    {
        List<Dish> dishes = new List<Dish>();
        List<PanelDishClass> panelDishClasses = new List<PanelDishClass>();
        double allCost = 0;
        List<Dish> cart = new List<Dish>();

        public FormOrder()
        {
            InitializeComponent();
        }

        string connStr = "server=localhost;port=368;user=root;database=bd;password=kurkodan;charset=utf8mb4";

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDish();
            panelDishs.Controls.Clear();
            panelDishClasses.Clear();

            int row = 0;
            int column = 0;
            for (int i = 0; i < dishes.Count; i++)
            {
                panelDishClasses.Add(new PanelDishClass(dishes[i], panelDishs, row, column) { });
                panelDishs.Controls.Add(panelDishClasses[panelDishClasses.Count - 1].PanelDish);
                panelDishClasses[panelDishClasses.Count - 1].ButtonDishOrder.Click += new EventHandler(ButtonDishOrder_Click);
                column++;
              
                if (column == 3)
                {
                    column = 0;
                    row++; ;
                }
            }
        }

        private void ButtonDishOrder_Click(object sender, EventArgs e)
        {
            Button Button = new Button();
            Button = (Button)sender;

            string idDish = Regex.Match(Button.Name, @"ButtonDishOrder_(\w)+").Value.Replace("ButtonDishOrder_", "");
            int index = dishes.FindIndex(f => f.IdDish == Convert.ToInt32(idDish));
            if (index > -1)
            {
                dataGridViewOrder.Rows.Add(
                    new object[]
                    {
                        Image.FromFile(Directory.GetCurrentDirectory() + "\\" + dishes[index].ImageDish),
                        dishes[index].NameDish,
                        1,
                        dishes[index].CostDish,

                    }
                    );
                allCost += dishes[index].CostDish;
                cart.Add(new Dish { IdDish = dishes[index].IdDish, NameDish = dishes[index].NameDish, CostDish = dishes[index].CostDish, recipes = dishes[index].recipes });
            }
        }

        private async void UpdateDish()
        {

            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand("SELECT* FROM dish", conn);
                    DbDataReader reader = await mySqlCommand.ExecuteReaderAsync();
                    if (dishes.Count > 0) dishes.Clear();
                    while (reader.Read())
                    {
                        dishes.Add(new Dish
                        {
                            IdDish = Convert.ToInt32(reader[0]),
                            NameDish = reader[1].ToString(),
                            ReadytTmeDish = reader[2].ToString(),
                            CostDish = Convert.ToDouble(reader[3]),
                            ImageDish = reader[4].ToString(),
                            recipes = GetRecipes(Convert.ToInt32(reader[0]))
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

        private void dataGridViewOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                allCost -= Convert.ToDouble(dataGridViewOrder.Rows[e.RowIndex].Cells[3].Value);
                dataGridViewOrder.Rows.RemoveAt(e.RowIndex);
                cart.RemoveAt(e.RowIndex);
            }
        }

        private void buttonOrdersDone_Click(object sender, EventArgs e)
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients = IngredientCheck();
            if (ingredients.FindIndex(f => f.Istrue == false) == -1)
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO orders(Total,DataTimeOrder) VALUES(@Total,@DataTimeOrder)", conn);
                        mySqlCommand.Parameters.AddWithValue("@Total", Convert.ToDouble(allCost));
                        mySqlCommand.Parameters.AddWithValue("@DataTimeOrder", DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss"));
                        mySqlCommand.ExecuteNonQuery();
                        int id = Convert.ToInt32(mySqlCommand.LastInsertedId);

                        for (int i = 0; i < cart.Count; i++)
                        {
                            mySqlCommand = new MySqlCommand("INSERT INTO orders_dish (Cost,IdOrder,IdDish) VALUES (@Cost,@IdOrder,@IdDish)", conn);
                            mySqlCommand.Parameters.AddWithValue("@Cost", cart[i].CostDish);
                            mySqlCommand.Parameters.AddWithValue("@IdOrder", id);
                            mySqlCommand.Parameters.AddWithValue("@IdDish", cart[i].IdDish);
                            mySqlCommand.ExecuteNonQuery();


                            for (int j = 0; j < cart[i].recipes.Count; j++)
                            {
                                //SELECT MIN(bd.warehouse.ShelfLifeProduct) AS "05-15-2022 20:09:21" FROM bd.warehouse;
                                //SELECT IdProductsWarehouse FROM bd.warehouse WHERE ShelfLifeProduct = (SELECT MIN(ShelfLifeProduct) AS  {DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss")}  FROM bd.warehouse)
                                //SELECT IdProductsWarehouse FROM bd.warehouse WHERE ShelfLifeProduct = (SELECT MIN(ShelfLifeProduct) as "05-15-2022 20:09:21"  FROM bd.warehouse) AND IdProducts =1
                                //SELECT IdProductsWarehouse FROM bd.warehouse WHERE ShelfLifeProduct = (SELECT MIN(ShelfLifeProduct) as "05-15-2022 20:09:21"  FROM bd.warehouse where IdProducts =3)  

                                int idwarehouse = 0;
                                double CountProductWerehouse = 0;
                                (idwarehouse, CountProductWerehouse) = (GetWarehouseInfo(cart[i].recipes[j].IdProducts).Item1, GetWarehouseInfo(cart[i].recipes[j].IdProducts).Item2);
                                CountProductWerehouse -= cart[i].recipes[j].Needed_amount;
                                do
                                {
                                    if (CountProductWerehouse < 0)
                                    {
                                        mySqlCommand = new MySqlCommand("DELETE FROM warehouse WHERE IdProductsWarehouse=@IdProductsWarehouse", conn);
                                        mySqlCommand.Parameters.AddWithValue("@IdProductsWarehouse", idwarehouse);
                                        mySqlCommand.ExecuteNonQuery();
                                        double remainder = CountProductWerehouse;
                                        (idwarehouse, CountProductWerehouse) = (GetWarehouseInfo(cart[i].recipes[j].IdProducts).Item1, GetWarehouseInfo(cart[i].recipes[j].IdProducts).Item2);
                                        CountProductWerehouse += remainder;
                                    }

                                } while (CountProductWerehouse < 0);

                                mySqlCommand = new MySqlCommand("UPDATE warehouse SET CountProduct=@CountProduct WHERE IdProductsWarehouse=@IdProductsWarehouse", conn);
                                mySqlCommand.Parameters.AddWithValue("@CountProduct", CountProductWerehouse);
                                mySqlCommand.Parameters.AddWithValue("@IdProductsWarehouse", idwarehouse);
                                mySqlCommand.ExecuteNonQuery();
                            }

                        }
                        cart.Clear();
                        allCost = 0;
                        dataGridViewOrder.Rows.Clear();
                        conn.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                string result = "";
                foreach (Ingredient ingredient in ingredients)
                {
                    result += ingredient.NameProduct + " ";
                }
                MessageBox.Show("Не хватает ингридиентов " + result);
            }

        }
        Tuple<int, double> GetWarehouseInfo(int IdProducts)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand($"SELECT IdProductsWarehouse,CountProduct FROM warehouse WHERE ShelfLifeProduct = (SELECT MIN(ShelfLifeProduct) AS '{DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss")}'  FROM warehouse WHERE IdProducts =@IdProducts)", conn);
                    mySqlCommand.Parameters.AddWithValue("@IdProducts", IdProducts);
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    int idwarehouse = 0;
                    double CountProductWerehouse = 0;
                    while (mySqlDataReader.Read())
                    {
                        idwarehouse = Convert.ToInt32(mySqlDataReader[0]);
                        CountProductWerehouse = Convert.ToDouble(mySqlDataReader[1]);
                    }
                    mySqlDataReader.Close();
                    conn.Close();
                    return Tuple.Create(idwarehouse, CountProductWerehouse);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        List<Recipe> GetRecipes(int idDish)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    List<Recipe> recipes = new List<Recipe>();
                    //SELECT Idrecipe,r.IdProducts,IdDish,Needed_amount,NameProduct FROM bd.recipe r inner join bd.products p on r.IdProducts =p.IdProducts where r.IdDish=2
                    MySqlCommand mySqlCommand = new MySqlCommand("SELECT Idrecipe,r.IdProducts,IdDish,Needed_amount,NameProduct FROM bd.recipe r inner join bd.products p on r.IdProducts =p.IdProducts where IdDish=@IdDish", conn);
                    mySqlCommand.Parameters.AddWithValue("@IdDish", idDish);
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    while (mySqlDataReader.Read())
                    {
                        recipes.Add(new Recipe
                        {
                            Idrecipe = Convert.ToInt32(mySqlDataReader[0]),
                            IdProducts = Convert.ToInt32(mySqlDataReader[1]),
                            IdDish = Convert.ToInt32(mySqlDataReader[2]),
                            Needed_amount = Convert.ToDouble(mySqlDataReader[3]),
                            NameProduct = mySqlDataReader[4].ToString()
                        });
                    }
                    conn.Close();
                    return recipes;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }


        List<Ingredient> IngredientCheck()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            for (int i = 0; i < cart.Count; i++)
            {
                for (int j = 0; j < cart[i].recipes.Count; j++)
                {
                    int index = ingredients.FindIndex(f => f.IdProducts == cart[i].recipes[j].IdProducts);
                    if (index > -1)
                    {
                        ingredients[index].Needed_amount += cart[i].recipes[j].Needed_amount;
                    }
                    else
                    {
                        ingredients.Add(new Ingredient { IdProducts = cart[i].recipes[j].IdProducts, Needed_amount = cart[i].recipes[j].Needed_amount, NameProduct = cart[i].recipes[j].NameProduct });
                    }
                }
            }
            double countProduct = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    for (int i = 0; i < ingredients.Count; i++)
                    {
                        MySqlCommand mySqlCommand = new MySqlCommand("SELECT CountProduct FROM warehouse Where IdProducts=@IdProducts", conn);
                        mySqlCommand.Parameters.AddWithValue("@IdProducts", ingredients[i].IdProducts);
                        MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                        while (mySqlDataReader.Read())
                        {
                            countProduct += Convert.ToDouble(mySqlDataReader[0]);
                        }

                        if (countProduct < ingredients[i].Needed_amount) ingredients[i].Istrue = false;
                        mySqlDataReader.Close();
                        countProduct = 0;
                    }
                    conn.Close();
                    return ingredients;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

    }
  


}
