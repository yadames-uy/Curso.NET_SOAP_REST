using System;

namespace SoapClient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MiServicioClient.MiServicioClient service = new MiServicioClient.MiServicioClient();
            string result = service.Sumar(2, 4, 3);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}