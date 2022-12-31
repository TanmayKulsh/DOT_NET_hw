namespace HR;
public abstract class Employee{

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string ContactNumber { get; set; }
    public string Location { get; set; }
    public DateTime BirthDate { get; set; }

    public float DA { get; set; }
    public float HRA { get; set; }
    public float BasicSalary { get; set; }

    //Constructor chaining

    public Employee() : this(12, "Yash", "Gujarathi", "yash@gmail.com", "9480249283",
                           "shirpur", new DateTime(1999, 12, 25), 10000, 100000, 150000)
    {

    }
    public Employee(int id, string firstName, string lastName,
                      string email, string contactNumber, string location,
                      DateTime bDate, float da, float hra, float bsal
                      )
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Email = email;
        this.Location = location;
        this.ContactNumber = contactNumber;
        this.BirthDate = bDate;
        this.BasicSalary = bsal;
        this.HRA = hra;
        this.DA = da;
    }
    // public abstract void DoWork();
       public abstract void DoWork();

       public virtual float ComputePay(){
        float pay = (DA * 25)+ BasicSalary + HRA;
        return pay;
       }

    public override string ToString()
    {
        string str = string.Format("{0},{1},{2},{3},{4},{5}", Id, FirstName, LastName, Email, ContactNumber, Location);
        return str;
    }
}
