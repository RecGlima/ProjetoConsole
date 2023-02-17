// See https://aka.ms/new-console-template for more information

int opcao = 0;
do
{
    //Limpa o texto do console/Bash
    Console.Clear();

    // Apresentar o menu de opções
    Console.WriteLine(@"Você quer aprender sobre o que? 
                1 - Front-End
                2 - Back-End
                0 - Sair
                ");

    // Esperar o usuário digitar, e salvar oque ele digitou
    // Convert.ToInt32 => Transformar um text em um número
    opcao = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    // Mostra a opção que o usuário escolheu
    Console.WriteLine($"Você escolheu a opção {opcao}");
    switch (opcao)
    {
        // Caso o usuário tenha escolhido Front-End
        case 1:
            Console.WriteLine("Front-End");
            Console.WriteLine("Você devera estudar HTML, CSS e JavaScript");
            break;
        // Caso o usuário tenha escolhido Back-End
        case 2:
            Console.WriteLine("Back-End");
            Console.WriteLine("Você deverá estudar Logica, POO, Desenvolvimento de API");
            break;
        case 0:
            Console.WriteLine("Obrigado por usar o nosso sistema");
            break;
        // Caso o usuário tenha escolhido qualquer outra opção
        default:
            Console.WriteLine("Você escolheu uma opção invalida");
            break;
    }
    Console.ReadLine();

} while (opcao != 0);
