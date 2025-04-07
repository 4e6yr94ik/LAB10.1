using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите интенсивность потока"); //λ
            int intP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите среднюю продолжительность разговора");
            int t = Convert.ToInt32(Console.ReadLine());
            int intO = 1 / t; //Интенсивность обсложивания μ;
            int isp = intP/intO; //коэфициент использования
            int Pn = isp; //Вероятность хотя бы одного клиента
            int P0 = 1 - Pn; //Вероятность отсуттвия клиентов
            int VO = intP/intO; //Вероятность отказа
            int VU = 1 - VO; //Вероятность успеха
            int Q = intO/intP; //относительная пропускная способность
            int A = intO * VU; //Абсолютная пропускная способность
            int L_q = (intP * intP / (intO * (intO - intP))); //Среднее число клиентов находящихся в очереди

        }
    }
}
