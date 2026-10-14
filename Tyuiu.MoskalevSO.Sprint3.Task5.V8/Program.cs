using Tyuiu.MoskalevSO.Sprint3.Task5.V8.Lib;

DataService ds = new DataService();

int startValue1 = 1;
int startValue2 = 1;
int stopValue1 = 3;
int stopValue2 = 12;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("i от " + startValue1 + " до " + stopValue1);
Console.WriteLine("k от " + startValue2 + " до " + stopValue2);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("y = " + ds.GetSumSumSeries(startValue1, startValue2, stopValue1, stopValue2));
Console.WriteLine("***************************************************************************");
Console.ReadKey();