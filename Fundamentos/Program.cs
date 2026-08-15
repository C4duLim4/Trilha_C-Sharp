using Fundamentos.Models;
// Pascal Case e Camel Case são as convenções do C#
// comando no CMD "dotnet new console" = cria um novo projeto


// Cast - Casting
// a diferença desses dois de baixo e o tratamento de valores Nulos (null) onde o Convert imprime o valor "0" sem dar erro, diferente do Parse que diz que o valor não pode ser Null e da erro

int a = Convert.ToInt32("5"); // Convert.tipo da variavel para qual vc quer converter 
Console.WriteLine(a); 

int b = int.Parse("5"); // Converte de string para um número Int também

int num = 5;
string c = num.ToString(); // para transformar em string é só usar o ToString() que está presente em todas as variáveis sem precisar usar o Convert ou Parse

String d = "15-";
int e = 0;

int.TryParse(d, out e); //Toda conversão de valores há um risco de uma exceção, pois muitas vezes não podemos prever o tipo de dado que está vindo. Para realizar uma conversão segura, ou seja, em que há a possibilidade de falhar e não queremos que nosso código seja interrompido
Console.WriteLine(b);




string apresentacao = "Olá, mundo";
int quantidade = 1; 
quantidade = 2; //Para alterar o valor da variavel vc não coloca o tipo, pois no C# se vc coloca o tipo ele entende que é uma nova variável

DateTime dataAtual = DateTime.Now; // representar datas
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// vc comenta tudo de uma vez de vc selecionar o bloco que quer depois CRTL + K + C

double altura = 1.80; // tipo que ignora os 0, diferente do Decimal

decimal preco = 1.80M; //tipo Variavel para declarar vlor monetario e atribuindo o 0

bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da váriavel quantidade: " + quantidade);
Console.WriteLine("Valor da váriavel altura: " + altura.ToString("0.00")); //com esse comando de tratamento ele mostra até onde os zeros devem aparecer
Console.WriteLine("Valor da váriavel preco: " + preco);
Console.WriteLine("Valor da váriavel condição: " + condicao);


//Pessoa novaPessoa = new Pessoa();

//novaPessoa.Nome = "Carlos";
//novaPessoa.Idade = 23;
//novaPessoa.Apresentar();