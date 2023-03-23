string [] ShortStringArray (string [] array) // Метод создания нового массива.
{
    string [] shortArray = new string [array.Length]; // Выделение памяти для нового массива аналогичной исходному массиву длины. 
    int j = 0; // Добавление индекса значений строк нового массива.
    for (int i=0; i < array.Length; i++) // При поиске по элементам исходного массива,  
      {
         if (array[i].Length <= 3) // в случае обнаружения элемента, значение которого состоит из <= 3 символов, 
         {
            shortArray[j] = array [i]; // этот элемент будет записываться в новый массив с новым индексом
            j++;
         }
      }
    return shortArray;  
}

string [] CreateArray (int size) // Метод создания исходного массива, значения поэлементно вводятся пользователем.
{
     string [] array = new string [size];
     for (int i = 0; i < size; i++)
     {
        Console.WriteLine($"Input element {i} ");
        array[i] = Console.ReadLine();
     }
       
 return array;
}
void ShowArray (string [] array) // Метод вывода значений элементов обоих массивов в консоль.
{
    for (int i=0; i < array.Length; i++)
            Console.Write (array [i] + " ");
    Console.WriteLine();
}
Console.Write ("Input size: "); // Введение длины массива пользователем.
int size = Convert.ToInt32 (Console.ReadLine());

string [] array = CreateArray (size); // Создание массива с помощью ранее описанного метода.
ShowArray(array); // Выведение исходного массива на консоль.
ShowArray(ShortStringArray(array)); //Получение нового массива ранее описанным методом, выведение нового массива в консоль.

