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
            label2.Text = "Welcome, Sohaib! This is your Dashboard...";
            this.Text = "User Dashboard";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e) {



            comboBoxUniversity.Items.Clear();
            //comboBoxDepartment.Items.Clear();
            switch (comboBoxCity.Text)
            {
                case "DIKhan": {
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
                        comboBoxUniversity.Items.Add("Gomal University (Tank Campus)");
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
    }
}
