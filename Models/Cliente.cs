using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspCoreExemplo.Models;

[Table("clientes")]
public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"{Id} . {Nome} - {Cpf}";
    }
}