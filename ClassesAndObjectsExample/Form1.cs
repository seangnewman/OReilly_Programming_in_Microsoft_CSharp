using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesAndObjectsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee();
            e1.FirstName = "Sean";
            e1.LastName = "Newman";
            e1.Seniority = 2;

            string p = e1.Promote();
            MessageBox.Show(p);

            Employee e2 = new Employee();
            e2.FirstName = "Alice";
            e2.LastName = "LookingGlass";

        }
    }

     
}
