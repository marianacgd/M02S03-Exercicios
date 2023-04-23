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
//ListarCarros();

///Exercicio 8
//CadastrarNovosCarros();

//Exercicio 9
//ListarCarros();

//Exercicio 8
void CadastrarNovosCarros() 
{
  Carro carro = new Carro();
  
  Console.WriteLine("Digite Marca: ");
  carro.Marca = Console.ReadLine();

  Console.WriteLine("Digite Modelo: ");
  carro.Modelo = Console.ReadLine();

  Console.WriteLine("Digite Placa: ");
  carro.Placa = Console.ReadLine();

  Console.WriteLine("Digite Cor: ");
  carro.Cor = Console.ReadLine();
  
  var proprietario = new Proprietario();

  Console.WriteLine("Digite Nome: ");
  proprietario.Nome = Console.ReadLine();
  
  Console.WriteLine("Digite CPF: ");
  proprietario.Cpf = Console.ReadLine();
  
  Console.WriteLine("Digite Telefone: ");
  proprietario.Telefone = Console.ReadLine();

  carro.Proprietario = proprietario;
  
  listaCarros.Add(carro);

  Console.WriteLine("Cadastro Efetuado");
}

void ListarCarros() 
{
  foreach (Carro carro in listaCarros)
  {
    Console.WriteLine($"Marca: {carro.Marca} - Modelo: {carro.Modelo} - Placa: {carro.Placa} - Cor: {carro.Cor} - Nome: {carro.Proprietario.Nome} - CPF: {carro.Proprietario.Cpf} - Telefone: {carro.Proprietario.Telefone}");
    Console.WriteLine("");
  }
}

bool showMenu = true;

while(showMenu)
{
    int menuSelecionado;
    Menu();

    if (int.TryParse(Console.ReadLine(), out menuSelecionado) == false)
    {
        menuSelecionado = 0;
    }

    switch (menuSelecionado)
    {
        case 1:
          CadastrarNovosCarros();
          break;
        case 2:
          ListarCarros();
          break;
        case 3:
          showMenu = false;
          break;
        default:
          Console.Clear();
          Console.WriteLine("Opção digitada errada.\n");
          break;
    }
}

void Menu()
{
    Console.WriteLine("Menu cadastro de carro\n");
    Console.WriteLine("Digite 1 para Cadastrar Novo Carro.");
    Console.WriteLine("Digite 2 para Buscar Carros.");
    Console.WriteLine("Digite 3 para Sair.");
    Console.Write("Digite Opção do Menu: ");
}