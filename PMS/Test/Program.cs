

using Employee;
using Membership;
using Project;
using status;



//Entry Point code for ECommerce Solution

Console.WriteLine( "Project Management System ");
Console.WriteLine("******************************");

Console.WriteLine("Enter your Email ID");
string email=Console.ReadLine();

Console.WriteLine("Enter your password");
string password=Console.ReadLine();

if(ClientAuth.Validate(email,password))
{
    Console.WriteLine("Welcome to Project Management System");
    Emp emp=new ProjectManager();
    emp.DoWork();
    Console.WriteLine(emp);
    float salary=emp.ComputePay();
    Console.WriteLine("Salary = "+ salary);
}
else{
     Console.WriteLine("Invalid User");
  
}

Console.WriteLine("Thank you for visiting Project Management System");