using Tyuiu.MoskalevSO.Sprint3.Task6.V14.Lib;

DataService ds = new DataService();

int startValue = 7;
int stopValue = 16;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Отрезок: [" + startValue + "; " + stopValue + "]");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Количество делителей больше 5: " + ds.GetSumTheDivisors(startValue, stopValue));
Console.WriteLine("***************************************************************************");
Console.ReadKey();