//Входной файл INPUT.TXT содержит чётное число N (4 ≤ N ≤ 998).
//В выходной файл OUTPUT.TXT необходимо вывести два простых числа, сумма которых равна числу N. 
//Первым выводится наименьшее число.

Console.Clear();
Console.WriteLine("введите четное число");
int a=2;
int b=2;
int n = int.Parse(Console.ReadLine());
if (n%2!=0 || n<=4 || n>998)
Console.Write("введите четное число");
else
{
      a = new Random().Next(2,n);
while (a<=n/2 && a%1==0 && a%a==0)
{
   a = new Random().Next(2,n);
   b=n-a;
}
}
    
    
    
Console.WriteLine(a);
Console.WriteLine(b);

