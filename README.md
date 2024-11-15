# 💼 Projeto Guiado - Desenvolver Estruturas de Ramificação Condicional e Loop em C# 

> Projeto Guiado desenolvido no roteiro de aprendizagem "Introdução ao C#, Parte 3" , sendo parte dos módulos necessários para a Certificação em Fundamentos do C# fornecido pela Microsoft. 


## :dart: Objetivo 

Obter experiência no desenvolvimento de um aplicativo de console que implemente instruções de seleção e iteração para obter especificações de aplicativo no qual deverá:

- Adicionar dados de exemplo pré-definidos à matriz de animais de estimação
- Fazer a iteração de um bloco de código "opções de menu e seleção do usuário" para estabelecer o loop externo do aplicativo.
- Implementar branches de código correspondentes às seleções de menu do usuário.
- Exibir todas as informações contidas na matriz que é usada para armazenar os dados dos animais de estimação (com base na seleção de menu do usuário).
- Fazer a iteração de um bloco de código "adicionar informações sobre os animais" que permite que o usuário adicione um ou mais animais novos à matriz de animais de estimação (com base na seleção de menu do usuário).

## :bookmark_tabs:	 Descrição do Projeto

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
    
- Verificar se os dados de idade e descrição física dos animais estão completos. Isso pode exigir o exame de um veterinário.

- Verificar se os dados de apelido e descrição da personalidade dos animais estão completos (isso pode exigir que a equipe conheça melhor o animal de estimação).

- Alterar a idade do animal (se a data de nascimento dele for conhecida e ele fizer aniversário enquanto estiver sob nossos cuidados).

- Alterar a descrição de personalidade do animal (ele pode mudar de comportamento após algum tempo sob nossos cuidados).

- Exibir todos os gatos que atendem às características físicas especificadas pelo usuário.

- Exibir todos os cães que atendem às características físicas especificadas pelo usuário.

Uma versão inicial do aplicativo já foi concluída. O projeto de código inicial deste módulo de projeto guiado inclui um arquivo Program.cs, que fornece os seguintes recursos de código:

- O código declara variáveis usadas para coletar e processar dados de animais de estimação e seleções de itens de menu.

- O código declara a matriz ourAnimals.

- O código usa um loop for em torno de um constructo if-elseif-else para preencher a matriz ourAnimals com um conjunto de dados de exemplo.

- O código exibe as seguintes opções principais de menu para seleção pelo usuário:
    1. Listar todas as nossas informações atuais sobre os animais de estimação.
    1. Atribuir valores aos campos da matriz ourAnimals.
    1. Verificar se os dados de idade e descrição física dos animais estão completos.
    1. Verificar se os dados de apelido e descrição de personalidade dos animais estão completos.
    1. Editar a idade do animal.
    1. Editar a descrição de personalidade do animal.
    1. Exibir todos os gatos com uma característica especificada.
    1. Exibir todos os cães com uma característica especificada.
    
- Insira o item de menu desejado ou digite "Exit" para sair do programa

- O código lê o item de menu selecionado pelo usuário e exibe uma mensagem ecoando a seleção.

A meta é desenvolver os recursos que implementam as duas primeiras opções de menu. Para cumprir essa meta, deverá concluir as seguintes tarefas:

- Atualizar o código usado para criar os dados de exemplo do aplicativo.
- Construir um loop ao redor do menu principal e criar uma instrução de seleção que estabeleça um branch de código para cada opção de menu.
- Escrever o código para exibir todos os dados da matriz ourAnimals (opção 1 do menu).
- Criar um loop para inserir novos dados na matriz ourAnimals (opção 2 do menu – parte 1).
- Escrever código para ler e salvar novos dados na matriz ourAnimals (opção 2 do menu – parte 2).

## 🔰 Referências

:computer: Descrição do Projeto: [Prepare-se para o projeto guiado: Desenvolver ramificação condicional e loop](https://learn.microsoft.com/pt-br/training/modules/guided-project-develop-conditional-branching-looping/2-prepare)

📁 Código Starter disponibilizado pela MS: [Arquivos de Laboratório](https://github.com/MicrosoftLearning/Guided-project-branching-looping-CSharp/archive/refs/heads/main.zip)


