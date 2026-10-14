using System;

namespace GeometryRectangleProject
{
    // Оголошення класу Rectangle (Прямокутник)
    class Rectangle
    {
        // Поля класу для збереження ширини та висоти
        public double Width;
        public double Height;

        // Метод для обчислення площі прямокутника (S = w * h)
        public double GetArea()
        {
            return Width * Height;
        }

        // Метод для обчислення периметра прямокутника (P = 2 * (w + h))
        public double GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        // Домашнє завдання: логічний метод, який визначає, чи є прямокутник квадратом
        public bool IsSquare()
        {
            return Width == Height;
        }

        // Метод для виведення повної інформації про об'єкт
        public void DisplayInfo(int index)
        {
            Console.WriteLine("Прямокутник №" + index + ":");
            Console.WriteLine("  Ширина: " + Width);
            Console.WriteLine("  Висота: " + Height);
            Console.WriteLine("  Площа: " + GetArea());
            Console.WriteLine("  Периметр: " + GetPerimeter());
            
            if (IsSquare())
                Console.WriteLine("  Результат перевірки: Цей прямокутник є КВАДРАТОМ.");
            else
                Console.WriteLine("  Результат перевірки: Цей прямокутник НЕ є квадратом.");
            
            Console.WriteLine("---------------------------------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================================");
            Console.WriteLine("    ПРАКТИЧНЕ ЗАНЯТТЯ №4: СТВОРЕННЯ КЛАСУ 'ПРЯМОКУТНИК'  ");
            Console.WriteLine("=========================================================");
            Console.WriteLine();

            // Загальне завдання: створення масиву із двох прямокутників
            Rectangle[] rects = new Rectangle[2];

            // Ініціалізація першого прямокутника (звичайна фігура)
            rects[0] = new Rectangle();
            rects[0].Width = 5.0;
            rects[0].Height = 8.0;

            // Ініціалізація другого прямокутника (квадрат для тестування домашнього завдання)
            rects[1] = new Rectangle();
            rects[1].Width = 6.5;
            rects[1].Height = 6.5;

            // Виведення параметрів кожного прямокутника з масиву
            Console.WriteLine("--- Виведення параметрів елементів масиву ---");
            for (int i = 0; i < rects.Length; i++)
            {
                rects[i].DisplayInfo(i + 1);
            }

            Console.WriteLine("✅ Програму успішно виконано!");
        }
    }
}
