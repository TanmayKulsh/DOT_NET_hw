namespace Banking;

public class Account{
    
    private string firstName = "";
    private string lastName = "";
    private int id;
    private float balance;

    public Account(){

    }
    public Account(int id,string fname,string lname,float amt){
        this.id = id;
        this.firstName = fname;
        this.lastName = lname;
        this.Balance = amt;
    }

    // property
    public string FirstName{
        get{return this.firstName;}
        set{this.firstName = value;}
    }
    public string LastName{
        get{return this.lastName;}
        set{this.lastName = value;}
    }
    public int Id{
        get{return this.id;}
        set{this.id = value;}
    }
    public float Balance{
        get{return this.balance;}
        set{this.balance = value;}
    }
    
}
