using Tyuiu.MoskalevSO.Sprint3.Task2.V12.Lib;

DataService ds = new DataService();

int x = 5;
int startValue = 1;
int stopValue = 5;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("x = " + x);
Console.WriteLine("i от " + startValue + " до " + stopValue);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("p = " + ds.GetMultiplySeries(x, startValue, stopValue));
Console.WriteLine("***************************************************************************");
Console.ReadKey();