using AspCoreExemplo.Contexts;
using AspCoreExemplo.Models;

var db = new AppDbContext();

/** ***************** Lista para Inserir *****************
var cliente1 = new Cliente
{
    Nome = "Carlos Silva",
    Cpf = "999.999.999-99"
};

var cliente2 = new Cliente
{
    Nome = "Aline Almeida",
    Cpf = "999.999.999-99"
};
*/

/** ***************** Adicionar *****************
db.Clientes.Add(cliente);
db.AddRange(cliente1, cliente2);
db.SaveChanges();
*/

/** ***************** Listando todos *****************
foreach(var cliente in db.Clientes.ToList()){
   Console.WriteLine(cliente);
}
*/

/* ***************** Lista por id  *****************
var buscarPorId = db.Clientes.Find(2);
Console.WriteLine(buscarPorId);
*/

/* ***************** Lista por nme linha completa  *****************
var cliente = db.Clientes.Where(x => x.Nome.Contains("a")).SingleOrDefault();
Console.WriteLine(cliente);
*/

/* ***************** Lista por nme *****************
var buscarPorNome = db.Clientes
    .Where(x => x.Nome
    .Contains("S"))
    .Select(x => x.Nome)
    .FirstOrDefault();
Console.WriteLine(buscarPorNome);
*/