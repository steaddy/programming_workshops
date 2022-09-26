
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string a;
  if(n % 2 == 0) 
  a = "четное" + n;
 else 
  a = "не четное";

Console.WriteLine("Число " + n + " " + a + ".");