using Tyuiu.MoskalevSO.Sprint3.Task1.V17.Lib;

DataService ds = new DataService();

int x = 1;
int startValue = 1;
int stopValue = 4;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("x = " + x);
Console.WriteLine("k от " + startValue + " до " + stopValue);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("p = " + ds.GetMultiplySeries(x, startValue, stopValue));
Console.WriteLine("***************************************************************************");
Console.ReadKey();