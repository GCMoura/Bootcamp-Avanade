## Aula 1

Arquitetura mensageria

Prós:
Desacoplamento - Facil Pug & Play - Comunicação assíncrona
Simples escalabilidade - Broadcasting - Permite Event Source

Contras:
Single point of failure - dificil monitoramente

web API -> HTTTP -> serviço 1 -> message broker

- Gerenciamento de erros

Dead letter queue (filas de re-tentativas) - guarda as mensagens de erro pem uma lista de re-tentativas
Monitoramento entre serviços - rastrear os pontos de erro.
Rastreamento de fluxo - coletar os serviços e indexar em um único lugar organizado




