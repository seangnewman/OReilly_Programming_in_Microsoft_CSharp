using System;
using System.Windows.Forms;

namespace Basics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region MTLCode
       

        public void SayHello()
        {


            MessageBox.Show("Hello.....");
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            SayHello();
        }
    }
}
