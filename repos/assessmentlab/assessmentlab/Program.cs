
Company c =new Company();
c.Name = "Pratian";

Customer cust=new Customer();
cust.Name = "paras";
cust.Age = 20;
cust.CustomerId = 13254579;
cust.EmailId = "paras@gmail.com";
cust.Address = "durga pg";

c.customerC.Add(cust);

Employee emp=new Employee();
emp.Name = "jagrit";
emp.Age = 23;
emp.EmpId = 12354567;
emp.Basic = 20000;
emp.Experience = 4;
emp.Address = "white fields";

c.employeeC.Add(emp);

Console.WriteLine(c.Name );

Console.WriteLine(c.customerC[0].Name +" " +c.customerC[0].Age + " " + c.customerC[0].CustomerId + " " + c.customerC[0].EmailId + " " + c.customerC[0].Address);






//company class
public class Company
{
    public string Name { get; set; }
    // add date
    public int TotalCustomer()
    {
        return 0;
    }
    public float TotalsalaryPayout()
    {
        return 0;
    }
    public Employee GetEmployeeByEmpId(long id)
    {
        Employee emp = new Employee();
        return emp;
    }
    List<Employee> ExperiencedEmployee { get; set; } = new List<Employee>();
    List<Employee> GroupedByAge { get; set; } = new List<Employee>();
    public List<Customer> customerC { get; set; } = new List<Customer>();
    public List<Employee> employeeC { get; set; } = new List<Employee>();



}




//person class
public class Person
{
    public  string Name {get; set; }
    public  int Age { get; set; }

    public  String  Address { get; set; }


}


//Employee class
public class Employee :Person
{
   
    public long EmpId { get; set; }
    public float Basic { get; set; }
    public int Experience { get; set; }
    public float GetSalary()
    {
        float allowance = 0;
       float TotalSalary = Basic + allowance;
        return TotalSalary;
    }
    
}


//customer class
public class Customer:Person
{
   public long CustomerId { get; set; }
   public String EmailId { get; set; }

}


//Branch class
public class Branch
{
    public string Name { get; set; }
}

public class SalaryCalculator
{
    static float CalculateAllowance(Employee emp )
    {
        float BaseSalary = emp.Basic;
        float experience = emp.Experience;
        float allowance = 0;
        if (experience<=2)
        {
            allowance=(BaseSalary*30)/ 100;

        }

        if (experience <= 4)
        {
            allowance = (BaseSalary * 40) / 100;

        }
      
        if (experience <= 6)
        {
            allowance = (BaseSalary * 50) / 100;

        }
        
        if (experience > 6)
        {
            allowance = (BaseSalary * 60) / 100;

        }


        return allowance;
    }
}