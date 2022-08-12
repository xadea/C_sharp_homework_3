// программa, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N

Console.Clear();

Console.WriteLine("Input number ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Cube of numbers from 1 to " + num1 + " are:   ");

for(int count = 1; count <num1; count++)
{
    double num2 = Math.Pow(count,3);
    Console.Write(num2 + ", ");
}
Console.WriteLine(Math.Pow(num1,3));

Console.WriteLine(); 