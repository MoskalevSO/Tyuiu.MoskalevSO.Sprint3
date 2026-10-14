using Tyuiu.MoskalevSO.Sprint3.Task3.V18.Lib;

DataService ds = new DataService();

string str = "4n5nvf 56 bgy";
char item = 'n';

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Строка: " + str);
Console.WriteLine("Символ для замены цифр: " + item);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Строка после замены: " + ds.ReplaceNumOnChar(str, item));
Console.WriteLine("***************************************************************************");
Console.ReadKey();