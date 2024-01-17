namespace Nutrition_Tracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFat = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCorn = new System.Windows.Forms.Button();
            this.btnAddToMeal = new System.Windows.Forms.Button();
            this.lbFoods = new System.Windows.Forms.ListBox();
            this.cboFoods = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Location = new System.Drawing.Point(86, 332);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(13, 13);
            this.lblFat.TabIndex = 48;
            this.lblFat.Text = "0";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Location = new System.Drawing.Point(86, 298);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(13, 13);
            this.lblCalories.TabIndex = 47;
            this.lblCalories.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Fat (g): ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Calories:";
            // 
            // btnAddCorn
            // 
            this.btnAddCorn.Location = new System.Drawing.Point(297, 22);
            this.btnAddCorn.Name = "btnAddCorn";
            this.btnAddCorn.Size = new System.Drawing.Size(84, 23);
            this.btnAddCorn.TabIndex = 44;
            this.btnAddCorn.Text = "Add Corn";
            this.btnAddCorn.UseVisualStyleBackColor = true;
            this.btnAddCorn.Click += new System.EventHandler(this.btnAddCorn_Click);
            // 
            // btnAddToMeal
            // 
            this.btnAddToMeal.Location = new System.Drawing.Point(32, 242);
            this.btnAddToMeal.Name = "btnAddToMeal";
            this.btnAddToMeal.Size = new System.Drawing.Size(103, 23);
            this.btnAddToMeal.TabIndex = 43;
            this.btnAddToMeal.Text = "Add to Meal";
            this.btnAddToMeal.UseVisualStyleBackColor = true;
            this.btnAddToMeal.Click += new System.EventHandler(this.btnAddToMeal_Click);
            // 
            // lbFoods
            // 
            this.lbFoods.FormattingEnabled = true;
            this.lbFoods.Location = new System.Drawing.Point(35, 22);
            this.lbFoods.Name = "lbFoods";
            this.lbFoods.Size = new System.Drawing.Size(183, 160);
            this.lbFoods.TabIndex = 49;
            this.lbFoods.SelectedIndexChanged += new System.EventHandler(this.lbFoods_SelectedIndexChanged);
            this.lbFoods.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbFoods_MouseDoubleClick);
            // 
            // cboFoods
            // 
            this.cboFoods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFoods.FormattingEnabled = true;
            this.cboFoods.Location = new System.Drawing.Point(253, 122);
            this.cboFoods.Name = "cboFoods";
            this.cboFoods.Size = new System.Drawing.Size(128, 21);
            this.cboFoods.TabIndex = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 366);
            this.Controls.Add(this.cboFoods);
            this.Controls.Add(this.lbFoods);
            this.Controls.Add(this.lblFat);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCorn);
            this.Controls.Add(this.btnAddToMeal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCorn;
        private System.Windows.Forms.Button btnAddToMeal;
        private System.Windows.Forms.ListBox lbFoods;
        private System.Windows.Forms.ComboBox cboFoods;
    }
}

