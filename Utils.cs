using System;                       
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tres 
{
    public delegate void dlg2(int n, out int acum);
    public delegate int funcao(int n); //Apontar outros métodos como "dobro" e este delegate aponta esta função porque este delegate tem um método que recebe um int e devolve int 
                                      
    // tal como internal int dobro(int x) { return x * 2; }
    internal class Utils    //Classe chamada Utils
                            // Esta classe Utils serve para: dobrar números - desenhar linhas na consola - multiplicar com valor default .
                            // calcular médias com vários valores - obter estatísticas (min, max, média)
    {
    internal int dobro(int x)
        {
            return x * 2;
            {
        public static IEnumerable<int>magico(Predicate<int>predi)
        {
            for (int i = 0; ; i++) if (predi(i)) yield return i;
        }
        


        internal static int faztudo(int a, int b , Func<int,int,int>fn)
        {
            return fn(a, b);
        }
        internal static void Inc(int x, out int r) 
        {

            r = x;
                }
        internal static int dobro(int x) 
        {
            Console.WriteLine("Multiplicando");
           return x * 2; 
        } //Recebe o dobro do valor e não é void

        static internal void linha(char ch, int n) // Desenha uma linha no ecrã - temos o conceito de estático e dinâmico
                                                  //É um procedure porque returna void (nada)
                                                  //O que é estático é executado na clase e o que não é estático é executado no objeto
                                                  // Ou seja tem de ser replicado para dentro de um objeto e depois sim
        {
            Console.WriteLine("\n"); 
            for (int i = 0; i < n; i++) Console.Write($"{ch}"); 
            Console.WriteLine("\n");
        }
        static internal int multiplica(int a, int b = 2)
        {
            return a * b;
        }
        static internal float somavar(int bonus, params int[] notas) //Permite passar vários números sem array fixo
        {
            float media = (float)bonus;
            foreach (var item in notas) media += item;
            return media / notas.Length;
        }
        static internal void estatistica(ref float media, out int min, out int max, int[] notas, in int bonus)
        //Passagem por referência - Passar o endereço e usar pointers internamente para atualizar vriáveis fora da Stack principal
        //ref float media - entra e sai modificado - a função altera a variável original
        //out int min, out int max - a função é obrigada a definir estes valores - usados para devolver múltiplos resultados
        //O ref é usado na média porque no fim o parâmetro vai alterar o valor , os refs podem ser ("out - antes de entrar na função ele pode estar indefenido(sem valor)",
        //                                                                                     "in - não pode ser alterado mesmo sendo passagem por referência
        //                                                                                     " e ref"já tem de ter valor antes de entrar na função e aqui altera)

        {
            min = max = notas[0];
            media = notas[0];
            for (int i = 1; i < notas.Length; i++)
            {
                if (max < notas[i]) max = notas[i];
                if (min > notas[i]) min = notas[i];
                media += notas[i];
            }
            media /= notas.Length;
            media += (float)bonus;
        }
    }
}
