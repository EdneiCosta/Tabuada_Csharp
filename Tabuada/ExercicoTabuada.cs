using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{

        internal class ExercicioTabuada
        {
            public static void Executar()
            {
                Console.WriteLine("Informe um número para a Tabuada");
                if (int.TryParse(Console.ReadLine(), out int valorUsuario))
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    sb.AppendLine($"=-=-= TABUADA do {valorUsuario} =-=-=-=-=-=-=-=-=");
                    sb.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                    for (int i = 0; i < 11; i++)
                    {
                        sb.AppendLine($"{valorUsuario} X {i} = {valorUsuario * i}");
                    }
                    Console.WriteLine(sb.ToString());
                }
                else
                {
                    Console.WriteLine("Numero invalido");
                }
            }
        }
}



