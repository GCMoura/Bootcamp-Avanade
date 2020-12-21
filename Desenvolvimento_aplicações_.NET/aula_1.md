## entity framework

É um ORM(mapeador relacional de objeto) que permite que os desenvolvedores de .NET trabalhem com um banco de dados usando objetos .NET.
Elimina a necessidad da maioria do código de acesso a dados que os desenvolvedores geralmente precisam gravar.

3 linhas:
Database First: tem como objetivo ler o banco de dados e aplicar uma engenharia reversa carregando as classes que representarão as tabelas do banco

Model first: permite gerar primeiro um modelo e a partir dele gerar nossa base de dados.
é feita atravé do EDM Designer utilizando os componente que ele nos disponibiliza sendo o mais comum o Entity e o Association

Code first: cria primeiro as suas classes de entidade e deixa para o Entity Framework a responsabiidade de criar o banco de dados
Essas classes são conhecidas como classes POCO (Plan Old CLR Objects) que são classes que utilizam apenas os tipos do .NET  framework.

## Data anotations:
É um recurso que permimte que vc adicione atributos e métodos em nossas classes para alterar convenções padrão e personalizar alguns comportamentos
Principais atributos:
Required - RegularExpression - Display - StringLength - MinLength - Range - DisplayFormat

## Migrations
Recurso que oferece uma maneira de atualizar de forma incremental o esquema banco de dados para manter em sincronia com o modelo de classes do seu projeto preservando os dados existentes.
É possível realizar o downgrade para a versão anterior.

CreateDatabaseIfNotExist
Cria o banco de dados se ele não existir.

DropCreateDatabaseAlways
Apaga o banco de dados e o recria sempre que o projeto é executado fazendo perder todos os dados

DropCreateDatabaseModelChanges
Apaga o seu banco de dados e o recria sempre que identificar uma alteração no seu modelo de classes. Também perde os dados

