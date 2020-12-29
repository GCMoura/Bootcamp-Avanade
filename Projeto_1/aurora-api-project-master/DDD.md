## DDD
Domain Driven Design

É uma abordagem de design de software disciplinada que reúne um conjunto de conceitos, técnicas e princípio para construção de softwares baseados em um modelo de domínio.

Conceitos:
Alinhamento do código com o negócio - faz uso de uma linguagem úbiqua (comum entre todos) para descrever o domínio e suas regras;
Favorecer a reutilização;
Mínimo de acoplamento - mínima dependência entre módulos ou classes de objetos de conceitos distintos;
Independencia da tecnologia - DDD não foca em tecnologia, mas sim em entender as regras do negócio e como elas devem estar refletidas no código e no modelo de domínio.

## Modelo de domínio (MDD)

O modelo abstrato deve ser uma representação perfeita do seu domínio. Tudo o que existe no seu negócio deve aperecer no modelo.

Blocos de construção do MDD

Interface do usuário - exibe as informações do sistema ao usuário
Aplicação - responsável por conectar a  interface do usuário às camadas inferiores
Domínio - Conceitos, regras e lógicas do negócio. O foco do DDD está nessa camada.
Infra-estrutura - fornece recursos técnicos que darão suporte às camadas superiores.

Regras para modelagem do domínio:
Entidades - classes de objetos que necessitam de uma identidade;
Objetos de valores - objetos que só carregam valores, mas que não possuem distinção de identidade;
Agregados - Composto de entidades ou objetos de valores que são encapsulados numa única classe. Deve manter a integridade do modelo.
Fábricas - classes responsávei pelo processo de criação dos agregados ou dos objetos de valores;
Serviços - classes que contem lógica de negócio, mas que não pertence a nenhuma entidade ou objeto de valores. Serviço não guardam estado;
Repositório - classes responsáveis por administrar o ciclo de vida dos outros objetos normalmente entidades, objetos de valores e agregados;
Módulos - abstrações que tem por objeto agrupar classes por um determinado conceito de domínio.
