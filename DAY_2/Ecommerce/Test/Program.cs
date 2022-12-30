using Membership;

//Entry point code for Ecommerce Solution

Console.WriteLine("Tanmay's Store");
Console.WriteLine("********************************");

Console.WriteLine("Enter Your Email Id:");
string email = Console.ReadLine();

Console.WriteLine("Enter Your Email password:");
string password = Console.ReadLine();

if(AuthUser.validate(email,password)){
    Console.WriteLine("Welcome to YASH GUJJU'S flower");

}
