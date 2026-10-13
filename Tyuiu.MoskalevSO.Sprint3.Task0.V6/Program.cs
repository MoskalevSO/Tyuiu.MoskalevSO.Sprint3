using Tyuiu.MoskalevSO.Sprint3.Task0.V6.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("p = произведение (k = 1..15) от 1 / (cos(5) + 1)^2");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");

int startValue = 1;
int stopValue = 15;
double res = ds.GetMultiplySeries(startValue, stopValue);

Console.WriteLine("p = " + res);
Console.ReadKey();