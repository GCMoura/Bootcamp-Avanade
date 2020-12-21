## O que é C#?

Começou na década de 1990.
É uma linguagem orientada a objeto e fortemente tipada. É similar a C, C++ e Java.
Suporta conceitos de (OO), como encapsulamento, herança e polimorfismo.

CLR(Commom Languagem Runtime)
Conjunto unificado de bibliotecas de classes

Atualmente o compilador do C# é o Roslyn

## Como funciona?

O código fonte escrito em C# é compilado em uma linguagem intermediária (IL)
O código e os recursos de IL são armazenados no disco em um arquivo executável chamado Assembly, geralmente com uma extensão .DLL ou .EXE.

A DLL é o código compilado em uma linguagem intermediária.

Quando o programa C# é executado, o Assembly é carregado no CLR.
Em seguida o CLR executará a compilação Just In Time (JIT) para converter o código IL em instruções de máquinas nativas.

Outros serviços CLR:
Garbage Collector - ferramenta que trabalha coletando o lixo. Desaloca os objetos da memória que não estão sendo utilizados.
Exception Handler - Receber e controlar as exceções
Resources Manager - utiliza os recursos

Arquivo em C# - passa pelo Roslyn - que gera um DLL ou EXE - em tempo de compilação - linguagem de maquina

.NET tem várias bibliotecas.


