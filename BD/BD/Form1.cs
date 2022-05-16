using BD.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if(activeForm!=null)
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

        private void buttonBD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBD(), sender);
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

      
    }
}
