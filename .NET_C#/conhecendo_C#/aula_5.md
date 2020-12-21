## Structs

São estruturas de dados e podem conter membros de dados e membros de ação, mas, diferente das classes, as structs são do tipo valor e não requerem alocação de heap.
Struct armazena diretamente os dados da estrutura, enquanto uma variável de um tipo de classe armazena uma referência a um objeto na memória.
Heap - faz parte da memória - guarda a referência na memória
Não aceitam herança.
São úteis para pequenas estruturas de dados que possuem semântica de valor: números complexos, sistema de coordenadas, chave-valor de um dicionário, etc;
Vantagem: faz menos alocação de memória.

Em vez de alocar dinamicamente um objeto no heap gerenciado e retornar uma referência a ele, um construtor struct simplesmente retorna o próprio valor.
normalmente em um local temporário na stack.

## Interfaces

É como um contrato que pode ser implementado por classes e structs. Pode conter métodos, propriedade, eventos e indexadores.
Não fornece implementação dos membros que define, apenas suas assinaturas.
Podem empregar herança múltipla.

## Enums

É um tipo de valor distinto com um conjunto de constantes nomeadas.
Usa quando precisa definir um tipo que pode ter um connunto de valores discretos.
Eles usam um dos tipos de valor integral como armazenamento subjacente. Fornecem significado semântico aos valores discretos.
Cada tipo de enum possui um tipo integral correspondente. Se não tiver é inteiro.
