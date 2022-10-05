//---------Используемые методы------------
double[] FillArrayTask1() //Метод создания и наполнения массива для задачи 1
{

    Random rnd = new Random();
    int Insert = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[Insert];

    // for (int i = 0; i < array.Length; i++) ----- Вводим рандомные случайные значения
    // {
    //     array[i] = rnd.Next(-100, 101);
    // }
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число №{i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

void PrintArray(double[] argument1) //Метод печати массива
{
    Console.WriteLine("[" + String.Join("; ", argument1) + "]");
    // Console.Write("[ "); ---- Альтернатива длинная
    // for (int i = 0; i < array.Length; i++)
    //     if (i < array.Length - 1)
    //         Console.Write(array[i] + "; ");
    //     else
    //         Console.Write(array[i] + " ");
    // Console.Write("]");
}

//------------Задачи---------------

void task1()
{
    // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    // 0, 7, 8, -2, -2 -> 2
    // 1, -7, 567, 89, 223-> 3
    Console.Clear();
    Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
    Console.Write("Введите размер массива чисел M: ");
    double[] array = FillArrayTask1();
    PrintArray(array);
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine("Чисел больше 0: " + count);
    Console.ReadKey();
}

void task2()
{
    // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    Console.Clear();
    Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");

    Console.Write("Введите b1: ");
    double b1 = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите k1: ");
    double k1 = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите b2: ");
    double b2 = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите k2: ");
    double k2 = double.Parse(Console.ReadLine() ?? "0");

    double x = (b2 - b1) / (k1 - k2);
    Console.WriteLine("x = " + x);
    double y = k1 * x + b1;
    Console.WriteLine("y = " + y);
    Console.WriteLine($"Точка пересечения с координатами: ({x}; {y})");

    Console.ReadKey();
}


//------------Выполнение программы---------------
void Main()
{
    Console.Clear();
    Console.WriteLine("**************************************** \n Выберите задачу, которую хотите решить:\n\t1 - Задача 41 \n\t2 - Задача 43 \n\t3 - Выход");
    int num = Convert.ToInt32(Console.ReadLine());
    switch (num)
    {
        case 1:
            task1();
            Main();
            break;
        case 2:
            task2();
            Main();
            break;
        case 3:
            Console.WriteLine("Пока!");
            Console.ReadKey();
            break;
    }
}
Main();