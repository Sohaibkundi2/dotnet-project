namespace login
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            comboBoxCity = new ComboBox();
            labelCity = new Label();
            comboBoxUniversity = new ComboBox();
            labelUniversity = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 178);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Chartreuse;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(34, 19);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 2;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Bisque;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(678, 397);
            button1.Name = "button1";
            button1.Size = new Size(97, 31);
            button1.TabIndex = 0;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBoxCity
            // 
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(106, 78);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(121, 23);
            comboBoxCity.TabIndex = 3;
            comboBoxCity.SelectedIndexChanged += comboBoxCity_SelectedIndexChanged;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(106, 60);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(71, 15);
            labelCity.TabIndex = 4;
            labelCity.Text = "Choose City";
            // 
            // comboBoxUniversity
            // 
            comboBoxUniversity.FormattingEnabled = true;
            comboBoxUniversity.Location = new Point(311, 78);
            comboBoxUniversity.Name = "comboBoxUniversity";
            comboBoxUniversity.Size = new Size(121, 23);
            comboBoxUniversity.TabIndex = 5;
            // 
            // labelUniversity
            // 
            labelUniversity.AutoSize = true;
            labelUniversity.Location = new Point(311, 60);
            labelUniversity.Name = "labelUniversity";
            labelUniversity.Size = new Size(59, 15);
            labelUniversity.TabIndex = 6;
            labelUniversity.Text = "University";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelUniversity);
            Controls.Add(comboBoxUniversity);
            Controls.Add(labelCity);
            Controls.Add(comboBoxCity);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button button1;
        private ComboBox comboBoxCity;
        private Label labelCity;
        private ComboBox comboBoxUniversity;
        private Label labelUniversity;
    }
}