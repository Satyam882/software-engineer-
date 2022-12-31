namespace Project;
public class ProjectDetails
{
public int ProjectId {get; set;}
public string ProjectName {get; set;}
public string ProjectType {get; set;}
public DateTime startDate {get; set;}
public DateTime endDate {get; set;}
public double ProjectFund {get; set;}

public ProjectDetails():this(12,"Payroll","Ecommerce", new DateTime(2022, 11,18), new DateTime(2022, 12,24),50000){}

public ProjectDetails(int ProjectId,string ProjectName,string ProjectType,DateTime startDate,DateTime endTime,float ProjectFund){
    this.ProjectId=ProjectId;
    this.ProjectName=ProjectName;
    this.ProjectType=ProjectType;
    this.startDate=startDate;
    this.endDate=endDate;
    this.ProjectFund=ProjectFund;
}
 public override string ToString()
    {
        string str=string.Format("{0} , {1}, {2}, {3}, {4} {5}", ProjectId, ProjectName, ProjectType, startDate,
                                                    endDate, ProjectFund);
        return str;
        //return base.ToString();
    }
}

