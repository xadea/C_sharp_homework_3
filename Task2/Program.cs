//программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве

Console.Clear();

void State(double[] arg)
{
    for (int ind=0; ind < arg.Length; ind++)
    {
        Console.WriteLine("Inpun the coordinate " + (ind+1));
        double num1 = Convert.ToInt32(Console.ReadLine());
        arg[ind] = num1;
    } 
    Console.Clear();
}

Console.WriteLine("First point coordinates: ");
double[] array1 = new double[3];
State(array1);

Console.WriteLine("Second point coordinates: ");
double[] array2 = new double[3];
State(array2);


void Display(double[] arg2)
{
    for (int ind=0; ind < arg2.Length-1; ind++)
    {
        Console.Write(arg2[ind] + ", ");
    } 
    Console.WriteLine(arg2[2]);
    Console.WriteLine();
}


Console.Write("First point coordinates: ");
Display(array1);

Console.Write("Second point coordinates: ");
Display(array2);

double var = 0;
for (int ind = 0; ind < 3; ind++)
{
   var = var + Math.Pow((array1[ind] - array2[ind]), 2);
}
Console.WriteLine("Line length is: " + Math.Sqrt(var));
Console.WriteLine();