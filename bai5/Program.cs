// See https://aka.ms/new-console-template for more information
int a, b, x;
Console.WriteLine("Nhap a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap b: ");
b = Convert.ToInt32(Console.ReadLine());

if(a==0){
    Console.WriteLine("Phuong trinh vo nghiem");
}
else if(a>0){
    Console.WriteLine("Phuong trinh co nghiem ");
    Console.WriteLine("x = " + - b / a);
} else {
    Console.WriteLine("Phuong trinh co vo so nghiem");
}