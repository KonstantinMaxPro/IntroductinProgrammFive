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

int CountingNumberOfEvenNumbers(int[] arrayWithThreeDigitNumbers)//Находим и подсчитываем количество чётных чисел
{
    int countEvenNumbers = 0;
    for (int countIterationInArray = 0; countIterationInArray < arrayWithThreeDigitNumbers.Length; countIterationInArray++)
    {
        if(arrayWithThreeDigitNumbers[countIterationInArray] % 2 == 0)
        {
            countEvenNumbers +=1;
        }
    }        
    return countEvenNumbers;
}

int sizeOfCreatedArray = 4;
int minValueRandomNumberInGeneratedArray = 100;
int maxValueRandomNumberInGeneratedArray = 1000;

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
int[] ArrayOfThreeDigitNumbers = CreateArrayWithRandomValues(sizeOfCreatedArray, minValueRandomNumberInGeneratedArray, maxValueRandomNumberInGeneratedArray);

Console.WriteLine($"\nСоздан массив из {sizeOfCreatedArray} случайных чисел:");
Console.WriteLine(string.Join(" ",ArrayOfThreeDigitNumbers));
Console.WriteLine("=======================================");
Console.Write("Найдено чётных чисел в массиве: ");
Console.ForegroundColor = ConsoleColor.Yellow; 
Console.WriteLine(CountingNumberOfEvenNumbers(ArrayOfThreeDigitNumbers)); 
Console.ResetColor();
Console.WriteLine("=======================================\n");