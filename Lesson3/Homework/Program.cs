using Homework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{


    internal class Program
    {
        static void Main(string[] args)
        {
            // Включение Кириллицы в консоли
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            bool runProgram = true;

            while (runProgram)
            {
                Console.WriteLine("=====================================================");
                Console.WriteLine("1 -> Задача 1");
                Console.WriteLine("2 -> Задача 2");
                Console.WriteLine("0 -> Выход");
                Console.WriteLine("=====================================================");

                int taskNumber;

                // Если пользователь неправильно ввёл номер задачи, то taskNumber будет равным -1, и в блоке switch
                // программа сообщит об этом пользователю
                if (!int.TryParse(CommonMethods.AskInfo("Введите номер задачи: "), out taskNumber))
                {
                    taskNumber = -1;
                }

                switch (taskNumber)
                {
                    default:
                        Console.WriteLine("Некорректый номер задачи. Повторие ввод.");
                        break;

                    case 0:
                        runProgram = false;
                        break;

                    case 1:
                        Task1();
                        break;

                    case 2:
                        Task2();
                        break;
                }
            }

            CommonMethods.Pause("\nНажмите любую клавишу, чтобы выйти...");
        }


        #region Методы для вызова задачь из домашней работы
        static void Task1()
        {
            CommonMethods.PrintTaskInfo(
                3,
                1,
                "а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры." +
                "\n\tб) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса." +
                "\n\tв) Добавить диалог с использованием switch демонстрирующий работу класса.",
                "Грачёв Виктор Алексеевич"
            );

            
            
            string ComplexVariant = ChooseComplexVariant();
            string MathOperation  = ChooseMathOperation();

            Console.WriteLine();

            double re1 = CommonMethods.AskInfoDouble("Введите действительную часть первого числа: ");
            double im1 = CommonMethods.AskInfoDouble("Введите мнимую часть первого числа: ");

            Console.WriteLine();

            double re2 = CommonMethods.AskInfoDouble("Введите действительную часть второго числа: ");
            double im2 = CommonMethods.AskInfoDouble("Введите мнимую часть вторго числа: ");

            Console.WriteLine();

            if (ComplexVariant == "struct")
            {
                Complex complexNum1 = new Complex();
                complexNum1.re = re1;
                complexNum1.im = im1;

                Complex complexNum2 = new Complex();
                complexNum2.re = re2;
                complexNum2.im = im2;

                switch (MathOperation)
                {
                    case "plus":
                        Console.WriteLine($"({complexNum1}) + ({complexNum2}) = ({Complex.Plus(complexNum1, complexNum2)})");
                        break;

                    case "minus":
                        Console.WriteLine($"({complexNum1}) - ({complexNum2}) = ({Complex.Minus(complexNum1, complexNum2)})");
                        break;

                    case "multiply":
                        Console.WriteLine($"({complexNum1}) * ({complexNum2}) = ({Complex.Multiply(complexNum1, complexNum2)})");
                        break;

                    case "divide":
                        Console.WriteLine($"({complexNum1}) / ({complexNum2}) = ({Complex.Divide(complexNum1, complexNum2)})");
                        break;
                }
            }
            else
            {
                ComplexClass complexNum1 = new ComplexClass(re1, im1);
                ComplexClass complexNum2 = new ComplexClass(re2, im2);

                switch (MathOperation)
                {
                    case "plus":
                        Console.WriteLine($"({complexNum1}) + ({complexNum2}) = ({ComplexClass.Plus(complexNum1, complexNum2)})");
                        break;

                    case "minus":
                        Console.WriteLine($"({complexNum1}) - ({complexNum2}) = ({ComplexClass.Minus(complexNum1, complexNum2)})");
                        break;

                    case "multiply":
                        Console.WriteLine($"({complexNum1}) * ({complexNum2}) = ({ComplexClass.Multiply(complexNum1, complexNum2)})");
                        break;

                    case "divide":
                        Console.WriteLine($"({complexNum1}) / ({complexNum2}) = ({ComplexClass.Divide(complexNum1, complexNum2)})");
                        break;
                }
            }

            CommonMethods.Pause("\nНажмите любую клавишу, чтобы продолжить...");
        }

        static void Task2()
        {
            CommonMethods.PrintTaskInfo(
                3,
                1,
                "С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке)." +
                "\n\tТребуется подсчитать сумму всех нечётных положительных чисел." +
                "\n\tСами числа и сумму вывести на экран, используя tryParse.",
                "Грачёв Виктор Алексеевич"
            );


            string oddNumbersOutput = "";
            int oddNumbersSum = 0;

            int inpuntNum;
            while (true)
            {
                inpuntNum = CommonMethods.AskInfoInt("Введите число: ");

                if (inpuntNum == 0)
                {
                    break;
                }
                
                if (inpuntNum > 0 && inpuntNum % 2 == 1)
                {
                    oddNumbersOutput += $"{inpuntNum} ";
                    oddNumbersSum += inpuntNum;
                }
            }

            if (oddNumbersSum == 0)
            {
                Console.WriteLine("Вы не ввели ни одно нечётное положительне число.");
            }
            else
            {
                Console.WriteLine($"Все нечётные положительные числа: {oddNumbersOutput}");
                Console.WriteLine($"Сумма всех нечётных положительных чисел: {oddNumbersSum}");
            }
        }

        #endregion

        #region Вспомогательные методы

        /// <summary>
        /// Позволяет пользователю выбрать структуру или класс для работы с комплесными числами
        /// </summary>
        /// <returns>
        /// struct - пользователь выбрал структуру.
        /// class - пользователь выбрал класс.
        /// </returns>
        static string ChooseComplexVariant()
        {

            while (true)
            {
                Console.WriteLine("1 -> Выбрать структуру для работы с комплексными числами");
                Console.WriteLine("2 -> Выбрать класс для работы с комплексными числами");
                Console.WriteLine("");

                int chooseNumber;

                if (!int.TryParse(CommonMethods.AskInfo("Введите номер: "), out chooseNumber))
                {
                    chooseNumber = -1;
                }

                switch (chooseNumber)
                {
                    default:
                        Console.WriteLine("Некорректый номер. Повторие ввод.");
                        break;

                    case 1:

                        return "struct";

                    case 2:
                        return "class";
                }
            }
        }

        /// <summary>
        /// Позволяет пользователю выбрать математическу операцию
        /// </summary>
        /// <returns>
        /// 1 - пользователь выбрал сложение.
        /// 2 - пользователь выбрал вычитание.
        /// 3 - пользователь выбрал умножение.
        /// 4 - пользователь выбрал деление.
        /// </returns>
        static string ChooseMathOperation()
        {

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1 -> Сложение");
                Console.WriteLine("2 -> Вычитание");
                Console.WriteLine("3 -> Умножение");
                Console.WriteLine("4 -> Деление");
                Console.WriteLine();

                int chooseNumber;

                if (!int.TryParse(CommonMethods.AskInfo("Введите номер: "), out chooseNumber))
                {
                    chooseNumber = -1;
                }

                switch (chooseNumber)
                {
                    default:
                        Console.WriteLine("Некорректый номер. Повторие ввод.");
                        break;

                    case 1:
                        return "plus";

                    case 2:
                        return "minus";

                    case 3:
                        return "multiply";

                    case 4:
                        return "divide";
                }
            }
        }

        #endregion
    }
}
