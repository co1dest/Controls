/*

Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма
При решении не рекомендуеться пользоваться коллекциями, лучше обойтись исключительно массивами

*/

Console.Write("Введите массив данных через ',': ");
string strLine = Console.ReadLine();
string[] inArr = strLine.Split(",");
string[] outArr = new string[0];

for (int i = 0; i < inArr.Length; i++)
{
if (inArr[i].Length <= 4)
{
Array.Resize(ref outArr, outArr.Length + 1);
outArr[outArr.Length-1] = inArr[i];
}

}
Console.WriteLine($"[{string.Join(",", inArr)}]=>[{string.Join(",", outArr)}]");