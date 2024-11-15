# 💼 Projeto  - Desenvolver Estruturas de Ramificação Condicional e Loop em C# 

> Projeto guiado e desafios de projetos desenolvidos no roteiro de aprendizagem "Introdução ao C#, Parte 3" , sendo parte dos módulos necessários para a Certificação em Fundamentos do C# fornecido pela Microsoft.


## :books: Projeto Guiado: Desenvolver ramificação condicional e loop em C#

> Objetivo de Aprendizagem:
>> Obter experiência no desenvolvimento de um aplicativo de console que implemente instruções de seleção e iteração para obter especificações de aplicativo no qual deverá:
>> - Adicionar dados de exemplo pré-definidos à matriz de animais de estimação
>> - Fazer a iteração de um bloco de código "opções de menu e seleção do usuário" para estabelecer o loop >externo do aplicativo.
>> - Implementar branches de código correspondentes às seleções de menu do usuário.
>> - Exibir todas as informações contidas na matriz que é usada para armazenar os dados dos animais de estimação (com base na seleção de menu do usuário).
>> - Fazer a iteração de um bloco de código "adicionar informações sobre os animais" que permite que o usuário adicione um ou mais animais novos à matriz de animais de estimação (com base na seleção de menu do usuário).

### 📑	 Especificações do Projeto

 Você está trabalhando no aplicativo Contoso Pets, um aplicativo que ajuda a colocar animais de estimação em novas casas. As especificações do aplicativo são as seguintes:
 
- Crie um aplicativo de console C#.
- Armazene dados do aplicativo em uma matriz de cadeia de caracteres multidimensional chamada ourAnimals.
- A matriz ourAnimals inclui as seguintes "características de animais de estimação" para cada animal:
    - Nº da ID do animal de estimação.
    - Espécie do animal de estimação (gato ou cachorro).
    - Idade do animal de estimação (em anos).
    - Descrição das condições/características físicas do animal de estimação.
    - Descrição da personalidade do animal de estimação.
    - Apelido do animal de estimação.

- Implemente um conjunto de dados de exemplo que represente os cães e gatos atualmente sob seus cuidados.

- Exiba opções de menu para acessar os principais recursos do aplicativo.

- Os principais recursos habilitam as seguintes tarefas:

    - Listar as informações de animais de estimação para todos os animais da matriz ourAnimals.

    - Adicionar novos animais à matriz ourAnimals. As seguintes condições se aplicam:

    - A espécie do animal de estimação (cão ou gato) deve ser informada quando um novo animal é adicionado à matriz ourAnimals.
    - Uma ID de animal de estimação deve ser gerada programaticamente quando um novo animal é adicionado à matriz ourAnimals.
    - Algumas características físicas do animal de estimação podem ser desconhecidas até o exame de um veterinário. Por exemplo: idade, raça e status de castração.
    - O apelido e a personalidade do animal de estimação podem ser desconhecidos logo que ele chega.
    
- Verificar se os dados de idade e descrição física dos animais estão completos. 

- Verificar se os dados de apelido e descrição da personalidade dos animais estão completos.

- Alterar a idade do animal.

- Alterar a descrição de personalidade do animal.

- Exibir todos os gatos que atendem às características físicas especificadas pelo usuário.

- Exibir todos os cães que atendem às características físicas especificadas pelo usuário.

### 🔰 Projeto Inicial

Uma versão inicial do aplicativo já foi concluída. O projeto de código inicial deste módulo de projeto guiado inclui um arquivo `Program.cs`, que fornece os seguintes recursos de código:

- O código declara variáveis usadas para coletar e processar dados de animais de estimação e seleções de itens de menu.

- O código declara a matriz `ourAnimals`.

- O código usa um loop for em torno de um constructo `if-elseif-else` para preencher a matriz `ourAnimals` com um conjunto de dados de exemplo.

- O código exibe as seguintes opções principais de menu para seleção pelo usuário:
    1. Listar todas as nossas informações atuais sobre os animais de estimação.
    1. Atribuir valores aos campos da matriz ourAnimals.
    1. Verificar se os dados de idade e descrição física dos animais estão completos.
    1. Verificar se os dados de apelido e descrição de personalidade dos animais estão completos.
    1. Editar a idade do animal.
    1. Editar a descrição de personalidade do animal.
    1. Exibir todos os gatos com uma característica especificada.
    1. Exibir todos os cães com uma característica especificada.
    
- Insira o item de menu desejado ou digite "`0`" para sair do programa

- O código lê o item de menu selecionado pelo usuário e exibe uma mensagem ecoando a seleção.

### 🎯 Objetivo

A meta é desenvolver os recursos que implementam as duas primeiras opções de menu. Para cumprir essa meta, deverá concluir as seguintes tarefas:

- Atualizar o código usado para criar os dados de exemplo do aplicativo.
- Construir um loop ao redor do menu principal e criar uma instrução de seleção que estabeleça um branch de código para cada opção de menu.
- Escrever o código para exibir todos os dados da matriz ourAnimals (opção 1 do menu).
- Criar um loop para inserir novos dados na matriz ourAnimals (opção 2 do menu – parte 1).
- Escrever código para ler e salvar novos dados na matriz ourAnimals (opção 2 do menu – parte 2).

---

## :books: Desafio de Projeto: Desenvolver ramificação condicional e loop em C#

> Objetivos de Aprendizagem:
>> - Utilizar o Visual Studio Code para desenvolver um aplicativo de console em C# que usa uma combinação de instruções de seleção e iteração para implementar fluxos de trabalho lógicos.
>> - Avaliar as condições subjacentes no aplicativo e tome uma decisão informada entre as opções de instrução de seleção.
>> - Avaliar as condições subjacentes no aplicativo e tome uma decisão informada entre as opções de instrução de iteração.
>> - Definir o escopo das variáveis para um nível apropriado dentro de um aplicativo.


### 🎯 Objetivo

- Utilizar o código desenvolvido no módulo anterior para implementar o aplicativo.

- Criar os recursos do aplicativo em alinhamento com as opções de menu 3 e 4.

Para garantir que as idades dos animais e as descrições físicas estejam completas, o código deve fazer o seguinte:

- Atribuir um valor numérico válido a petAge para qualquer animal que tenha dados atribuídos na matriz `ourAnimals`, mas não tenha uma idade atribuída.
- Atribuir uma cadeia de caracteres válida a `petPhysicalDescription` para qualquer animal que tenha dados atribuídos na matriz ourAnimals, mas não tenha recebido uma descrição física.
- Verificar se as descrições físicas têm um valor atribuído. Os valores atribuídos não podem ter zero caracteres. Qualquer outro requisito depende de você.

Para garantir que os apelidos dos animais e suas descrições de personalidade estejam preenchidos, o código deve fazer o seguinte:

- Atribuir uma cadeia de caracteres válida a `petNickname` para qualquer animal que tenha dados atribuídos na matriz `ourAnimals`, mas não tenha um apelido atribuído.
- Atribuir uma cadeia de caracteres válida a `petPersonalityDescription` para qualquer animal que tenha dados atribuídos na matriz `ourAnimals`, mas não tenha uma descrição de personalidade atribuída.
- Verificar se apelidos e descrições de personalidade têm um valor atribuído. Os valores atribuídos não podem ter zero caracteres. 


### :memo: Exercício - Garantir que `petAge` e `petPhysicalDescription` contenham informações válidas


Neste exercício de desafio, é necessário desenvolver um recurso que garanta que as idades dos animais e suas descrições físicas estejam preenchidas.

Esse recurso deve:

- Estar habilitado dentro da branch apropriada (não deve substituir o código na branch de código para a opção de menu 2).

- Ignorar qualquer animal na matriz `ourAnimals` quando o valor da ID do animal de estimação está definido como o valor padrão.

- Exibir o valor da ID do animal de estimação e solicite ao usuário um valor de dados atualizado caso os dados da matriz ourAnimals estejam ausentes ou incompletos.

- Verificar se há um valor numérico válido atribuído a animalAge para todos os animais na matriz ourAnimals com dados atribuídos.

- Verificar se há uma cadeia de caracteres válida atribuída a `animalPhysicalDescription` para todos os animais na matriz `ourAnimals` com dados atribuídos.

- Aplicar as seguintes regras de validação para `animalAge`.

    - Deve ser possível converter o valor inserido em um tipo de dados numérico.

- Aplicar as seguintes regras de validação para `animalPhysicalDescription`:
    - Os valores não podem ser nulos.
    - Os valores não podem ter zero caracteres.
    - Qualquer restrição adicional cabe ao desenvolvedor.

- Informar o usuário do aplicativo quando todos os requisitos de dados forem atendidos, pausando o aplicativo para garantir que a mensagem seja vista e respondida.

### :memo: Exercício - Garantir que `petNickname` e `petPersonalityDescription` contenham informações válidas

Desenvolver um recurso que garanta o preenchimento das descrições de personalidade e do apelido dos animais.

Esse recurso deve:

- Ser habilitado dentro do branch de aplicativo apropriado (não deve substituir o código no branch de código para a opção de menu 2).

- Ignorar qualquer animal na matriz `ourAnimals` quando o valor da ID do animal de estimação está definido como o valor padrão.

- Exibir o valor da ID do animal de estimação e solicitar ao usuário um valor de dados atualizado caso os dados da matriz `ourAnimals` estejam ausentes ou incompletos.

- Verificar se há uma cadeia de caracteres válida atribuída a `animalNickname` para todos os animais na matriz `ourAnimals` com dados atribuídos.

- Verificar se há uma cadeia de caracteres válida atribuída a `animalPersonalityDescription` para todos os animais na matriz `ourAnimals` com dados atribuídos.

- Aplicar as seguintes regras de validação para `petNickname` e `petPersonalityDescription`:

    - Os valores não podem ser nulos.
    - Os valores não podem ter zero caracteres.
    - Qualquer restrição adicional cabe ao desenvolvedor.

- Informe o usuário do aplicativo quando todos os requisitos de dados forem atendidos, pausando o aplicativo para garantir que a mensagem seja vista e respondida.
---

## :mag_right:	 Referências

:file_folder: Descrição do Projeto Guiado: [Desenvolver ramificação condicional e loop](https://learn.microsoft.com/pt-br/training/modules/guided-project-develop-conditional-branching-looping/2-prepare)

:file_folder: Descrição do Desafio de projeto: [Desenvolver ramificação condicional e loop](https://learn.microsoft.com/pt-br/training/modules/challenge-project-develop-branching-looping-structures-c-sharp/2-prepare)

:file_folder: Código Starter: [Arquivos de Laboratório MS](https://github.com/MicrosoftLearning/Guided-project-branching-looping-CSharp/archive/refs/heads/main.zip)


