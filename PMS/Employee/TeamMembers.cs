namespace Employee;
public  class TeamMembers:Emp
{
    
    public float Bonus{get;set;}
    public TeamMembers():base(){
        Bonus=0;

    }

    public TeamMembers(int id, string firstName, string lastName, 
                    string email, string contactNumber, string location,
                    DateTime joinDate, float da, float hra, float bsal,
                    float target, float ProjectDone,float bonus)
                    :base(id, firstName, lastName, 
                    email, contactNumber, location,
                    joinDate, da, hra, bsal
                    ){
        this.Bonus=bonus;
    }


    public override float ComputePay()
    {
        return base.ComputePay()+ Bonus;
    }

    public override void DoWork()
     
      {
       this.Bonus=1000;

      }

    

    public override string ToString()
    {
        return base.ToString() + " Bonus="+ Bonus;
    }
  
}
