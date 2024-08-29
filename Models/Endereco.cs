namespace AspCoreExemplo.Models;

public class Endereco
{
    public int Id { get; set; }
    public string Estado { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    public string Bairro { get; set; } = string.Empty;
    public string Logradouro { get; set; } = "";
    public string Numero { get; set; } = "";
}