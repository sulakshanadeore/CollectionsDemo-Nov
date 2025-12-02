using GenericsDemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
                int[] arr = new int[5] { 1, 2, 777334, 4, 4 };
                int[] Answers = m.MultiplyNos(arr);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //int number = int.Parse(textBox1.Text);
                //MessageBox.Show($"You entered {number}");

                string s = textBox1.Text;
                if (s.Length>0)
                {
                    MessageBox.Show(s.ToLower());
                    MessageBox.Show(s.ToUpper());

                   string finalstr = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s);
                    MessageBox.Show(s);

                    //string[] words=s.Split(' ');
                    //for (int i = 0; i < words.Length; i++)
                    //{
                    //words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                    //}
                    //string resultantString = string.Join(" ", words);
                    //MessageBox.Show(resultantString);
                }
            }
            catch (FormatException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally 
            {
                //clsoing connection,releasing resources, cleaning of logs....
                MessageBox.Show("Finally executed whether exception fired or not");

            }
        }
    }
}
