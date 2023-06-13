int a = new Random().Next(1, 500);
Console.WriteLine(a);

int b = new Random().Next(1, 500);
Console.WriteLine(b);

int d = new Random().Next(1, 500);
Console.WriteLine(d);

int c = new Random().Next(1, 500);
Console.WriteLine(c);
 
int max = a;

 if (b > max) max = b;
 if (c > max) max = c;
 if (d > max) max = d;

Console.Write("max = ");
Console.WriteLine(max);
