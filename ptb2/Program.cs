// See https://aka.ms/new-console-template for more information
int a,b,c,d;
float x1,x2;
Console.WriteLine("nhap a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("nhap b: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("nhap c: ");
c = Convert.ToInt32(Console.ReadLine());
if (a==0&&b==0&&c==0)
{
    Console.WriteLine("pt co vo so nghiem");
} else if (a==0 && b==0 && c==0)
{
    Console.WriteLine("Pt vo so nghiem");
}  else if(a==0 && b == 0 && c!=0){
    Console.WriteLine("pt vo nghiem");
}   else if(a==0&&b!=0){
    Console.WriteLine("pt co nghiem duy nhat");
    Console.WriteLine(-c+"/"+b);
}
   else if(a!=0){
    d=b*b-4*a*c;
    if (d>0)
    {
        x1=(float)(-b+Math.Sqrt(d))/(2*a);
        x2=(float)(-b-Math.Sqrt(d))/(2*a);
        Console.WriteLine("pt co 2 nghiem phan biet");
        Console.WriteLine("x1= "+Math.Round(x1,2));
        Console.WriteLine("x2 ="+Math.Round(x2,2));
    }
    else if(d<0){
        Console.WriteLine("Pt vo nghiem");
    } else{
        Console.WriteLine("pt co nghiem duy nhat");
    }
}