// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int GetStepen (int A, int B)
{
    int res =1;
    for (int el =1; el<=B; el++)
    {
        res=res*A;
    }
    return res;
}

Console.Write("Просьба введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Просьба введите степень: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = GetStepen(num1,num2);
Console.WriteLine(result);
*/
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int GetSum (int num)
{
    int sum =0;
    for (int el=0; num>0; el++)
    {
        sum=sum+num%10;
        num=(num-num%10)/10;
    }
    return sum;
}

Console.Write("Просьба введите число: ");
int number=Convert.ToInt32(Console.ReadLine());

int result = GetSum(number);
Console.WriteLine(result);
*/
// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[ ] CreateArray (int size)
{
    int [ ] array= new int[size];
    for (int i=0; i<size; i++)
    {
        Console.Write($"Просьба ввести элемент номер {i} - ");
        int elements=Convert.ToInt32(Console.ReadLine());
        array[i]=elements;
    }
    return array;
}

void ShowArray ( int [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Укажите размер массива: ");
int m =Convert.ToInt32(Console.ReadLine());

int [] newArray = CreateArray(m);
ShowArray(newArray);

