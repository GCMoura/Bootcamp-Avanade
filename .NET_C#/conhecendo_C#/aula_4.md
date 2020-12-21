## Classes e Objetos

Tipo mais fundamental. É uma estrutura de dados que combina estado (campos) e ações (métodos)

Objetos são instâncias de uma classe.
As classes suportam herança e polimorfismo, mecanismos pelos quais as classes derivadas podem estender e especializar as classes base.

O operador new aloca memória para uma nova instância, chama um construtor para inicializar a instância e retorna uma referência à instância.

Membros estáticos pertecem a classe e membros de instância pertecem ao objeto

### Acessibilidade:

public - qualquer parte do código pode acessar
protected - apenas as classes que herdam da base acessam
internal - só é acessado pelo próprio assembly
private - acessado dentro da classe em que está contido.

# Herança - herda os membros public, internal e protected
 
Omitir uma especificação de classe base é o mesmo que derivar do tipo object

# Método é um membro que implementa uma computação ou ação que pode ser executada por um objeto ou classe.
Podem ter uma lista de parâmetros, que representam valores ou referências de variáveis passados para o método, e um tipo de retorno.

## virtual - permite que uma classe filha sobrescreva.
override faz essa sobrescrição do método