## MVC - visão - modelo - controle

Possibilita seprar o porjeto em camadas onde cada uma delas executa o que foi definido e nada mais.

Benefício - isolamento das regras de negócio da interface do usuário

Model - é responsável pela leitura e escrita de dados e também suas validações
View - interação com o usuário
Control - recebe todas as requisições e controla qual model usar e qual view será mostrado ao usuário

controller / action method / parameters (optional)

Action Result é o resultado de uma ação processada por um controller.
Tipos:

## HTTP verbs
Get - buscar recursos
Post - criar um novo recurso
Put/patch - atualizar um recurso existente
Delete - Remmover um recurso

## Razor
É uma view engine. Objetivo: simplificar o desenvolvimento de aplicações ASP .NET, deixa o código mais simples, fácil e legível

Benefícios:

menor curva de aprendizagem; sintaxe limpa; intellisense no visual studio

## Middlewares
São componentes classes que é executada em todas as solicitações na aplicação ASP.NET
Cada middleware adiciona ou modifica a solicitação http e pode passar o controle para o próximo middleware

## Startup.cs
É responsável por ser o ponto inicial do projeto. Métodos responsáveis por configurar o projeto:
ConfigureServices - registrar as classes ao container de injeção de dependencia
Configure - controla o pipeline da aplicação. são especificados os middleware.

