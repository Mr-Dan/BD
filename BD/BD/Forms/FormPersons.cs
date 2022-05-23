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
    public partial class FormPersons : Form
    {

        string connStr = "server=localhost;port=368;user=root;database=bd;password=kurkodan;charset=utf8mb4";
        public FormPersons()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdatePersonsAsync();
        }

        private void dataGridViewPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //update
                if (e.ColumnIndex == 9)
                {
                    Person person = new Person();
                    person.IdPerson = dataGridViewPersons.Rows[e.RowIndex].Cells[0].Value.ToString();
                    person.NamePerson = dataGridViewPersons.Rows[e.RowIndex].Cells[1].Value.ToString();
                    person.LastNamePerson = dataGridViewPersons.Rows[e.RowIndex].Cells[2].Value.ToString();
                    person.MiddleNamePerson = dataGridViewPersons.Rows[e.RowIndex].Cells[3].Value.ToString();
                    person.PositionPerson = dataGridViewPersons.Rows[e.RowIndex].Cells[4].Value.ToString();
                    person.AgePerson = dataGridViewPersons.Rows[e.RowIndex].Cells[5].Value.ToString();
                    person.Login = dataGridViewPersons.Rows[e.RowIndex].Cells[6].Value.ToString();
                    person.Password = dataGridViewPersons.Rows[e.RowIndex].Cells[7].Value.ToString();
                    person.Privileges = dataGridViewPersons.Rows[e.RowIndex].Cells[8].Value.ToString();
                    if (person.IsTrue)
                    {
                        MySqlConnection conn = new MySqlConnection(connStr);
                        conn.Open();
                        if (conn.State == ConnectionState.Open)
                        {
                            MySqlCommand mySqlCommand = new MySqlCommand("UPDATE persons SET NamePerson=@NamePerson,LastNamePerson=@LastNamePerson,MiddleNamePerson=@MiddleNamePerson,PositionPerson=@PositionPerson,AgePerson=@AgePerson,login=@login,password=@password,privileges=@privileges WHERE idPerson = @idPerson", conn);
                            mySqlCommand.Parameters.AddWithValue("@idPerson", person.IdPerson);
                            mySqlCommand.Parameters.AddWithValue("@NamePerson", person.NamePerson);
                            mySqlCommand.Parameters.AddWithValue("@LastNamePerson", person.LastNamePerson);
                            mySqlCommand.Parameters.AddWithValue("@MiddleNamePerson", person.MiddleNamePerson);
                            mySqlCommand.Parameters.AddWithValue("@PositionPerson", person.PositionPerson);
                            mySqlCommand.Parameters.AddWithValue("@AgePerson", person.AgePerson);
                            mySqlCommand.Parameters.AddWithValue("@login", person.Login);
                            mySqlCommand.Parameters.AddWithValue("@password", person.Password);
                            mySqlCommand.Parameters.AddWithValue("@privileges", person.Privileges);
                            mySqlCommand.ExecuteNonQuery();
                            conn.Close();
                        }
                        UpdatePersonsAsync();
                    }
                    else { MessageBox.Show(person.ErrorString); }
                }
                //delete
                else if (e.ColumnIndex == 10)
                {
                    Person person = new Person();
                    person.IdPerson = dataGridViewPersons.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (person.IsTrue)
                    {
                        MySqlConnection conn = new MySqlConnection(connStr);
                        conn.Open();
                        if (conn.State == ConnectionState.Open)
                        {
                            MySqlCommand mySqlCommand = new MySqlCommand("DELETE FROM persons WHERE idPerson = @idPerson", conn);
                            mySqlCommand.Parameters.AddWithValue("@idPerson", person.IdPerson);
                            mySqlCommand.ExecuteNonQuery();
                            conn.Close();
                        }
                        UpdatePersonsAsync();
                    }
                    else { MessageBox.Show(person.ErrorString); }
                }
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
                conn.Open();
                MySqlCommand mySqlCommand = new MySqlCommand($"SELECT * FROM persons", conn);
                DbDataReader reader = await mySqlCommand.ExecuteReaderAsync();
                dataGridViewPersons.Rows.Clear();
                while (reader.Read())
                {
                    dataGridViewPersons.Rows.Add(
                        new object[]
                        {
                            reader[0].ToString(),
                            reader[1].ToString(),
                            reader[2].ToString(),
                            reader[3].ToString(),
                            reader[4].ToString(),
                            reader[5].ToString(),
                            reader[6].ToString(),
                            reader[7].ToString(),
                            reader[8].ToString()
                        });
                }
                reader.Close();
                conn.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPersons_Click(object sender, EventArgs e)
        {
            panelPersons.Visible = true;
        }

        private void buttonPersonClose_Click(object sender, EventArgs e)
        {
            panelPersons.Visible = false;
        }

        private void buttonPersonDone_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.NamePerson = textBoxPersonName.Text;
            person.LastNamePerson = textBoxPersonLastName.Text;
            person.MiddleNamePerson = textBoxPersonMiddleName.Text;
            person.PositionPerson = textBoxPersonPosition.Text;
            person.AgePerson = textBoxPersonAge.Text;
            person.Login = textBoxLogin.Text;
            person.Password = textBoxPassword.Text;
            person.Privileges = textBoxPrivileges.Text;
            if (person.IsTrue)
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        MySqlCommand mySqlCommand = new MySqlCommand("Select login FROM persons WHERE login=@login", conn);
                        mySqlCommand.Parameters.AddWithValue("@login", person.Login);
                        int index = mySqlCommand.ExecuteNonQuery();
                        if (index == -1)
                        {
                            mySqlCommand = new MySqlCommand("INSERT INTO persons (NamePerson,LastNamePerson,MiddleNamePerson,PositionPerson,AgePerson,login,password,privileges)" +
                            " VALUES(@NamePerson,@LastNamePerson,@MiddleNamePerson,@PositionPerson,@AgePerson,@login,@password,@privileges)", conn);
                            mySqlCommand.Parameters.AddWithValue("@NamePerson", person.NamePerson);
                            mySqlCommand.Parameters.AddWithValue("@LastNamePerson", person.LastNamePerson);
                            mySqlCommand.Parameters.AddWithValue("@MiddleNamePerson", person.MiddleNamePerson);
                            mySqlCommand.Parameters.AddWithValue("@PositionPerson", person.PositionPerson);
                            mySqlCommand.Parameters.AddWithValue("@AgePerson", person.AgePerson);
                            mySqlCommand.Parameters.AddWithValue("@login", person.Login);
                            mySqlCommand.Parameters.AddWithValue("@password", person.Password);
                            mySqlCommand.Parameters.AddWithValue("@privileges", person.Privileges);
                            mySqlCommand.ExecuteNonQuery();
                            conn.Close();
                            panelPersons.Visible = false;
                            UpdatePersonsAsync();
                        }
                        else
                        {
                            MessageBox.Show("Такой логин занят");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else { MessageBox.Show(person.ErrorString); }
        }
    }
}
