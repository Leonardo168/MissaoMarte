using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MissaoMarte.App.Utilities
{
    public static class InputUtility
    {
        public static string[] CapturarInput(string msg)
        {
            Console.WriteLine(msg);
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                string[] partes = input.Split(' ');
                return partes;
            }
            throw new ArgumentException("Input invalido.");
        }

        public static void CapturarCoordenadasCampoDePouso(string[] inputPartes, out int coordX, out int coordY)
        {
            if (inputPartes.Length == 2 &&
                int.TryParse(inputPartes[0], out coordX) &&
                coordX >= 0 &&
                int.TryParse(inputPartes[1], out coordY) &&
                coordY >= 0)
            {
                return;
            }
            throw new ArgumentException("Coordenadas invalidas.");
        }
    }
}