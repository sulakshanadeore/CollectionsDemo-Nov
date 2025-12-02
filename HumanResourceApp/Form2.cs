using GenericsDemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourceApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Maths m = new Maths();
         //   int firstno, secondno, answer;
            try
            {
                int answer=m.DivideNos(Convert.ToInt32(txtfno.Text), Convert.ToInt32(txtsno.Text));
                //firstno = Convert.ToInt32(txtfno.Text);
                //secondno=Convert.ToInt32(txtsno.Text);
                //answer = firstno / secondno;
                txtans.Text=answer.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.GetType().Name);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
