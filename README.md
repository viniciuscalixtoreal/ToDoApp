# ToDoApp

Web API

Primeiro clone o repositório do git para o seu repositório local, ou baixe os arquivos do projeto
Com o projeto em sua máquina, abra o Visual Studio e carregue a solução
Com a solução aberta no Visual Studio, edite o arquivo appsettings.json
Após esta configuração, compile o projeto, verifique se o projeto API está como startup project, então rode a aplicação, que abrirá um swagger e permitirá testar os endpoints

Angular

Primeiro clone o projeto ou baixe os arquivos para a sua máquina
Verifique se tem o Angular instalado
Abra a pasta do projeto no VS Code e instale as dependências do projeto no terminal (npm install)
Execute a aplicação no terminal (ng serve)
Com a Web API backend rodando, Abra a URL que foi gerada e utilize a tela desenvolvida

Banco de Dados

Com a aplicação clonada, instale o SQL Server
Configure o arquivo appsettings.json, na sessão ConnectionStrings, para configurar para o seu servidor de banco local
Instale no projeto, as dependências do EntityFramework Core (Microsoft.EntityFrameworkCore.SqlServer, dotnet add package Microsoft.EntityFrameworkCore.Tools, dotnet add package Microsoft.EntityFrameworkCore.Design)
No terminal do console, execute a migration (dotnet ef database update)
Verifique se o banco de dados foi criado no seu servidor local
Execute a aplicação

Diferenciais

Foi desenvolvida uma Web API com os princípios do Clean Code e Solid, utilizando Clean Architecture, para organizar a aplicação em camadas, promovendo desacoplamento, reusabilidade e manutenibilidade.
