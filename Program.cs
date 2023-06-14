Console.Write("Введите число =>");
string inputedString = Console.ReadLine();  
int number = Convert.ToInt32(inputedString);
int num = number-(number-1);

while (num <number+1)
{
   int c = (num%2);
    if ( c == 0)
    {
      Console.WriteLine(num);
      num=num+1;  
    }
    else
    num=num+1;
}