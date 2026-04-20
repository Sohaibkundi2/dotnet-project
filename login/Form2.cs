using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            comboBoxCity.Items.Add("DIKhan");
            comboBoxCity.Items.Add("Lahore");
            comboBoxCity.Items.Add("Islamabad");
            comboBoxCity.Items.Add("Karachi");
            comboBoxCity.Items.Add("Peshawar");
            comboBoxCity.Items.Add("Tank");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = "Wellcome To Laptop Status Dashboard...";
            this.Text = "User Dashboard";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Logged out successfully.");
                this.Close();
            } else
            {
                MessageBox.Show("Logout cancelled.");
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {



            comboBoxUniversity.Items.Clear();
            comboBoxDepartment.Items.Clear();
            switch (comboBoxCity.Text)
            {
                case "DIKhan":
                    {
                        comboBoxUniversity.Items.Add("Gomal University");
                        comboBoxUniversity.Items.Add("Qurtuba University");
                        break;
                    }
                case "Lahore":
                    {
                        comboBoxUniversity.Items.Add("University of the Punjab");
                        comboBoxUniversity.Items.Add("UET Lahore");
                        comboBoxUniversity.Items.Add("GCU Lahore");
                        break;
                    }
                case "Islamabad":
                    {
                        comboBoxUniversity.Items.Add("NUST");
                        comboBoxUniversity.Items.Add("Quaid-i-Azam University");
                        comboBoxUniversity.Items.Add("FAST-NUCES");
                        break;
                    }
                case "Tank":
                    {
                        comboBoxUniversity.Items.Add("GU (Tank Campus)");
                        break;
                    }
                case "Peshawar":
                    {
                        comboBoxUniversity.Items.Add("University of Peshawar");
                        comboBoxUniversity.Items.Add("UET Peshawar");
                        comboBoxUniversity.Items.Add("Islamia College University");
                        break;
                    }
                case "Karachi":
                    {
                        comboBoxUniversity.Items.Add("University of Karachi");
                        comboBoxUniversity.Items.Add("NED University");
                        comboBoxUniversity.Items.Add("IBA Karachi");
                        break;
                    }
            }
        }

        private void comboBoxUniversity_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDepartment.Items.Clear();

            if (comboBoxUniversity.Text == "Gomal University" || comboBoxUniversity.Text == "Qurtuba University")
            {
                comboBoxDepartment.Items.Add("Computer Science");
                comboBoxDepartment.Items.Add("Zoology");
                comboBoxDepartment.Items.Add("Physics");
                comboBoxDepartment.Items.Add("English");
            }
            else if (comboBoxUniversity.Text == "GU (Tank Campus)")
            {
                comboBoxDepartment.Items.Add("Computer Science");
                comboBoxDepartment.Items.Add("Zoology");
            }
            else if (comboBoxUniversity.Text == "University of the Punjab")
            {
                comboBoxDepartment.Items.Add("Software Engineering");
                comboBoxDepartment.Items.Add("Data Science");
                comboBoxDepartment.Items.Add("Law");
            }

        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDegree.Items.Clear();

            if (comboBoxDepartment.Text == "Computer Science")
            {
                comboBoxDegree.Items.Add("BS (4-Year)");
                comboBoxDegree.Items.Add("MS / Master");
                comboBoxDegree.Items.Add("PhD");
            }
            else if (comboBoxDepartment.Text == "Software Engineering" || comboBoxDepartment.Text == "Data Science")
            {
                comboBoxDegree.Items.Add("BS (4-Year)");
                comboBoxDegree.Items.Add("MS / Master");
            }
            else if (comboBoxDepartment.Text == "Zoology" || comboBoxDepartment.Text == "Physics")
            {
                comboBoxDegree.Items.Add("BS");
                comboBoxDegree.Items.Add("MSc");
                comboBoxDegree.Items.Add("MPhil");
                comboBoxDegree.Items.Add("PhD");
            }
            else
            {
                comboBoxDegree.Items.Add("BS");
                comboBoxDegree.Items.Add("Master");
            }
        }

    }
}
