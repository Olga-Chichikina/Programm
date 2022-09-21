

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите начальное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число M:");
int numberN = Convert.ToInt32(Console.ReadLine());

///Метод нахождения суммы натуральных элементов в промежутке от M до N
void NumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    NumberSum(numberM, numberN, sum);
}

NumberSum(numberM, numberN, 0);
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkk = Akk(m, n);

Console.Write($"Функция Аккермана = {functionAkk} ");

int Akk(int m, int n)
    {
        if (m == 0) return n + 1;
            else if (n == 0) return Akk(m - 1, 1);
                else return Akk(m - 1, Akk(m, n - 1));
    }

    int InputNumbers(string input) 
    {
        Console.Write(input);
        int output = Convert.ToInt32(Console.ReadLine());
        return output;
    }
    
