namespace GenericsDemoLibrary
{
    public class Employee:IComparable<Employee>
    {
        public int Empid { get; set; }
        public string Ename { get; set; }
        public int Deptno { get; set; }

        public int CompareTo(Employee? other)
        {
            return this.Empid.CompareTo(other.Empid);
        }
    }
}
