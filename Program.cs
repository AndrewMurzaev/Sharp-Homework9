// Задача 64: Задайте значение N. Напишите программу, которая выведет все
//  натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int Prompt(string txt)
// {
//     Console.WriteLine(txt);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int a = Prompt("Input a number");

// int count = 1;
// Numbers(a, count);


// void Numbers(int a, int count)
// {
//     if (count > a)
//     {
//         return;
//     }
//     else
//     {
//         Numbers(a, count + 1);
//         Console.Write(count + " ");
//     }
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//  натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int Prompt(string txt)
// {
//     Console.WriteLine(txt);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int a = Prompt("Input a");
// int b = Prompt("Input b");
// int sum = 0;
// void Sum(int a, int b)
// {
//     if (a >= b)
//     {
//         System.Console.WriteLine(sum);
//     }
//     else
//     {
//         sum = sum + a;
//         Sum(a + 1, b);
//     }
// }
// Sum(a, b);


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Prompt(string txt)
{
    Console.WriteLine(txt);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Prompt("Input m");
int n = Prompt("Input n");

AkkermanFunction(m,n);



void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

