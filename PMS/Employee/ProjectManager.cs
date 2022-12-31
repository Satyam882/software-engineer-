namespace Employee;
public class ProjectManager:Emp

{
 public float Target{get;set;}
    public float ProjectDone{get;set;}
    public float Incentive{get;set;}
    public ProjectManager():base(){
        this.Target=10;
        this.ProjectDone=0;
        this.Incentive=0;
    }

    //MemerInitiaized List
    public  ProjectManager(int id, string firstName, string lastName, 
                    string email, string contactNumber, string location,
                    DateTime joinDate, float da, float hra, float bsal,
                    float target, float ProjectDone):base(id,firstName, lastName, email, contactNumber,
                                                       location,joinDate,da,hra,bsal ){

        this.Target=target;
        this.ProjectDone=ProjectDone;
        this.Incentive=0;

    }
    public override void DoWork()
    {
        if( ProjectDone>=Target){
            this.Incentive=5000;
        }
        else{
            this.Incentive=0;
        }
    }

    public override float ComputePay()
    {
        float  salary=base.ComputePay() + Incentive;
        return salary;
    }

    public override string ToString()
    {
        return base.ToString()  + "Incentive =" +Incentive + ", Tartget="+ Target;
    }
    
}

