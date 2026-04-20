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
            logout = new Button();
            comboBoxCity = new ComboBox();
            labelCity = new Label();
            comboBoxUniversity = new ComboBox();
            labelUniversity = new Label();
            comboBoxDepartment = new ComboBox();
            labelDepartment = new Label();
            comboBoxDegree = new ComboBox();
            labelDegree = new Label();
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
            // logout
            // 
            logout.BackColor = Color.Bisque;
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatStyle = FlatStyle.Flat;
            logout.Font = new Font("Segoe UI", 11F);
            logout.ForeColor = Color.Red;
            logout.Location = new Point(678, 397);
            logout.Name = "logout";
            logout.Size = new Size(97, 31);
            logout.TabIndex = 0;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = false;
            logout.Click += button1_Click;
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
            comboBoxUniversity.SelectedIndexChanged += comboBoxUniversity_SelectedIndexChanged;
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
            // comboBoxDepartment
            // 
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(530, 78);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(121, 23);
            comboBoxDepartment.TabIndex = 7;
            comboBoxDepartment.SelectedIndexChanged += comboBoxDepartment_SelectedIndexChanged;
            // 
            // labelDepartment
            // 
            labelDepartment.AutoSize = true;
            labelDepartment.Location = new Point(530, 60);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(70, 15);
            labelDepartment.TabIndex = 8;
            labelDepartment.Text = "Department";
            // 
            // comboBoxDegree
            // 
            comboBoxDegree.FormattingEnabled = true;
            comboBoxDegree.Location = new Point(106, 155);
            comboBoxDegree.Name = "comboBoxDegree";
            comboBoxDegree.Size = new Size(121, 23);
            comboBoxDegree.TabIndex = 9;
            // 
            // labelDegree
            // 
            labelDegree.AutoSize = true;
            labelDegree.Location = new Point(106, 137);
            labelDegree.Name = "labelDegree";
            labelDegree.Size = new Size(74, 15);
            labelDegree.TabIndex = 10;
            labelDegree.Text = "Degree Level";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelDegree);
            Controls.Add(comboBoxDegree);
            Controls.Add(labelDepartment);
            Controls.Add(comboBoxDepartment);
            Controls.Add(labelUniversity);
            Controls.Add(comboBoxUniversity);
            Controls.Add(labelCity);
            Controls.Add(comboBoxCity);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(logout);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button logout;
        private ComboBox comboBoxCity;
        private Label labelCity;
        private ComboBox comboBoxUniversity;
        private Label labelUniversity;
        private ComboBox comboBoxDepartment;
        private Label labelDepartment;
        private ComboBox comboBoxDegree;
        private Label labelDegree;
    }
}