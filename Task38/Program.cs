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

int DifferenceBetweenMaxAndMinValue(int[] arrayWithRandomNumbers)//Находим и подсчитываем количество чётных чисел
{
    int minValueInArray = arrayWithRandomNumbers[0];
    int maxValueInArray = arrayWithRandomNumbers[0];
    for (int counter = 0; counter < arrayWithRandomNumbers.Length; counter++)
    {
        
        if(minValueInArray > arrayWithRandomNumbers[counter])
        {
            minValueInArray = arrayWithRandomNumbers[counter];
        }
        if(maxValueInArray < arrayWithRandomNumbers[counter])
        {
            maxValueInArray = arrayWithRandomNumbers[counter];
        }
    }
    return maxValueInArray - minValueInArray;
}

int sizeOfCreatedArray = 4;
int minValueRandomNumberInGeneratedArray = 1;
int maxValueRandomNumberInGeneratedArray = 100;

Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine("=======================================");
Console.WriteLine("|   ПОДСЧЕТ ЧЕТНЫХ ЧИСЕЛ В МАССИВЕ    |");//Название
Console.WriteLine("=======================================\n");
/*КОНЕЦ ЗАГОЛОВКА*/

Console.Write("Введите размер будущего массива: ");
while (!int.TryParse(Console.ReadLine(), out sizeOfCreatedArray))
{
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.ResetColor();
    Console.Write("Введите размер будущего массива: ");
}
int[] arrayWithRandomNumbers = CreateArrayWithRandomValues(sizeOfCreatedArray, minValueRandomNumberInGeneratedArray, maxValueRandomNumberInGeneratedArray);

Console.WriteLine($"\nСоздан массив из {sizeOfCreatedArray} случайных чисел:");
for (int countIteration = 0; countIteration < arrayWithRandomNumbers.Length; countIteration++)
{
    Console.Write(arrayWithRandomNumbers[countIteration] + " ");
    if(countIteration > 0 && countIteration % 12 == 0) Console.WriteLine();
}
Console.WriteLine("\n=======================================");
Console.Write("Найдено чётных чисел в массиве: ");
Console.ForegroundColor = ConsoleColor.Yellow; 
Console.WriteLine(DifferenceBetweenMaxAndMinValue(arrayWithRandomNumbers)); 
Console.ResetColor();
Console.WriteLine("=======================================\n");