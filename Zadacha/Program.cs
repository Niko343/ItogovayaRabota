//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длинна которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//["hello", "2", "world", ":-)"] -> ["2", ":-)"] 
//["1234", "1567", "-2", "computer science"] -> ["-2"]
//["Russia", "Denmark", "Kazan"] -> []



string[] ArrStart1 = new string[] {"hello", "2", "world", ":-)"}; //Задали первоначальный массив
string[] ArrStart2 = new string[] {"1234", "1567", "-2", "computer science"}; //Задали второй массив
string[] ArrStart3 = new string[] {"Russia", "Denmark", "Kazan"}; //Задали третий массив
string[] ArrFinish = new string [5]; //Задали массив для отсортированной части
void ViborkaStrok (string [] ar1, string [] ar2)  //Создаем метод сортировки массивов
{
    int j = 0; //Дополнительный счетчик
    for (int i = 0; i < ar1.Length; i++) //Начало цикла
        {
            if (ar1[i].Length < 4)  //Условие цикла: длинна строки меньше либо равна 3
            {
                ar2[j] = ar1[i];  //При выпаолнении условия в ячейку конечного массива записывается значение из первоначального массива
                j++;  //При выполнении условия дополнительный счетчик переходит на новую ячейку
            }
        }
}
void PrintArray (string [] array)  //Создаем метод конечной печати массива
    {
        for (int i = 0; i < array.Length; i++)  //Начало цикла
        {
            Console.Write($"{array[i]} "); //Печать элемента
        }
        Console.WriteLine(); //Переход на новую строку
    }

void Reshenie (string [] ar1,string [] ar2)
{
    Console.WriteLine("Начальный массив: "); //Вывод начальных данных
    PrintArray(ar1); //Используя заданный метод
    ViborkaStrok(ar1, ar2); //Используем метод сортировки массивов
    Console.WriteLine("Конечный массив: "); //Вывод конечных данных
    PrintArray(ar2);  //Используя метод вывода
}

Reshenie(ArrStart1, ArrFinish);
ArrFinish = new string [5];
Reshenie(ArrStart2, ArrFinish);
ArrFinish = new string [5];
Reshenie(ArrStart3, ArrFinish);

