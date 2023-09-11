// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Console.WriteLine("Введите количечтво элементов массива: ");
int num = int.Parse(Console.ReadLine()!);
string[] stringArray = new string[num];
array(stringArray);
string[] printArray = GetLessThreeSymbol(stringArray);
PrintArrayResult(printArray);


void array(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент массива");
        stringArray[i] = Console.ReadLine()!;
    }
}


string[] GetLessThreeSymbol(string[] stringArray)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        count++;
    }
    string[] resultArray = new string[count];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            resultArray[j] = stringArray[i];
            j++;
        }
    }
    return resultArray;
}


void PrintArrayResult(string[] printArray)
{
    for (int i = 0; i < printArray.Length; i++)
    {
        Console.Write(printArray[i] + ", ");    
    }
}





// Console.Write("Введите количество элементов массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// string [] stringArray = new string [m];
// void array(string [] stringArray)
// {
//   for (int i = 0;i<stringArray.Length;i++)
//   {
//      Console.WriteLine($"Введите {i+1} элемент массива");
//      stringArray[i] = Console.ReadLine();
//   }
// }

// string [] symbol(string [] stringArray)
// {
//   int n = 0;
//   for (int i = 0;i<stringArray.Length;i++)
//   {
//     if(stringArray[i].Length <=3)
//     n++;
//   }
//   string [] rez = new string [n];
//   int j = 0;
//   for (int i = 0;i<stringArray.Length;i++)
//   {
//     if(stringArray[i].Length <=3)
//     {
//         rez[j] = stringArray[i];
//         j++;
//     }
//   }
//   return rez;
// }
// void printA(string [] stringArray)
// {
//     Console.Write("[");
//     for (int i = 0;i<stringArray.Length;i++)
//     {
//     Console.Write($"‘{stringArray[i]}’, ");
//     }
//     Console.Write("]");
// }
// array(stringArray);
// printA(symbol(stringArray));