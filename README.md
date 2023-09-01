# Bem-vindo ao Cifralite!

O Cifralite é um sistema web inovador que torna mais fácil para os músicos, sejam eles iniciantes ou experientes, acessarem cifras simplificadas de suas músicas favoritas. Além disso, o Cifralite oferece recursos avançados, como a possibilidade de mudar o tom das cifras, criar um repertório personalizado e compartilhar músicas entre grupos e pessoas. Este repositório contém o código-fonte do Cifralite, juntamente com inforcascamações essenciais para configurar e executar o sistema.

## Funcionalidades Principais

- **Acesso a Cifras Simplificadas:** O Cifralite fornece cifras simplificadas para uma ampla variedade de músicas, permitindo que os músicos aprendam e toquem suas músicas favoritas de forma mais rápida e fácil.

- **Mudança de Tom:** Os usuários podem alterar o tom das cifras para se adequar às suas vozes ou preferências de reprodução. Isso torna o aprendizado e a execução das músicas mais flexíveis.

- **Criação de Repertório:** Os músicos podem criar e gerenciar seu próprio repertório personalizado, adicionando músicas de sua escolha e organizando-as para acesso rápido.

- **Compartilhamento de Músicas:** O Cifralite permite que os usuários compartilhem suas músicas e repertórios com amigos, colegas de banda e outros grupos, facilitando a colaboração musical.

## Configuração do Ambiente Local

1. **Pré-requisitos:**
   - Instale o [Visual Studio Code (VSCode)](https://code.visualstudio.com/).
   - Instale a extensão [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer) no VSCode para servir o aplicativo.
   - Instale o [Git](https://git-scm.com/) para controlar as versões do código.

2. **Configurações do Git:**
   - Abra o terminal.
   - Configure seu nome de usuário: `git config --global user.name "Galo Cletinho"`
   - Configure seu endereço de e-mail: `git config --global user.email "cleitinho@galo.com"`

3. **Clonando o Repositório:**
   - Abra o VSCode.
   - Pressione `Ctrl+Shift+P` para abrir a paleta de comandos.
   - Digite "Git: Clone" e forneça o URL do repositório: `https://github.com/manoelivisson/cifralite.git`.
   - Escolha o diretório onde deseja clonar o projeto.

4. **Configuração do Banco de Dados:**
   - Configure as credenciais do banco de dados no arquivo `.env`.
   - Execute as migrações do banco de dados.

5. **Execução do Servidor:**
   - Clique com o botão direito no arquivo `index.html`.
   - Selecione "Open with Live Server" para iniciar o servidor local.

## Fluxo de Desenvolvimento

- Receba uma tarefa do Github.
- Crie uma nova branch com o formato `(numero-da-issue)-nome-da-task`.
- Realize a tarefa e faça commits para sua branch.
- Crie um pull request para a branch principal.
- Aguarde a revisão de outros colaboradores.
- Após a revisão, a branch será mesclada na branch principal.

## Autores

- Iury
- Manoel Ívisson de Araújo Ferreira
- Yago Cortez

---
