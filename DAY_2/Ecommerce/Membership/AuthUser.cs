namespace Membership;
public class AuthUser
{
    public static bool validate(string id,string password){
        if(id == "yash@gmail.com" && password == "gujju"){
            return true;
        }
        return false;
    }


}
