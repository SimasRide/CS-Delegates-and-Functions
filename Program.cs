using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Tres
{
    public delegate int[] sss(int tam, int valor);
    internal class Program
    {
        static void Main(string[] args)
        {

            var numeros = Utils.magico(x => x %2==0);
            foreach (var x in numeros) {
                Thread.Sleep(200);
                Console.Write($"{x}:"); }

            //Console.WriteLine(Utils.faztudo(2, 3, (a, b) => a + b));
            //Action<string> accao = (s) =>
            //{
            //Console.WriteLine(s);

            //};
            //accao("ola");
            //Func<int, int, int[]> s2;
            // s2 = (t,v) =>
            //{
            //    int[] r = new int[t];
            //    for (int i = 0; i < t; i++) r[i] = v;
            //    return r;
            //};
            //int[] x = s2(20, 3);
            //foreach (int i in x) Console.Write($"{x[i]}:");
                //Func<float, float, int> ff; /* Func pode returnar tuplas*/
            //string operacao;
            //Console.WriteLine("Que operação pretende:");
            //operacao = Console.ReadLine();
            //Console.WriteLine(operacao);
            //Func<int, int, int> func;
            //switch (operacao)
            //{
            //    case "+":
            //        func = (a, b) => a + b;
            //        break;
            //    case "-":
            //        func = (a, b) => a - b;
            //        break;
            //    case "*":
            //        func = (a, b) => a * b;
            //        break;
            //    case "/":
            //        func = (a, b) => a / b;
            //        break;
            //    default:
            //        func = null;
            //        break;
            //}
            //if (func != null) Console.WriteLine(func(2,3));
            //else Console.Write("erro");


            // Expressão lambda - É um método anónimo o mesmo quue ja criamos mas não tem delegate e não tem obrigatoriedade de pôr tipos (int x etc)
            /* Expressão Lamba => */
            //funcao f = (x) => 3 * x;
            //Console.WriteLine(f(5));
            //f = (x) =>
            //{
            //    x += 1;
            //return x % 3; //return aqui é necessário mas se fosse void já não
            //    };
            //Console.WriteLine(f(5));





            // Delegate é um apontador de métodos, a variável fn é um delegate, e é um multicasting

            //dlg2 fn = Utils.Inc; // o dlg2 aponta para a função definida no Utils que é a função Inc
            //int rslt;
            //fn(34, out rslt);
            //Console.WriteLine(rslt);

            //fn += delegate (int n, out int r) //A natureza multicasting dos delegates apontam para o método anónimo , e ao executar executa os 2 métodos (rslt e somando 1000)
            //{
            //    Console.WriteLine("Somando 1000");
            //    r = 1000 * n;
            //};
            //fn(2, out rslt);
            //Console.WriteLine(rslt);


            //fn é variável(delegate) da classe função. Este delegate pode apontar para qualquer método que deolve um int e recebe int, o dobro não é exceção.
            // Delegate - É um tipo de função - Guarda referências para métodos - permite trocar comportamentos dinamicamente ,o mesmo delegate
            // pode apontar vários métodos e executa-los todos
            //  funcao fn=Utils.dobro;
            //  int rslt = fn(34);
            // Console.WriteLine(rslt);
            //MÉTODO ANÓNIMO 
            //    fn += delegate(int num)  // recebe e devolve int
            //       {
            //           Console.WriteLine("Somando...");
            //        return num + 100;
            //       };              //Este ; determina o sinal de igual
            //    int rslt = fn(2);
            //    Console.WriteLine(rslt);





















            ////Resumo deste código :
            //// Cria objeto Utils
            //// usa método de instância(dobro)
            ////usa método static avançado(estatistica)
            ////calcula min max e média

            //Utils utils = new Utils(); // Cria um objeto da classe Utils
            //                           // Utils - Classe com funções - utils -> variável(instância) : Isto permite usar funções não estáticas: como utils.dobro(3);
            //Console.WriteLine(utils.dobro(3)); // chama dobro(3) da classe utils - devolve(3*2)

            //// cria-se variáveis para guardar resultados:
            //float media = 0.0f; 
            //int min, max, bonus = 0; //bonus é valor extra fica 0
            //Utils.estatistica(ref media, out min, out max, new int[] { 17, 16, 19, 11 }, in bonus);
            //// ref media - vai ser alterado dentro da função e recebe a média final
            ////out min - vai receber o valor mínimo não precisa de valor inicial
            ////out max - vai receber o valor máximo
            //// new int[] - Faz o array de notas
            //// in bonus - Só de leitura, não pode ser alterado então é 0

            //Console.WriteLine($"{media} {min} {max}"); // Resultado final - media - min - max
            ////Resultado com notas (17, 16, 19, 11)
            ////Média = (17+16+19+11)/4= 15.75 
            //// Resultado final = 15,75 11 19

        }
    }
}
