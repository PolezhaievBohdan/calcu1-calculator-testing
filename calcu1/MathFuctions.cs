using System;

namespace calcu1
{
    /// <summary>
    /// Надає набір статичних методів для виконання базових математичних та тригонометричних операцій.
    /// </summary>
    public class MathFunctions
    {
        /// <summary>
        /// Виконує додавання двох чисел.
        /// </summary>
        /// <param name="a">Перший доданок.</param>
        /// <param name="b">Другий доданок.</param>
        /// <returns>Сума чисел a та b.</returns>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Виконує віднімання другого числа від першого.
        /// </summary>
        /// <param name="a">Зменшуване.</param>
        /// <param name="b">Від'ємник.</param>
        /// <returns>Різниця чисел a та b.</returns>
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Виконує множення двох чисел.
        /// </summary>
        /// <param name="a">Перший множник.</param>
        /// <param name="b">Другий множник.</param>
        /// <returns>Добуток чисел a та b.</returns>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Виконує ділення першого числа на друге.
        /// </summary>
        /// <param name="a">Ділене.</param>
        /// <param name="b">Дільник.</param>
        /// <returns>Частка від ділення a на b.</returns>
        /// <exception cref="DivideByZeroException">Викидається, якщо дільник (b) дорівнює нулю.</exception>
        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Ділення на нуль неможливе.");

            return a / b;
        }

        /// <summary>
        /// Обчислює обернене значення до заданого числа (1/x).
        /// </summary>
        /// <param name="a">Число, для якого обчислюється обернене значення.</param>
        /// <returns>Обернене значення (1/a).</returns>
        /// <exception cref="DivideByZeroException">Викидається, якщо вхідне число дорівнює нулю.</exception>
        public static double Inverse(double a)
        {
            if (a == 0)
                throw new DivideByZeroException("Неможливо знайти обернене значення для нуля.");

            return 1 / a;
        }

        /// <summary>
        /// Обчислює синус кута.
        /// </summary>
        /// <param name="a">Кут у радіанах.</param>
        /// <returns>Синус кута a.</returns>
        public static double Sin(double a)
        {
            return Math.Sin(a);
        }

        /// <summary>
        /// Обчислює косинус кута.
        /// </summary>
        /// <param name="a">Кут у радіанах.</param>
        /// <returns>Косинус кута a.</returns>
        public static double Cos(double a)
        {
            return Math.Cos(a);
        }

        /// <summary>
        /// Обчислює тангенс кута.
        /// </summary>
        /// <param name="a">Кут у радіанах.</param>
        /// <returns>Тангенс кута a.</returns>
        public static double Tan(double a)
        {
            return Math.Tan(a);
        }

        /// <summary>
        /// Обчислює котангенс кута.
        /// </summary>
        /// <param name="a">Кут у радіанах.</param>
        /// <returns>Котангенс кута a.</returns>
        public static double Ctn(double a)
        {
            return 1 / Math.Tan(a);
        }
    }
}