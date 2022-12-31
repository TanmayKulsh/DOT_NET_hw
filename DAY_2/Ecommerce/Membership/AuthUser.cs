namespace Membership;
public class AuthUser
{
    public static bool validate(string id,string password){
        if(id == "yash@gmail.com" && password == "gujju"){
            return true;
        }
        return false;
    }

     public static bool Register(string firstName, string lastName, 
                            string email, string location, string contactNumber){
          bool status=false;
          try{
             User theUser=new User();
            theUser.FirstName=firstName;
            theUser.LastName=lastName;
            theUser.Email=email;
            theUser.Location=location;
            theUser.ContactNumber=contactNumber;
            //Store object into persistent medium
            status=true;

          }
          catch(Exception e){
            // Exception handling Code


          }
          finally{
          }
         return status;
    }


}
