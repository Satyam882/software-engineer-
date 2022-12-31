namespace Employee;
public  abstract class Emp{
    

    public int Id{get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string Email{get;set;}
     public string ContactNumber{get;set;}
    public string Location{get;set;}
    public DateTime joinDate{get;set;}
    public float DA{get; set;}

    public float HRA{get; set;}
    
    public float BasicSalary{get; set;}
    

   
    //Constructor Chaining
    public Emp():this(13,"Ashwini", "Palve", "ashwini24palve@gmail.com", "9921188037",
                           "Pune", new DateTime(2022, 9,18),1000,10000,15000){
        
    }

    public Emp(int id, string firstName, string lastName, 
                    string email, string contactNumber, string location,
                    DateTime joinDate, float da, float hra, float bsal
                    ){
        this.Id=id;
        this.FirstName=firstName;
        this.LastName=lastName;
        this.Email=email;
        this.Location=location;
        this.ContactNumber=contactNumber;
        this.joinDate=joinDate;
        this.BasicSalary=bsal;
        this.HRA=hra;
        this.DA=da;
    }
   
   public abstract void DoWork();

   public virtual float ComputePay(){ 
    float  pay=(DA * 25) + BasicSalary + HRA;
    return pay;
   }

    public override string ToString()
    {
        string str=string.Format("{0} , {1}, {2}, {3}, {4} ,{5},{6}", Id, FirstName, LastName, Email,
                                                    ContactNumber, Location,joinDate);
        return str;
        //return base.ToString();
    }

}

