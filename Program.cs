using AspCoreExemplo.Contexts;
using AspCoreExemplo.Models;

var db = new AppDbContext();

/**01 ***************** Lista para Inserir *****************
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

/**02 ***************** Adicionar *****************
db.Clientes.Add(cliente);
db.AddRange(cliente1, cliente2);
db.SaveChanges();
*/

/**03 ***************** Listando todos *****************  
foreach(var cliente in db.Clientes.ToList()){
   Console.WriteLine(cliente);
}
 */

/**04 ***************** Lista por id  *****************
var buscarPorId = db.Clientes.Find(2);
Console.WriteLine(buscarPorId);
*/

/**05 ***************** Lista por nme linha completa  *****************
var cliente = db.Clientes.Where(x => x.Nome.Contains("a")).SingleOrDefault();
Console.WriteLine(cliente);
*/
 
/**06 ***************** Lista por nme ***************** 
var buscarPorNome = db.Clientes.Where(x => x.Nome.Contains("S")).Select(x => x.Nome).FirstOrDefault();
Console.WriteLine(buscarPorNome);
*/

/**07 ***************** Editar por Cpf ***************** 

var cliente = db.Clientes.Find(1)!;
cliente.Cpf = "888.888.888-88";
db.SaveChanges();
*/

/**08 ***************** Editar Total por *****************  
var clienteEditar = new Cliente
{
    Id = 2,
    Nome = "Carol Sena",
    Cpf = "999.777.777-99"
}; 
db.Update(clienteEditar);
db.SaveChanges();
*/

/**09 ***************** Editar Total Try catch ***************** 
try{
    var clienteEditar = new Cliente
    {
        Id = 2,
        Nome = "Carol Sena",
        Cpf = "999.777.777-99"
    };
    db.Update(clienteEditar);
    db.SaveChanges();
}catch(Exception){
    Console.WriteLine($"Erro ao editar :( ");
}
 */

/**10 ***************** Apagar por Id Try catch *****************  
try{
    var cliente = new Cliente { Id = 3 };
    db.Remove(cliente);
    db.SaveChanges();
}catch(Exception){
    Console.WriteLine($"Erro ao excluir :( ");
}
*/