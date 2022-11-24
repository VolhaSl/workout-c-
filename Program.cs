using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperators

{
    class Program
    {
        static void Main(string[] args)
        {

            
                //Напишите программу, принимаем от пользователя значения двух длин сторон прямоугольника.
                //Пользователь вводит строковую команду площадь или периметр и получает нужный результат.
                //Или вывод «Неверная команда!». Если прямоугольник является квадратом – вывести на экран фразу:
                //«Данный прямоугольник – Квадрат».
               
                {
                    

                   Console.WriteLine("Введите сторону а прямоугольника: ");
                   int sideA = Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("Введите сторону b прямоугольника: ");
                   int sideB = Convert.ToInt32(Console.ReadLine());

               int zapros;
               Console.WriteLine($"Если нужна площадь прямоугольника введите - площадь, если периметр введите - периметр");
               string stringZapros = Console.ReadLine();

               if (stringZapros == "площадь")
               {
                   zapros = sideA * sideB;
                   Console.WriteLine("Площадь = " + zapros);
               }
               else if (stringZapros=="периметр")
               {
                   zapros = 2 * sideA + 2 * sideB;
                   Console.WriteLine("Периметр = " + zapros);
               }
               else
                   Console.WriteLine("Неверная команда!");

               if (sideA==sideB)
               {
                   Console.WriteLine("Данный прямоугольник – Квадрат");
               }

               Console.WriteLine("Сторона А прямоугольника = " + sideA);
               Console.WriteLine("Сторона B прямоугольника = " + sideB);
                  
                 
                }

            

            //Пользователь вводит 4 числа. Найти наибольшее ЧКТНОЕ число. Если такого нет – вывести «Not found».
            //Если есть – вывести его.
           
            {

                Console.WriteLine("Введите число a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число c: ");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число d: ");
                int d = Convert.ToInt32(Console.ReadLine());

                int num1=0, num2=0;
               
                 if (a > b)
                {
                    num1 = a;
                }
                else num1 = b;

                if (c > d)
                {
                    num2 = c;
                }
                else num2 = d;

                if (num1 > num2)
                {
                    Console.WriteLine($"Число {num1} наибольшее.");
                }
                else if (num1 < num2)
                {
                    Console.WriteLine($"Число {num2} наибольшее.");
                }
                else if (a == b && b == c && c == d)
                {
                    Console.WriteLine("Not found");
                } 

                
            }
            
            //  Напишите программу – консольный калькулятор. Создайте две вещественные переменные и запросите от пользователя
            // значения этих переменных. Предложите пользователю ввести знак арифметической операции. Используя конструкцию switch-case,
            // в зависимости от введенного символа выполните арифметическую операцию сложения, вычитания, умножения или деления
            // между вещественными переменными. Выведите результат на экран. 
            //В случае деления – выполните дополнительную проверку делителя, чтобы не выполнить деление на ноль и
            //отмените выполнение математической операции. Если пользователь ввел неподходящий символ – выведите на
            //экран “Неподходящий символ». 

            {
               
                Console.WriteLine("Введите значиние первого числа: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значиние второго числа: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите знак арифметической операции (+ или - или * или /): ");
                string operation = Console.ReadLine();

                int sum=0;

                switch (operation)
                {
                    case "+":
                        {
                            sum = a + b;
                            break;
                        }
                    case "-":
                        {
                            sum = a - b;                            
                            break;
                        }
                    case "*":
                        {
                            sum = a * b;
                            break;
                        }
                    case "/":
                        {
                            if (b == 0)
                            { Console.WriteLine("На 0 делить нельзя!");
                              
                            } 
                             else 
                            {
                                sum = a / b;
                            }
                      
                            break;
                        }

                    default:
                        {
                            Console.WriteLine($"Вы ввели не существующий код: ");
                            break;
                        }
                        
                }
              
                Console.WriteLine(sum);

            }

            Console.ReadKey();
        } 

    }
}
