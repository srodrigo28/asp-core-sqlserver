#### Exemplo DotNet Asp Core

* Criando aplicação asp console
```
dotnet new console
```

* Entity
```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

#### Rodar o projeto
* Rodar o projeto
```
dotnet run
```

* Rodar o projeto e monitorar alterações
```
dotnet watch
```

* Design
```
dotnet add package Microsoft.EntityFrameworkCore.Design
```

#### Model Cliente
```
namespace EFCoreExample.Models;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
}
```

#### Instalação global fica disponivel para outros projetos
```
dotnet tool install --global dotnet-ef
```

#### Migration
* Add
```
dotnet ef migrations add CreateTableCliente
dotnet ef migrations add CreateTableProduto
```
* remove depois apagar os 2 primeiros arquivos da pasta Migrations
```
dotnet ef migrations remove
```
* update
```
dotnet ef database update
```



#### Ref.
* Capi. 5 iniciado termina no cap 6 valta 1:20min
```
https://www.treinaweb.com.br/painel/cursos/c-sharp-entity-framework-core-orm/aula/2/subaula/2
```