Console.Clear();
Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
int min, max;
if(firstNum < secondNum) {
    min = firstNum;
    max = secondNum;
} else {
    max = firstNum;
    min = secondNum;
}
Console.WriteLine(max + " больше, чем " + min);