using Tyuiu.MoskalevSO.Sprint3.Task4.V7.Lib;

DataService ds = new DataService();

int startValue = -5;
int stopValue = 5;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("x от " + startValue + " до " + stopValue);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Произведение значений функции: " + ds.Calculate(startValue, stopValue));
Console.WriteLine("***************************************************************************");
Console.ReadKey();