namespace HR;

public class SalesEmployee:Employee{
    public float Target{get;set;}
    public float SalesDone{get;set;}
    public float Incentive{get;set;}


    public SalesEmployee():base(){

    }
    public SalesEmployee(float Target,float SalesDone,float Incentive,int id, string firstName, string lastName,
                      string email, string contactNumber, string location,
                      DateTime bDate, float da, float hra, float bsal):base(id,firstName,lastName,
                      email,contactNumber,location,
                       bDate,da,hra,bsal){

                        this.Target = Target;
                        this.SalesDone = SalesDone;
                        this.Incentive = Incentive;
    }

    public void DoWork(){
        if(SalesDone > Target){
        this.Incentive = 5000;
        }else{
            this.Incentive = 0;
        }
    }

    public override float ComputePay()
    {
        return base.ComputePay() + Incentive;
    }
    public override string ToString(){
       
        return base.ToString+ "Incentive =" +Incentive + ", Tartget="+ Target;
    }


}