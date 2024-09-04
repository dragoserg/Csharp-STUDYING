using System;

class Program
{
    static void Main()
    {
        // Параметры модели
        double beta = 0.3; // Коэффициент передачи вируса
        double sigma = 0.1; // Коэффициент перехода из латентного состояния в заболевание
        double gamma = 0.1; // Коэффициент выздоровления

        // Начальные условия
        double S = 999; // Количество восприимчивых
        double E = 0; // Количество латентно зараженных
        double I = 1; // Количество заболевших
        double R = 0; // Количество выздоровевших

        // Время моделирования
        double time = 0;
        double dt = 1; // Шаг интегрирования (в днях)

        // Количество дней для моделирования
        int days = 100;

        Console.WriteLine("Day\tS\tE\tI\tR");

        for (int i = 0; i < days; i++)
        {
            Console.WriteLine($"{i}\t{S:F2}\t{E:F2}\t{I:F2}\t{R:F2}");

            // Метод Эйлера для обновления значений
            double dS = -beta * S * I;
            double dE = beta * S * I - sigma * E;
            double dI = sigma * E - gamma * I;
            double dR = gamma * I;

            S += dS * dt;
            E += dE * dt;
            I += dI * dt;
            R += dR * dt;

            time += dt;
        }
    }
}
