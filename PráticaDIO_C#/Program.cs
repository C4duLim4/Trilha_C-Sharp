
int[] arrayInteiros = new int[3]; // Declaração de um array de inteiros com 3 posições


arrayInteiros[0] = 67;
arrayInteiros [1] = 35;
arrayInteiros[2] = 46;

Console.WriteLine("percorrendo o array com o for");
for (int i = 0; i < arrayInteiros.Length; i++)// Length é uma propriedade que retorna o tamanho do array, ou seja, a quantidade de elementos que ele possui
{
    Console.WriteLine($"Posição N° {i}: {arrayInteiros[i]}");
}

Console.WriteLine("percorrendo o array com o foreach");
int contador = 0;
foreach (int i in arrayInteiros)//funciona como um for, mas não precisa declarar a variável de controle, ele percorre todos os elementos do array
{
    Console.WriteLine($"Posição N° {contador}: {i}");
    contador++;
}// a desvantagem dele é que não possivel pegar a posição do elemento, apenas o valor do elemento

Console.ReadLine();// Mantém o console aberto para ler até que o usuário pressione uma tecla





// =========================================================================================================

//string opcao = string.Empty;

//while(true)
//{
//    Console.WriteLine("Digite uma opção: ");
//    Console.WriteLine("1 - Cadastrar cliente");
//    Console.WriteLine("2 - Buscar cliente");
//    Console.WriteLine("3 - Apagar cliente");
//    Console.WriteLine("4 - Sair");
//    opcao = Console.ReadLine();
//    switch (opcao)
//    {
//        case "1":
//            Console.WriteLine("Cadastrar cliente");
//            break;
//        case "2":
//            Console.WriteLine("Buscar cliente");
//            break;
//        case "3":
//            Console.WriteLine("Apagar cliente");
//            break;
//        case "4":
//            Console.WriteLine("Sair");
//            Environment.Exit(0);
//            break;
//        default:
//            Console.WriteLine("Opção inválida");
//            break;
//    }
//}


// ==========================================================================================================

//int soma = 0, numero = 0;

//do {
//    Console.WriteLine("Digite um número e 0 para sair: "); 
//    numero = Convert.ToInt32(Console.ReadLine());

//    soma += numero;

//} while (numero != 0); // Executa o código primeiro, e depois faz a verificação condicional para continuar o laço

//Console.WriteLine($"A soma dos números digitados é: {soma}");


// ==========================================================================================================

//Console.WriteLine("Digite uma letra!");
//string letra = Console.ReadLine(); // Permite que o terminal espere algum comando digitado

//switch (letra)
//{ 
//    case "a":
//    case "e":
//    case "i":
//    case "o":
//    case "u":
//        Console.WriteLine("Vogal");
//        break;

//    default:
//        Console.WriteLine("Não é uma vogal");
//        break;
//}


//---------------------------------------------------------------------------------------------------------


//int qdEstoque = 3;
//int qtdCompra = 4;

//bool possivelComprar = qtdCompra <= qdEstoque && 0 < qtdCompra; //para negar um trocar o valor de true para false
//e vice-versa, basta colocar ! na frente da variável


//Console.WriteLine($"Quantidade em estoque: {qdEstoque}");
//Console.WriteLine($"Quantidade solicitada: {qtdCompra}");
//Console.WriteLine($"Compra possível: {possivelComprar}");

//if ( qtdCompra == 0){
//    Console.WriteLine("Venda Inválida");
//}
//else if (possivelComprar) { 
//    Console.WriteLine("Compra autorizada.");
//} 
//else {
//    Console.WriteLine("Compra não autorizada.");
//}



