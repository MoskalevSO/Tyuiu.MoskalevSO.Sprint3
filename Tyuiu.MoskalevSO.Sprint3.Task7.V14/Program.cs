using Tyuiu.MoskalevSO.Sprint3.Task7.V14.Lib;

DataService ds = new DataService();

int startValue = -5;
int stopValue = 5;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Диапазон: [" + startValue + "; " + stopValue + "], шаг 1");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");

double[] valueArray = ds.GetMassFunction(startValue, stopValue);
int x = startValue;
foreach (double y in valueArray)
{
    Console.WriteLine("F(" + x + ") = " + y);
    x++;
}

Console.WriteLine("***************************************************************************");
Console.ReadKey();