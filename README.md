# Objetivo
    Desenvolver um micro-serviço, que envie uma mensagem de Hello World a cada 5 segundos. 

# Regras
    Essa mensagem deve conter, além da mensagem de Hello World, um identificador do micro serviço, o timestamp que foi enviado e um identificador de requisição aleatório. 
    Além disso, esse serviço deve ser capaz de ler mensagens enviadas por outros micro-serviços, mostrando na tela esses dados. 
    É obrigatório o uso de algum sistema de mensagens (AMQP, kafka, JMS, etc.). 
# Resultado esperado
    Rodar pelo menos duas instâncias do serviço desenvolvido e ver a comunicação entre eles.


# Tecnologias utilizadas
    rabbitmq
    mysql
    mongo
    docker

# Executar ambiente 
  /docker/docker-compose.yml

# Visualização Containners usando a ferramenta
    https://www.portainer.io/  
