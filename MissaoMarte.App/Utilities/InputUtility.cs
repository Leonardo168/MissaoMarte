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

        private static bool TryParseCoordenada(string input, out int coord)
        {
            return int.TryParse(input, out coord) && coord >= 0;
        }

        public static void CapturarCoordenadasCampoDePouso(string[] inputPartes, out int coordX, out int coordY)
        {
            if (inputPartes.Length == 2 &&
                TryParseCoordenada(inputPartes[0], out coordX) &&
                TryParseCoordenada(inputPartes[1], out coordY))
            {
                return;
            }
            throw new ArgumentException("Coordenadas invalidas.");
        }

        private static bool TryParseDirecao(string input, out char direcao)
        {
            if (char.TryParse(input, out direcao))
            {
                switch (direcao)
                {
                    case 'N':
                    case 'L':
                    case 'S':
                    case 'O':
                        return true;
                    default:
                        return false;
                }
            }
            return false;
        }

        public static void CapturarPosicaoVeiculo(string[] inputPartes, out int coordX, out int coordY, out char direcao)
        {
            if (inputPartes.Length == 3 &&
                TryParseCoordenada(inputPartes[0], out coordX) &&
                TryParseCoordenada(inputPartes[1], out coordY) &&
                TryParseDirecao(inputPartes[2], out direcao))
            {
                return;
            }
            throw new ArgumentException("Posicao invalida.");
        }

        private static bool ValidarInstrucoes(char[] partes)
        {
            HashSet<char> instrucoesValidas = ['E', 'D', 'A'];
            return partes.All(instrucoesValidas.Contains);
        }

        public static char[] CapturarInstrucoes(string msg)
        {
            Console.WriteLine(msg);
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                char[] partes = input.Where(c => !char.IsWhiteSpace(c)).ToArray();
                if (ValidarInstrucoes(partes))
                {
                    return partes;
                }
            }
            throw new ArgumentException("Instrucoes invalidas.");
        }
    }
}