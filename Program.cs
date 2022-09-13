// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array = {"Hello", "2", "world", ":-)"};
string[] newArray = Func(array);
PrintArray(newArray);

string[] Func(string[] array) // возвращает массив с элементами, где длина строк меньше или равно 3
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            counter++;
        }
    }

    string[] resultArray = new string[counter];
    counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            resultArray[counter] = array[i];
            counter++;
        }
    }
    return resultArray;
}

void PrintArray(string[] arr) // выводит в консоль переданный массив
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
}