int[] CreateArrayWithRandomValues(int sizeArray, int minRandomValue, int maxRandomValue)//Генерируем массив заданного размера с случайными числами заданного диапозона
{
    int[] arrayWithRandomValues = new int[sizeArray];
    Random rnd = new Random();
    for (int arrayIterationCounter = 0; arrayIterationCounter < sizeArray; arrayIterationCounter++)
    {    
        arrayWithRandomValues[arrayIterationCounter] = rnd.Next(minRandomValue, maxRandomValue);        
    }
    return arrayWithRandomValues;
}

int SummingValuesFromOddIndexesArray(int[] arrayWithRandomNumbers)//Находим и суммируеум числа в нечетных индексах массива
{
    int SumValuesOddIndexesArray = 0;
    for (int countIterationInArray = 1; countIterationInArray < arrayWithRandomNumbers.Length; countIterationInArray += 2)
    {
        SumValuesOddIndexesArray += arrayWithRandomNumbers[countIterationInArray];
    }        
    return SumValuesOddIndexesArray;
}

int sizeOfCreatedArray = 0;
int minValueRandomNumberInGeneratedArray = -100;
int maxValueRandomNumberInGeneratedArray = 100;

Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine("===============================================");
Console.WriteLine("|    СУММА ЧИСЕЛ НЕЧЁТНЫХ ИНДЕКСОВ МАССИВА    |");//Название
Console.WriteLine("===============================================\n");
/*КОНЕЦ ЗАГОЛОВКА*/

Console.Write("Введите размер будущего массива: ");
while (!int.TryParse(Console.ReadLine(), out sizeOfCreatedArray))
{
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.ResetColor();
    Console.Write("Введите размер будущего массива: ");
}
int[] ArrayOfRandomNumbers = CreateArrayWithRandomValues(sizeOfCreatedArray, minValueRandomNumberInGeneratedArray, maxValueRandomNumberInGeneratedArray);

Console.WriteLine($"\nСоздан массив из {sizeOfCreatedArray} случайных чисел:");
for (int countIteration = 0; countIteration < ArrayOfRandomNumbers.Length; countIteration++)
{
    Console.Write(ArrayOfRandomNumbers[countIteration] + " ");
    if(countIteration > 0 && countIteration % 12 == 0) Console.WriteLine();
}
Console.WriteLine("\n===============================================");
Console.Write("Сумма чисел из нечётных индексов массива: ");
Console.ForegroundColor = ConsoleColor.Yellow; 
Console.WriteLine(SummingValuesFromOddIndexesArray(ArrayOfRandomNumbers)); 
Console.ResetColor();
Console.WriteLine("===============================================\n");
