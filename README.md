# DIO - Trilha .NET - Fundamentos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Resolução do Desafio

 Para resolver este desafio, tive que implementar 03 métodos da classe Estacionamento.
São eles: **Adicionar Veículo** - Neste método, quando chamado pelo usuário, se houver vagas, o usuário poderá inserir a placa do veículo, e, caso a placa não seja válida (Não estiver no formato correto), irá aparecer uma mensagem informando que a placa está inválida e pedirá para inserir outra placa. Caso a placa estiver de acordo com o padrão, o usuário sai do laço de repetição e retorna ao menu.
 **Remover Veículo** - Ao chamar este método, ele irá verificar se a lista de veículos estacionados não está vazia, se houver, irá retornar para o usuário que não há veículos estacionados e voltará para o menu, caso haja veículos estacionados, pedirá ao usuário que informe a placa a ser retirada, após isto, fará uma segunda verificação: caso a placa inserida tenha correspondência na lista de veículos estacionados, então irá perguntar ao usuário as horas que o veículo ficou estacionado e irá remover a placa da lista veículos, caso a placa inserida não tiver uma correspondencia com a placa dos veículos estacionados, irá retornar a mensagem de que o veículo não está estacionado e dirá para verificar se inseriu a placa corretamente.
 **Listar Veículos** - Irá, primeiramente, verificar se há veículos no estacionamento, caso haja, irá percorrer a lista e irá imprimir a placa de cada veículo na lista veículos, caso não haja, irá retornar para o usuário que não há veículos estacionados.

**_Implementações bonus: Validador de placas de veículos no padrão Mercosul e no padrão Antigo utilizando Regular Expressions (Regex); Inserir as vagas disponíveis no estacionamento (total de vagas) ; Utilização de conceitos de POO._**

##Extra

 **Explicando o Regex:**
 - Foi criada uma classe chamada RegexPlaca, que tem IRegexPlaca como Interface (Interface: Classe abstrata que irá definir os métodos a serem implementados obrigatoriamente pela classe que irá herdar a mesma, como se fosse uma regra). Nesta classe, está implementado o método booleano VerificarPlaca, que irá receber uma string placa. Caso a placa não esteja em branco (vazia) e tenha o tamanho correto (7 dígitos), o código irá verificar se o quarto dígito da placa é uma letra, se for, irá verificar com o padrão do Mercosul (3 letras, 1 número, 1 letra e 2 números, Ex: aaa0a00), caso seja número, irá verificar com o padrão antigo (3 letras e 4 números, Ex: aaa-0000). Caso a placa inserida esteja de acordo com estas normas, terá o retorno True, caso não passe por alguma restrição destas acima, retornará False.