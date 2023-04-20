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

var carro1 = new Carro()
{
  Marca = "GM - Chevrolet",
  Modelo = "PRISMA Sed. LT 1.0 8V FlexPower 4p",
  Placa = "FKG-3068",
  Cor = "Prata",
  Proprietario = proprietario1
};

var carro2 = new Carro()
{
  Marca = "GM - Chevrolet",
  Modelo = "Corsa Sed. Maxx 1.8 MPFI 8V FlexPower",
  Placa = "FZY-4718",
  Cor = "Vermelho",
  Proprietario = proprietario2
};

var carro3 = new Carro()
{
  Marca = "Ford",
  Modelo = "Ka 1.0 TiCVT Flex 5p",
  Placa = "EUY-7046",
  Cor = "Azul",
  Proprietario = proprietario3
};