
<div align="center">
   <img src="./src/Cifralite.Web/wwwroot/fotos/CifraLite_LogoPNG.png" alt="License" width="300px">
</div>

# Bem-vindo ao Cifralite!

O Cifralite é um sistema web inovador que torna mais fácil para os músicos, sejam eles iniciantes ou experientes, acessarem cifras simplificadas de suas músicas favoritas. Além disso, o Cifralite oferece recursos avançados, como a possibilidade de mudar o tom das cifras, criar um repertório personalizado e compartilhar músicas entre grupos e pessoas. Este repositório contém o código-fonte do Cifralite, juntamente com informações essenciais para configurar e executar o sistema.

## Funcionalidades Principais

- **Acesso a Cifras Simplificadas:** O Cifralite fornece cifras simplificadas para uma ampla variedade de músicas, permitindo que os músicos aprendam e toquem suas músicas favoritas de forma mais rápida e fácil.

- **Mudança de Tom:** Os usuários podem alterar o tom das cifras para se adequar às suas vozes ou preferências de reprodução. Isso torna o aprendizado e a execução das músicas mais flexíveis.

- **Criação de Repertório:** Os músicos podem criar e gerenciar seu próprio repertório personalizado, adicionando músicas de sua escolha e organizando-as para acesso rápido.

- **Compartilhamento de Músicas:** O Cifralite permite que os usuários compartilhem suas músicas e repertórios com amigos, colegas de banda e outros grupos, facilitando a colaboração musical.

## Configuração do Ambiente Local

Siga as instruções abaixo para configurar o ambiente local.

### Preparação do Ambiente

- Instale o [Visual Studio Code (VSCode)](https://code.visualstudio.com/).
- Instale o [Git](https://git-scm.com/) para controlar as versões do código.
- Instale o [.NET 6+](https://dotnet.microsoft.com/download/dotnet/6.0) para executar o projeto.
- Instale o [SqlServer](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) para criar o banco de dados.
- Instale o [GH](https://cli.github.com/) para facilitar o uso do Github.

#### Configurações do VSCode

- Abra o VSCode.
- Instale a extensão [C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp).
- Instale a extensão [SQLite Viewer](https://marketplace.visualstudio.com/items?itemName=qwtel.sqlite-viewer).
- Instale a extensão [Nuget Gallery](https://marketplace.visualstudio.com/items?itemName=patcx.vscode-nuget-gallery).
- Instale a extensão [SLN Support](https://marketplace.visualstudio.com/items?itemName=adrianwilczynski.sln-support).

#### Configurações do .NET

- Abra o terminal.
- Execute o comando `dotnet --version` para verificar se o .NET está instalado corretamente.
- Execute o comando `dotnet tool install --global dotnet-ef` para instalar a ferramenta de linha de comando do Entity Framework.
- Execute o comando `dotnet ef` para verificar se a ferramenta foi instalada corretamente.

#### Configurações do Git

- Abra o terminal.
- Configure seu nome de usuário: `git config --global user.name "Galo Cletinho"`
- Configure seu endereço de e-mail: `git config --global user.email "cleitinho@galo.com"`
- Configure o VSCode como editor padrão: `git config --global core.editor "code --wait"`
- Configure o `gh` como cliente padrão: `git config --global github.cli true`

- Execute o comando `gh auth login` para fazer login no Github.
- Escolha a opção "Authenticate with a web browser".
- Faça login no Github.

### Clonando o Repositório

- Abra o terminal.
- Navegue até o diretório onde deseja clonar o projeto.
- Execute o comando `gh repo clone manoelivisson/cifralite` para clonar o repositório.


### Configuração do Banco de Dados

O banco de dados de desenvolvimento padrão é o Sqlite. Você não precisa instalar nada no projeto, mas deve rodar as migrações para criar o banco de dados. Para configurar o banco de dados, siga os passos abaixo:

- Abra o terminal.
- Navegue até o diretório do projeto `src/Cifralite.Web`.
- Execute o comando `dotnet ef database update --context AppDbContextSqlite` para criar o banco de dados.


### Execução do Servidor

Você pode executar o servidor de duas maneiras:

1. Na raiz do projeto, execute o comando `dotnet watch run --project src/Cifralite.Web` para iniciar o servidor local.
2. Abra o VSCode.
   - Inicie o servidor pressionando `F5` e selecionando o ambiente **Development**.



## Configuração do Acesso a Dados com Sql Server

Apesar do Sqlite ser o banco de dados padrão para desenvolvimento, você pode usar o Sql Server para armazenar os dados utilizando o ambiente de **Staging**. Para isso, siga os passos abaixo:

- Após instalar o Sql Server, abra o **Sql Server Management Studio**.
- Crie um banco de dados chamado `Cifralite`.
- Abra o arquivo `src/Cifralite.Web/appsettings.json`.
- Altere o valor da propriedade `ConnectionStrings:SqlServer` para `Server=localhost;Database=Cifralite;Trusted_Connection=True;MultipleActiveResultSets=true`.

- Abra o terminal.
- Navegue até o diretório do projeto `src/Cifralite.Web`.
- rode o comando para mudar o ambiente no PowerShell `$env:ASPNETCORE_ENVIRONMENT="Staging"`
- Execute o comando `dotnet ef database update --context AppDbContext` para criar o banco de dados.

- Ao rodar o projeto no servidor inicie pressionando `F5` e selecionando o ambiente **Staging**.

Agora, você pode executar o servidor no ambiente de **Staging** para usar o Sql Server como banco de dados.


## Fluxo de Desenvolvimento

1. Inicie escolhendo uma tarefa pendente no GitHub, geralmente representada por uma "issue".
2. Crie uma nova branch para isolar suas alterações, seguindo o padrão: `{numero-da-issue}-{nome-da-issue-minisculo-sem-acento-separado-por-tracos}`.
3. Desenvolva a tarefa. Ao alcançar marcos significativos, faça commits claros e concisos em sua branch, descrevendo as mudanças.
4. Ao finalizar a tarefa, faça um último commit e garanta que todas as alterações estejam documentadas e testadas.
5. Crie um pull request (PR) da sua branch para a branch principal. No PR, destaque pontos específicos que podem necessitar de atenção especial durante a revisão.
6. Aguarde a revisão do PR por outros membros da equipe. Esteja preparado para fazer alterações com base em feedbacks.
7. Após a revisão e solução de possíveis conflitos, a branch será mesclada na branch principal. Certifique-se de que a branch principal sempre esteja em um estado funcional e estável.
8. Com a conclusão da mesclagem e todas as alterações na branch principal, prepare-se para iniciar a próxima tarefa.

## Equipe de Desenvolvimento

Iury: Desenvolvedor e colaborador.

Manoel Ívisson de Araújo Ferreira: Desenvolvedor e colaborador.

Yago Cortez: Desenvolvedor e colaborador.
