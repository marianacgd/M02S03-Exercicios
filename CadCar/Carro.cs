
namespace CadCar
{
  public class Carro
  {
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Placa { get; set; }
    public string Cor { get; set; }
    public Proprietario Proprietario { get; set; }
  }
}