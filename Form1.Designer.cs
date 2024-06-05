namespace WeatherApp
{
    partial class Form1
    {
        private Label lblCity;
        private Label lblTemp;
        private Label lblCondition;
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCity = new Label();
            lblTemp = new Label();
            lblCondition = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCity.Location = new Point(72, 138);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(79, 42);
            lblCity.TabIndex = 0;
            lblCity.Text = "City";
            lblCity.Click += lblCity_Click;
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTemp.Location = new Point(72, 203);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(202, 42);
            lblTemp.TabIndex = 1;
            lblTemp.Text = "Temperature";
            lblTemp.Click += lblTemp_Click;
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCondition.Location = new Point(72, 274);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(163, 42);
            lblCondition.TabIndex = 2;
            lblCondition.Text = "Condition";
            lblCondition.Click += lblCondition_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(273, 46);
            label1.TabIndex = 3;
            label1.Text = "WeatherApp";
            // 
            // Form1
            // 
            BackColor = Color.Linen;
            ClientSize = new Size(346, 505);
            Controls.Add(label1);
            Controls.Add(lblCity);
            Controls.Add(lblTemp);
            Controls.Add(lblCondition);
            Name = "Form1";
            Text = "Weather App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Temp;
        private Label label1;
    }
}
