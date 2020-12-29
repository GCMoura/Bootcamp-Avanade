## Aula 2

- Business inteligence

É um ecossitema que fornece ferramentas para tomar decisões estratégicas de negócio.
Composto por:
Ferramentas - Infraestrutura (servidores, rede, etc) - Profissionais - Dados

Os dados da operação vem do Banco de Dados.
Mas podem ser complementados por: Dados gerenciais; Pesquisas de campo; Indicadores de mercado

BI - solution:
Infraestrutura - Gerenciamento de dados - Analytics - Compartilhamento - Ferramentas gerais. 


- Data Warehouse

É uma estratégia de modelagem de dados de forma que os dados sejam eficientes e satisfatório para o uso em BI.

OLTP x OLAP

OLTP - On-Line Transaction Processing : transações ponto a ponto dentro do sistema (CRUD)
Foco: nivel operacional
Dados: modelo relacional
Armazenamento: banco de dados convencionais
Usa - SELECT/UPDATE/INSERT

OLAP - On-Line Analytical Processing : consolidação dos dados para relatórios e gerenciamento de dados
Foco: nivel estratégico
Dados: modelagem dimensional
Armazenamento: DAta Warehouse
Usa: SELECT/UPDATE/INSERT/SUM/AVG/MIN/MAX/MED/GROUP BY

Data Warehouse:

Consulta SQL para OLTP
OLAP ou DW - banco relacional ou NoSQL

- Big Data

É um termo que descreve um grande volume de dados, tanto estruturados quanto não-estruturados.
Formatos diversos de informações onde podemos tirar algum tipo de conhecimento.

Dados estruturados:

Dados estruturados em colunas e linhas. Mudar alguma coluna muda a estrutura.

Dados semi-estruturados:

Exemplos: XML - OWL - JSON - RDF

Mudar a informação não modifica a estrutura. A estrutura é básica.

NoSQL - Banco de dados que se comportam como banco  de dados estruturados, mas dão mais flexibilidade de inserir dados sem uma regra muito específica.

Dados não estruturados

Apenas uma grande coleção de dados estruturados ou semi estruturados


- Data Lake vs Big Data

Data Lake - um grande conjunto de informações.
É um lago de dados - um big data mais corporativo.
Precisa de um sistema de data curation e transformation