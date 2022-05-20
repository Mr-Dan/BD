using BD.Forms;
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

namespace BD
{
    public partial class Form1 : Form
    {
        Form activeForm = null;


        Button currentButton = null;
        Color standardButton = Color.FromArgb(37, 35, 47);
        Color activeButton = Color.FromArgb(123, 119, 159);
        public Form1()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelDesktopPane.Controls.Add(childForm);
            panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;

        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    currentButton = (Button)btnSender;
                    currentButton.BackColor = activeButton;
                    currentButton.ForeColor = Color.White;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = standardButton;
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }



        private void buttonOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormOrder(), sender);
        }

        private void buttonRecipe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRecipe(), sender);
        }

        private void buttonWarehouse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormWarehouse(), sender);
        }

        private void buttonSql_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSQL(), sender);
        }

        private void buttonPersons_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPersons(), sender);

        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormOrders(), sender);

        }
        string connStr = "server=localhost;port=368;user=root;database=bd;password=kurkodan;charset=utf8mb4";

        bool exit = false;
        private async void buttonSignIn_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand($"SELECT privileges FROM persons WHERE login=@login AND password=@password", conn);
                    mySqlCommand.Parameters.AddWithValue("@login", textBoxLogin.Text);
                    mySqlCommand.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    DbDataReader reader = await mySqlCommand.ExecuteReaderAsync();
                    string result = null;

                    while (reader.Read())
                    {
                        result = reader[0].ToString();

                    }
                    if (result == null)
                    {
                        MessageBox.Show("Неправильный логин или пароль");
                    }
                    else if (result.Contains("admin"))
                    {
                        buttonRecipe.Visible = true;
                        buttonWarehouse.Visible = true;
                        buttonSql.Visible = true;
                        buttonPersons.Visible = true;
                        buttonOrders.Visible = true;
                        exit = true;
                        buttonSignInMenu.Text = "Выйти";
                        panelSignIn.Visible = false;
                    }
                    else if (result.Contains("worker"))
                    {
                        buttonRecipe.Visible = true;
                        buttonWarehouse.Visible = true;
                        buttonOrders.Visible = true;
                        exit = true;
                        buttonSignInMenu.Text = "Выйти";
                        panelSignIn.Visible = false;
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

        private void buttonSignInMenu_Click(object sender, EventArgs e)
        {
            if (exit == false)
            {
                panelSignIn.Visible = true;
                panelSignIn.BringToFront();
            }
            else
            {
                buttonRecipe.Visible = false;
                buttonWarehouse.Visible = false;
                buttonSql.Visible = false;
                buttonPersons.Visible = false;
                buttonOrders.Visible = false;
                exit = false;
                buttonSignInMenu.Text = "Войти";
                panelDesktopPane.Controls.Clear();
            }

        }

        private void buttonSignInClose_Click(object sender, EventArgs e)
        {
            panelSignIn.Visible = false;
        }
    }
}
