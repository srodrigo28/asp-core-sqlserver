namespace AspCoreExemplo.Models;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = ""; // string.Empty;
    public int Quantity { get; set; } = 0; // int.MaxValue;
    public float Price { get; set; } = 0; //double.PositiveInfinity;
}