using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace par_impar {
    class Program {
        static void Main(string[] args) {

            int n, i, x;
            string parImpar, sentido;

            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            parImpar = "NULO";
            sentido = "NULO";

            for (i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                x = int.Parse(Console.ReadLine());

                if (x != 0) {

                    if (x % 2 != 0) {
                        parImpar = "IMPAR";
                        if (x < 0) {
                            sentido = "NEGATIVO";
                        }
                        else {
                            sentido = "POSITIVO";
                        }
                    }

                    if (x % 2 == 0) {
                        parImpar = "PAR";
                        if (x < 0) {
                            sentido = "NEGATIVO";
                        }
                        else {
                            sentido = "POSITIVO";
                        }
                    }

                    Console.WriteLine(parImpar + " " + sentido);
                }

                else {
                    Console.WriteLine("NULO");
                }
            }
        }
    }
}
