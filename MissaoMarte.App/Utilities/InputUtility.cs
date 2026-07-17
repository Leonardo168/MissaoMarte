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
    }
}