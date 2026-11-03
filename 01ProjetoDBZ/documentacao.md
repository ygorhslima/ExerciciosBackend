 # Anotações do Vídeo do canal Gustavo Caetano do vídeo [CRUD] COMO FAZER UMA API COM C# .NET, EF CORE E MYSQL

- para criar uma aplicação web api com ASP NET com controllers execute

dotnet new webapi --use-controllers -o NomeDoProjeto

- Antes de criar a aplicação, é preciso antes instalar algumas dependências como o:
    - EntityFrameworkCore
    - EntityFrameworkCore.Tools
    - Pomelo.EntityFrameworkCore.MySQL

- Após isso crie os seus models na pasta Model
- depois de criar seus Models crie a pasta Data para conectar

Para fazer a migração
- dotnet ef migrations add Inicial
- dotnet ef database update