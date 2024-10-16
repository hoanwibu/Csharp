int g;
Console.WriteLine("chon: ");
Console.WriteLine("1. for");
Console.WriteLine("2. while");
Console.WriteLine("3. do..while");
g = Convert.ToInt32(Console.ReadLine());

switch(g){
//for
case 1: {
    int T = 0, n;
    Console.WriteLine("nhap n");
    n = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i <= n; i++) {
        T += i;
    }
    Console.WriteLine(T); break;
}
    


case 2: {
    int T = 0, n, i=1;
    Console.WriteLine("nhap n");
    n = Convert.ToInt32(Console.ReadLine());
    while (i <= n) {
        T += i;
        i++;
    }
    Console.WriteLine(T); break;
}
    

//do   while
case 3: {
    int T = 0, n, i=1;
    Console.WriteLine("nhap n");
    n = Convert.ToInt32(Console.ReadLine());
    do
    {
        T += i;
            i++;
    } while (i <= n);
    Console.WriteLine(T);break;
}
    
default: Console.WriteLine("khong co trong menu"); break; }