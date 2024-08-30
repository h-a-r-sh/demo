using System.Diagnostics;
 
class Coforge
{
   public   readonly int EID;  //Instance Read only(Makes separate copy for each object and ensure that one time Initialzation)
    public double Salary;    //Instance variabley(Makes separate copy for each object and we can change the value)
 
    public static int OfficePh;  //Global variable (Makes single copy for all objects and value can be changeable)
 
   public  readonly static int LeavePolicy; //Global variable (Makes single copy for all objects and one time initialization)
 
   public const int EastablishedYear=2001;  //Global variable (Makes single copy but initialzation takes palce at the point of declaration)
 
   static Coforge()
   {
        LeavePolicy=2;
   }
   public Coforge(int id)
   {
    EID=id;
   }
 
}
class Controller
{
 
   public static void Main()
   {
       Coforge deepa=new (1Coforge01);
       //coforge.LeavePolicy=2;    
       Console.WriteLine(Coforge.LeavePolicy) ;
       Console.WriteLine(deepa.EID);
   }
}