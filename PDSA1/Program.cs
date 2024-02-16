namespace PDSA1
{
    internal class Program
    {
        static void verificaTipoCarro() {
            Console.WriteLine("Selecione o Tipo do Carro:");
            Console.WriteLine("[1] Apenas Gasolina\n[2] Apenas Etanol\n[3] Flex");
            
        }
        static void Main(string[] args)
        {
            try
            {
            int opcaoMenu = 0;
            Console.WriteLine("[1] Calcular Combustível\n[2] Editar Dados\n[3] Sair do Programa\n");
            Console.Write("Digite sua escolha:");
            opcaoMenu = int.Parse(Console.ReadLine());

           
                switch (opcaoMenu)
                {
                    case 1:
                        verificaTipoCarro();
                        break;
                    case 2:
                        Console.Write("B");
                        break;
                    case 3:
                        Console.Write("C");
                        break;
                    default:
                        Console.Write("Selecione uma opção válida!");
                        break;

                }
            }
            catch (Exception ex) {
                Console.Write("Selecione uma opção válida!");
            }
       }


    }
}
