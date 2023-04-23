using CadCar;

var proprietario1 = new Proprietario()
{
  Nome = "Mariana Gonçalves",
  Cpf = "565.189.068-80",
  Telefone = "(11) 98430-7630"
};

var proprietario2 = new Proprietario()
{
  Nome = "Jamil Salim",
  Cpf = "561.759.458-32",
  Telefone = "(11) 94109-0149"
};

var proprietario3 = new Proprietario()
{
  Nome = "Davi de Carvalho",
  Cpf = "126.443.588-68",
  Telefone = "(11) 97870-9528"
};

Carro carro1 = new Carro()
{
  Marca = "GM - Chevrolet",
  Modelo = "PRISMA Sed. LT 1.0 8V FlexPower 4p",
  Placa = "FKG-3068",
  Cor = "Prata",
  Proprietario = proprietario1
};

Carro carro2 = new Carro()
{
  Marca = "GM - Chevrolet",
  Modelo = "Corsa Sed. Maxx 1.8 MPFI 8V FlexPower",
  Placa = "FZY-4718",
  Cor = "Vermelho",
  Proprietario = proprietario2
};

Carro carro3 = new Carro()
{
  Marca = "Ford",
  Modelo = "Ka 1.0 TiCVT Flex 5p",
  Placa = "EUY-7046",
  Cor = "Azul",
  Proprietario = proprietario3
};


List<Carro> listaCarros = new List<Carro>();

listaCarros.Add(carro1);
listaCarros.Add(carro2);
listaCarros.Add(carro3);

//Exercicio 9
ListarCarros();

///Exercicio 8
CadastrarNovosCarros();

Console.WriteLine("Exercicio 8\n\n");
 
//Exercicio 9
ListarCarros();

///Exercicio 8
void CadastrarNovosCarros() 
{
  Carro carro4 = new Carro();
  
  Console.WriteLine("Digite Marca: ");
  carro4.Marca = Console.ReadLine();

  Console.WriteLine("Digite Modelo: ");
  carro4.Modelo = Console.ReadLine();

  Console.WriteLine("Digite Placa: ");
  carro4.Placa = Console.ReadLine();

  Console.WriteLine("Digite Cor: ");
  carro4.Cor = Console.ReadLine();
  
  var proprietario4 = new Proprietario();

  Console.WriteLine("Digite Nome: ");
  proprietario4.Nome = Console.ReadLine();
  
  Console.WriteLine("Digite CPF: ");
  proprietario4.Cpf = Console.ReadLine();
  
  Console.WriteLine("Digite Telefone: ");
  proprietario4.Telefone = Console.ReadLine();

  carro4.Proprietario = proprietario4;
  
  listaCarros.Add(carro4);
}

void ListarCarros() 
{
  foreach (Carro carro in listaCarros)
  {
    Console.WriteLine($@"{carro.Marca} - {carro.Modelo} - {carro.Placa} - {carro.Cor} - {carro.Proprietario.Nome}
                        - {carro.Proprietario.Cpf} - {carro.Proprietario.Telefone}");
  }
}