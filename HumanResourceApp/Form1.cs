using GenericsDemoLibrary;

namespace HumanResourceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.Empid = Convert.ToInt32(txtEmpid.Text);
                emp.Ename = txtName.Text;
                emp.Deptno = Convert.ToInt32(txtDeptno.Text);

                EmployeeOperations operations = new EmployeeOperations();
                operations.AddEmployee(emp);
                MessageBox.Show("Record Added successfully....");
                txtEmpid.Text = "";
                txtName.Clear();
                txtDeptno.Clear();
            }
            catch (InvalidDataException ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.GetType().Name);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.GetType().Name);
                //                MessageBox.Show(ex.Message); ;
                MessageBox.Show("I am in format exception");


            }
            catch (Exception ex)//Format & Overflow
            {
                MessageBox.Show(ex.GetType().Name);
                MessageBox.Show(ex.Message);
                MessageBox.Show("I am in General Exception");

            }

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            EmployeeOperations operations = new EmployeeOperations();

            List<Employee> emplist = operations.ShowEmpList();
            listBox1.Items.Clear();
            foreach (var item in emplist)
            {
                listBox1.Items.Add(item.Empid + " " + item.Ename + " " + item.Deptno);
            }
        }

        
    }
}
