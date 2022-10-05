/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

Console.Write("Enter a size of a array: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array1 = new string[size];

Console.Write("Enter the elements of the array: ");

for (int i = 0; i < array1.Length; i++)
{
    array1[i] = Console.ReadLine();
    
}

string[] array2 = new string[array1.Length];

int count = 0;

void EdithedArray(string[] array1, string[] array2)
{
    Console.Write("The array: ");
      
    for (int j = 0; j < array1.Length; j++)
    {
        Console.Write($"{array1[j]} ");

        if (array1[j].Length < 3)
        {
            array2[count] = array1[j];
            count++;
        }   
    }
    Console.WriteLine();
}

void PrintArray(string[] array)
{
    Console.Write("The derivative array: ");
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
EdithedArray(array1, array2);
PrintArray(array2);
