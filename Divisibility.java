import java.util.Scanner;
public class Divisibility
{
 public static void main(String[] args)
{
 System.out.println("enter number to check divisibility");
Scanner sc=new Scanner(System.in);
int a=sc.nextInt();
if((a%5)==0 &&(a%7)==0)
System.out.println("Divisibility by 5 and 7");
else
 System.out.println("not Divisibility");
}

}
