double a ;
double sum =0;
double fuct = 1;
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("Enter a: " );
a = Convert.ToDouble(Console.ReadLine());
for (int i = 1; i <= a; i++)
{
     fuct = fuct * i;
     sum += 1/fuct;
    Console.WriteLine(fuct);
  

}
Console.WriteLine(sum +1 );