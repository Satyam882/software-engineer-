import java.util.Scanner;
public class Amstrong
{
public static void main(String[] args)
{
System.out.println("enter number");
Scanner sc=new Scanner(System.in);
int n=sc.nextInt();
int k=1,y=10,d=1,x,j,a=0,i;
while(k<100)
{
if(n<y)
break;
d++;
y=y*10;
}
y=1;
for(i=0;i<d;i++)
{
x=n%10;
j=0;
while(j<d)
{
y=y*x;
j++;
}
a=a+y;
y=1;
n=n/10;
}
System.out.println(a);
}
}