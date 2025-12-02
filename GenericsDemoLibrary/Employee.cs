namespace GenericsDemoLibrary
{


    public class EmployeeOperations 
    {

        static List<Employee> emplist = new List<Employee>();
        public void AddEmployee(Employee emp)
        {
            emplist.Add(emp);
        }

        public List<Employee> ShowEmpList()
        { 
        return emplist;
        
        }



    }
    public class Employee:IComparable<Employee>
    {

        // public int Empid { get; set; }

        private int _empid;

        public int Empid
        {
            get { return _empid; }
            set {

                if (value <= 0)
                {
                    throw new InvalidDataException("Invalid Employee ID");

                }
               
                else
                    _empid = value; 
            }
        }
        //should not be null,empty and min length 5 chars

        public string Ename { get; set; }
        public int Deptno { get; set; }

        public int CompareTo(Employee? other)
        {
            return this.Ename.CompareTo(other.Ename);
        }


        
    }
}
