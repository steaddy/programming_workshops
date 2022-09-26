Console.Clear();
Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdNum = Convert.ToInt32(Console.ReadLine());
int max;
if(firstNum > secondNum && firstNum > thirdNum) {
    max = firstNum;
} else if(firstNum < secondNum && secondNum > thirdNum) {
    max = secondNum;
} else {
  max = thirdNum;
}
Console.WriteLine(max + " большее число из трех");