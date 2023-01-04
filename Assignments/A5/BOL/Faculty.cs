namespace BOL;
using System.ComponentModel.DataAnnotations;
[Serializable] 
public class Faculty
{
    public int FID{get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string Subject{get;set;}
    public string ContactNumber{get;set;}

    public Faculty(){
        this.FID = 1;
        this.FirstName = "tanmay";
        this.LastName = "Kulsk";
        this.Subject = "Java";
        this.ContactNumber =  "9910298810";
    }
    public Faculty(int fID,string fname,string lname,string subject,string ContactNumber){
        this.FID = fID;
        this.FirstName = fname;
        this.LastName = lname;
        this.Subject = subject;
        this.ContactNumber = ContactNumber;
    }

    public override string ToString()
    {
        string str = string.Format("{0},{1},{2},{3},{4}",FID,FirstName,LastName,Subject,ContactNumber);
        return str ;
    }
}
