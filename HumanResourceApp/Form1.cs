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
