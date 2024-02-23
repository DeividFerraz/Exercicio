using System;
using System.Threading;

namespace didaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicinado");

            //Esta função faz com que esse código seja executado paralelamente e o resto do programa continue rodando.
            Thread tred = new System.Threading.Thread(Redimensionar);
            tred.Start();

            //Redimensionar();

            Console.Read();
        }

        static void Redimensionar()
        {
            #region "Diretorios"
            string diretorio_entrada = "Arquivo_Entrada";
            //se o arquivo n existir, ele entra no if e constroi
            if (!Directory.Exists(diretorio_entrada))
            {
                //Serve para criar uma pasta
                Directory.CreateDirectory(diretorio_entrada);
            }
            #endregion


            while (true)
            {

                Console.WriteLine("Estou vivo");

                //Função q da pauser de 3 segundos no envio de cada numero paralelamente no console
                Thread.Sleep(new TimeSpan(0, 0, 5));
            }
        }
    }
}
