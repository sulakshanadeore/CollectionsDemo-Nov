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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
             {

            
            Maths m = new Maths();
            int[] arr = new int[5] { 1, 2, 777334,4,4 };
            int[] Answers=m.MultiplyNos(arr);
            foreach (var item in Answers)
            {
                MessageBox.Show(item.ToString());
            }
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message);//message for the exception
                MessageBox.Show(ex.Source);//where the excecption occured, ie library name(Logic place)
                MessageBox.Show(ex.StackTrace);//line numbers from both the aps, ie windows app and libray also
            }
        }
    }
}
