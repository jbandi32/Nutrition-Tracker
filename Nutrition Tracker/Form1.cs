using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nutrition_Tracker
{
    public partial class Form1 : Form
    {
        private BindingList<Food> foods;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foods = new BindingList<Food>();
            foods.Add(new Food("Salmon", "3oz", 177, 11));
            foods.Add(new Food("Flank steak", "3.5oz", 192, 8));
            foods.Add(new Food("Avocado", "1 cup", 234, 21));
            foods.Add(new Food("Sweet potato", "1 cup", 114, 0.1));
            foods.Add(new Food("Pineapple", "1 cup", 82, 0.2));
            foods.Add(new Food("White rice", "1 cup", 206, 0.4));

            lbFoods.DataSource = foods;
            lbFoods.DisplayMember = "DisplayString";

            cboFoods.DataSource = foods;
            cboFoods.DisplayMember = "Name";
        }

        private void addToMeal(Food food)
        {
            int calories = int.Parse(lblCalories.Text);
            calories += food.Calories;
            lblCalories.Text = calories.ToString();

            double fat = double.Parse(lblFat.Text);
            fat += food.Fat;
            lblFat.Text = fat.ToString("0.0");
        }

        private void btnAddToMeal_Click(object sender, EventArgs e)
        {
            addFoodToMeal();
        }

        private void lbFoods_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            addFoodToMeal();
        }

        private void addFoodToMeal()
        {
            if (lbFoods.SelectedItem == null)
            {
                return;
            }

            Food selectedFood;

            // selectedFood = (Food)lbFoods.SelectedItem;
            selectedFood = foods[lbFoods.SelectedIndex];

            addToMeal(selectedFood);
        }

        private void lbFoods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCorn_Click(object sender, EventArgs e)
        {
            foods.Add(new Food("Corn", "1 ear", 111, 1.3));
        }
    }
}
