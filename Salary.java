import java.util.Scanner;
public class Salary
{
public static void main(String[] args)
{
System.out.println("enter annual salary");
Scanner sc=new Scanner(System.in);
int salary=sc.nextInt();
if(salary<150000)
System.out.println("no tax");
else
{
if(salary>=150000 && salary<=300000)
System.out.println("salary="+(salary/5));
else
System.out.println("salary="+(salary*3/10));

}
}
}