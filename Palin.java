import java.util.Scanner;
public class Palin
{
public static void main(String[] args)
{
int m=10,k,p=1;
System.out.println("enter any number");
Scanner sc=new Scanner(System.in);
int n=sc.nextInt();
int y=10,i=1,status=0,j;
while(m<100)
{
if(n<y)
break;
i++;
y=y*10;
}
if(i==1)
System.out.println("your number is palindrome");
for(j=(i/2);j>0;j--)
{
k=1;
while(p<i)
{
k=k*10;
p++;
}
if((n/k)!=(n%10))
{
status=1;
break;
}
n=n/10;
i--;
}
if(status==0)
System.out.println("your number is palindrome");
else
System.out.println("your number is not palindrome");
}

}