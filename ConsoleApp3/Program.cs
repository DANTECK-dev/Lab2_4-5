
using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task4();
            Task5();
            Console.ReadKey();
        }
        static void Task4()
        {
            char res;
            int counter;
            string arr = "aaabbbaaaabdsffaaa";
            Console.WriteLine(arr);
            FooTask4(arr, out res, out counter);
            Console.WriteLine("символ " + res + " количество " + counter);
        }
        static void FooTask4(in string str, out char res, out int max_count)
        {
            max_count = 0;
            res = '0';
            int counter = 0;
            foreach (char c in str)
            {
                char temp = '2';
                if (c != res)
                {
                    res = c;
                    max_count = 0;
                }
                else
                    counter++;
                if(counter > max_count)
                {
                    res = c;
                    counter = 0;
                    max_count = counter;
                }
            }
        }
        static void Task5()
        {
            /*Вам необходимо найти в массиве два числовых элемента, которые в сумме дадут другое
            введенное число. Достаточно найти первые подходящие два элемента. Напишите для решения этой
            задачи локальную функцию. Используйте для этого наиболее оптимальный метод:
            Функция принимает одномерный массив целых чисел (mas) и число (sum), которое должно
            быть суммой двух элементов в массиве. Отсортируйте его по возрастанию.
            Для начала создадим две переменные (к примеру, i и j), которые будут содержать индексы
            найденных элементов массива. Поначалу в первую (i) запишем индекс первого элемента, а во
            вторую (j) – индекс последнего.
            Теперь в цикле мы будем перебирать элементы следующим образом:
            1. Сперва сложим числа под индексами (mas[i] + mas[j]). Если они дают нужную сумму sum,
            то результат найден, завершаем цикл. Если нет, то продолжаем.
            2. Если получившаяся сумма больше, чем искомая сумма sum, то уменьшаем второй индекс
            на 1 (j--). То есть мы уменьшаем сумму, т.к. так как переходим с наибольшего числа на
            число поменьше (напомню, что массив отсортирован по возрастанию).
            3. Иначе если же получившаяся сумма меньше, чем искомая сумма sum, то увеличиваем
            первый индекс на 1 (i++). То есть мы увеличиваем сумму, т.к. так как переходим с
            наименьшего числа на число побольше.
            Цикл также должен завершаться в ситуации, когда индексы двух чисел совпадут. Это значит,
            что решения нет (нет в массиве двух чисел, которые дадут введенную сумму).*/
            Random rnd = new Random();
            int[] arr = new int[50];
            for(int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(-100, 100);
            printArr<int>(arr);
            Array.Sort(arr);
            printArr<int>(arr);
            int num = Convert.ToInt32(Console.ReadLine());
            searcher(arr, num);
        }
        static void searcher(int[] arr, int num)
        {
            int left = 0;
            int right = arr.Length - 1;
            for (int i = 0; i < arr.Length; i++)
            {
                int sum = arr[left] + arr[right];
                if (sum > num)
                {
                    right--;
                }
                else if (sum < num)
                {
                    left++;
                }
                else if (sum == num)
                {
                    Console.WriteLine("Найдены 2 числа которые в сумме дают введеное число, это "
                        + arr[left] + " и " + arr[right] + ", под индекcами " + left + " и " + right + " соответственно");
                    return;
                }
            }
            Console.WriteLine("Ошибка нет 2 таких чисел которые в сумме дают введеное число");
            return;
        }
        static void printArr<T>(T[] arr)
        {
            Console.Write("Array [ ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("]");
        }
    }
}


