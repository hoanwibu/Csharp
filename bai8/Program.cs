int a, b, c, Cv, Dt;
Console.WriteLine("nhap a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("nhap b: ");
b =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("nhap c: ");
c = Convert.ToInt32(Console.ReadLine());

if(a+b == c || a+c==b||b+c==a){
    Console.WriteLine("tam giac khog ton tai");
}
else if(a+b <c||a+c<b||+b+c<a){
        Console.WriteLine("tam giac khog ton tai");
}else{
    Console.WriteLine("day la tam giac");
}
Console.WriteLine("chu vi tam giac = ");
Cv = a + b + c;
Console.WriteLine(Cv);
Console.WriteLine("chieu dai canh huyen la: ");
int p;
p = (a + b + c) / 2;
Console.WriteLine(p);
Console.WriteLine("Dien tich tam giac = ");
Dt = (int)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
Console.WriteLine(Dt);

z