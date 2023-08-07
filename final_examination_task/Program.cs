/* Задача: Написать программу, которая из имеющегося массива 
строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”]  */

//Метод по выводу массива
void printArray(string[] arrayToPrint)
{
    Console.Write("[ ");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(",  ");
        }
    }
    Console.WriteLine("] ");
}

/*  Дальше мы задаем массив строк и переменную size, равную 0, с помощью цикла for мы проходимся по массиву 
и если наше условие выполняется, то прибавляем к size +1, 
после выхода из цикла мы знаем размер нашего нового массива
в который мы будем записывать наши значения */
string[] strArray = { "Hello","3","com", "Bye", ":)", "Moscow", "GN" };
int size = 0;
for (int i = 0; i < strArray.Length; i++)
    {  
        if (strArray[i].Length <= 3)
        {
            size += 1;
        }
    }

/* Далее пишем метод по созданию нового массива, на вход принимаем изначальный массив строк.
Создаем новый массив строк, с уже известным нам размером. Циклом for проходимся по первоначальному
массиву и в случае выполнения условия, записываем данную информацию в новый массив.
Возвращаем готовый массив */
string[] CreateNewArray(string[] array )
{   
    string[] doneArray = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    
        if (array[i].Length <= 3)
        {
         doneArray[j] = array[i];
         j+=1;

        }
    return doneArray;
}
//Создаем новый массив с помощью метода CreateNewArray(strArray) и выводим с помощью  printArray
string[] newDoneArray = CreateNewArray(strArray);
printArray(newDoneArray);