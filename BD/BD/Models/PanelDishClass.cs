using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD.Models
{
    class PanelDishClass
    {
        Dish Dish;
        public Panel PanelDish { get; set; }
        PictureBox PictureBoxDish { get; set; }
        Label LabelNameDish { get; set; }
        Label LabelCostDish { get; set; }
        public Button ButtonDishOrder { get; set; }

        int Row { get; set; }
        int Column { get; set; }

        public PanelDishClass(Dish dish, Panel panelParent, int row, int column)
        {
            Dish = dish;
            Row = row;
            Column = column;
            SetPanelDish(panelParent);
            SetImage();
            SetNameDish();
            SetCostDish();
            SetButtonDish();
            ControlAdd(PictureBoxDish);
            ControlAdd(LabelNameDish);
            ControlAdd(LabelCostDish);
            ControlAdd(ButtonDishOrder);
        }

        void ControlAdd(Control control)
        {
            PanelDish.Controls.Add(control);
            control.BringToFront();
        }

        void SetPanelDish(Panel panelParent)
        {
            PanelDish = new Panel();
            PanelDish.Name = "PanelDish" + Dish.IdDish + "row" + Row;
            PanelDish.Width = 140;
            PanelDish.Height = 160;
            PanelDish.Parent = panelParent.Parent;
            PanelDish.Location = new Point(Column * 140, Row * 160);
            PanelDish.BackColor = Color.Gray;
        }
        void SetImage()
        {
            PictureBoxDish = new PictureBox();
            PictureBoxDish.BorderStyle = BorderStyle.FixedSingle;
           
            PictureBoxDish.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\" + Dish.ImageDish);
            PictureBoxDish.Location = new Point(20, 0);
            PictureBoxDish.Name = "PictureBoxDish" + Dish.IdDish;
            PictureBoxDish.Size = new Size(100, 80);
            PictureBoxDish.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxDish.TabIndex = 1;
            PictureBoxDish.TabStop = false;
        }
        void SetNameDish()
        {
            LabelNameDish = new Label();
            LabelNameDish.AutoSize = true;
            LabelNameDish.Location = new Point(20, 90);
            LabelNameDish.Name = "LabelNameDish" + Dish.IdDish;
            LabelNameDish.Size = new Size(57, 13);
            LabelNameDish.TabIndex = 2;
            LabelNameDish.Text = Dish.NameDish;
        }
        void SetCostDish()
        {
            LabelCostDish = new Label();
            LabelCostDish.AutoSize = true;
            LabelCostDish.Location = new Point(20, 110);
            LabelCostDish.Name = "LabelCostDish" + Dish.IdDish;
            LabelCostDish.Size = new Size(57, 13);
            LabelCostDish.TabIndex = 2;
            LabelCostDish.Text = Dish.CostDish.ToString();
        }
        void SetButtonDish()
        {
            ButtonDishOrder = new Button();
            ButtonDishOrder.Location = new Point(20, 140);
            ButtonDishOrder.Name = "ButtonDishOrder_" + Dish.IdDish;
            ButtonDishOrder.Size = new Size(100, 20);
            ButtonDishOrder.TabIndex = 0;
            ButtonDishOrder.Text = "Заказать";
            ButtonDishOrder.UseVisualStyleBackColor = true;
        }
    }
}
