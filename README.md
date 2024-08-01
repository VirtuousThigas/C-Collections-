Lista – Coleções 


Lista (Classe List) 

1) Considere que um corredor profissional precisa de um programa para gerenciar os tempos (em horas - double) das maratonas que ele participou.  O programa deve apresentar o seguinte menu para o usuário: 
Menu: 
1)Inserir um tempo no início da lista 
2)Inserir um tempo no final da lista 
3)Inserir um tempo numa posição específica da lista 
4)Remover o primeiro tempo da lista 
5)Remover o último tempo da lista (Imprimir o tempo removido) 
6)Remover um tempo de uma posição específica na lista (O usuário deve informar a posição do tempo a ser removido. Imprimir o tempo removido) 
7)Remover um tempo específico da lista (O usuário deve informar o tempo a ser removido) 
8)Pesquisar quantas vezes um determinado tempo consta na lista (O usuário deve informar o tempo a ser 	pesquisado) 
9)Mostrar todos os tempos da lista 
10)Mostrar todos os tempos da lista em ordem crescente 
11)Mostrar todos os tempos da lista em ordem decrescente 
12)Encerrar o programa 
O programa deverá ler a opção informada pelo usuário e executar a operação selecionada. Em seguida o programa deverá apresentar novamente o menu, depois ler e executar a operação selecionada. Esse processo deverá ser repetido até que o usuário digite a opção de encerrar o programa. 


Pilha

2) Na notação tradicional de expressões aritméticas pode-se usar parênteses para eliminar ambiguidade 
Exemplo: 
A + B * C 
A + (B * C) 
(A+B) * C 
A notação polonesa reversa, dispensa o uso de parênteses. Nessa notação os operadores aparecem após os operandos. Ela é utilizada em vários equipamentos eletrônicos, como calculadores e computadores. 
Exemplo: 
Notação tradicional: A * B – C/D 
Notação polonesa reversa: A B * C D / - 
Notação tradicional: A * ((B-C)/D) 
Notação polonesa reversa: A B C – D / * 

Faça um programa que leia uma expressão matemática no formato da notação polonesa reversa, e imprima o 
resultado da expressão. Utilize a estrutura de dados pilha. Considere que a expressão poderá ter apenas as operações básicas: soma, subtração, multiplicação e divisão. 

3) Escreva um programa que leia uma sequência (string) de parênteses e colchetes e verifique se essa sequência está bem-formada, ou seja, se os parênteses e colchetes são fechados na ordem inversa àquela em que foram abertos. Utilize uma pilha para auxiliar nessa verificação. 
Exemplos: 
	•	( ( ) [ ( ) ] ) a sequência está bem-formada 
	•	( [ ) ]   a sequência está malformada
Dica: os abre parênteses e abre colchetes devem ser empilhados. Quando vier um fecha parênteses deve ser desempilhado um caractere da pilha. 


Fila 

4) Escreva um programa que simule o controle de uma pista de decolagem de aviões em um aeroporto. Neste programa, o usuário deve ser capaz de realizar as seguintes tarefas: 
	1.Listar a quantidade de aviões que estão aguardando na fila de decolagem 
	2.Autorizar a decolagem do primeiro avião da fila de decolagem (isto é, retirar da fila de colagem) 	3.Adicionar um avião na fila de colagem 
	4.Listar todos os aviões que estão na fila de colagem 
	5.Exibir o primeiro avião da fila de colagem 
	6.Sair 
Obs: A fila deve armazenar o identificador de cada avião (string).


Dicionário 

5) Faça um programa que leia uma frase e informe o número de ocorrências de cada palavra da frase. Use um dicionário para fazer essa contagem. Para simplificar considere que a frase não terá sinais de pontuação. Apenas faça o tratamento para letras minúsculas e maiúsculas. (Dica: o campo chave deve ser a palavra, e o campo valor deve ser o número de ocorrências da palavra). 


Lista (Classe LinkedList) 

6)Crie um programa que permita que um usuário gerencie sua lista de músicas (string). Para tanto, o programa deverá 	apresentar para o usuário um menu com as seguintes opções: 
	Menu: 
		1.Inserir uma música no final da lista 
		2.Inserir uma música no início da lista 
		3.Inserir uma música depois de outra 
		4.Remover a música do início da lista 
		5.Remover a música do final da lista 
		6.Remover uma música específica 
		7.Listar todas as músicas da lista 
		8.Pesquisar se uma música consta na lista 
		9.Encerrar o programa 
O programa deverá ler a opção informada pelo usuário e executar a operação selecionada. Em seguida o programa deverá apresentar novamente o menu para o usuário, ler e executar a operação selecionada. Esse processo deverá ser repetido até que o usuário digite a opção para encerrar o programa. 
