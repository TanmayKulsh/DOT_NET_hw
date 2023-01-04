using Membership;
using HR;

//Entry point code for Ecommerce Solution

Console.WriteLine("Tanmay's Store");
Console.WriteLine("********************************");

Console.WriteLine("Enter Your Email Id:");
string email = Console.ReadLine();

Console.WriteLine("Enter Your Email password:");
string password = Console.ReadLine();

if(AuthUser.validate(email,password)){

    Console.WriteLine("Welcome to Transflower Store");
    Employee emp=new SalesManager();
    emp.DoWork();
    Console.WriteLine(emp);
    float salary=emp.ComputePay();
    Console.WriteLine("Salary = "+ salary);
}
else{
     Console.WriteLine("Invalid User");
  
}

Console.WriteLine("Thank you for visiting Transflower");

