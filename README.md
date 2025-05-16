# Trabalho Prático – Lógica de Programação em C\#

## Integrante do Grupo

* Pedro Guilherme Campos - UP OSÓRIO - SEX/NOITE

## Explicação dos 10 exercícios:

1. **Validador de Senhas Fortes**: Valida se a senha possui no mínimo 8 caracteres, pelo menos uma letra maiúscula, um número e um caractere especial.
2. **Tabuada Completa com Laço**: Exibe a tabuada completa (1 a 10) de um número informado pelo usuário.
3. **Cálculo de Fatorial com While**: Solicita um número e calcula seu fatorial usando laço `while`.
4. **Conversor de Temperaturas com Menu**: Um menu interativo permite conversão entre Celsius e Fahrenheit até que o usuário deseje sair.
5. **Verificador de Palíndromos**: Verifica se uma palavra ou frase é um palíndromo (lida igual de frente pra trás e vice-versa).
6. **Cadastro Simples de Produtos**: Permite o cadastro de 3 produtos e calcula o valor total em estoque de cada um.
7. **Soma de Números Pares de um Array**: Lê 10 números, armazena em um array e calcula a soma dos pares.
8. **Cálculo de IMC com Classificação**: Solicita peso e altura, calcula o IMC e informa a classificação.
9. **Jogo da Adivinhação**: Gera um número aleatório e permite que o usuário tente adivinhar com dicas.
10. **Lista de Tarefas (To-Do List)**: Permite adicionar tarefas a uma lista e exibir todas ao final.

---

## Exercícios com Explicação Detalhada

### Exercício 3 - Cálculo de Fatorial com While

**Passo a passo:**

1. Solicita ao usuário um número inteiro positivo.
2. Inicializa uma variável `fatorial` com o valor 1.
3. Utiliza um laço `while` que continua enquanto `n > 1`, multiplicando `fatorial` por `n` e decrementando `n`.
4. Exibe o resultado ao final.

**Estruturas utilizadas:**

* `int.Parse` para converter entrada textual em número.
* Laço `while` para repetir multiplicações sucessivas.

**Justificativas:**
O laço `while` é adequado aqui porque o número de repetições depende do valor de entrada, e precisamos fazer a repetição até que o número chegue a 1.

---

### Exercício 7 - Soma de Números Pares de um Array

**Passo a passo:**

1. Cria um array de 10 posições.
2. Usa um laço `for` para solicitar 10 números ao usuário.
3. Armazena cada número no array e verifica se é par (`numero % 2 == 0`).
4. Se for par, soma ao total.
5. Exibe a soma ao final.

**Estruturas utilizadas:**

* Array `int[]` para armazenar os números.
* Laço `for` para leitura e verificação.
* Condicional `if` para checar se o número é par.

**Justificativas:**
O uso de arrays permite armazenar múltiplos valores de forma organizada, e o `for` é ideal para iterar um número fixo de vezes. A verificação de paridade é simples e eficiente usando o operador `%`.

---

## Instruções de Uso

Para executar um exercício individualmente, descomente a chamada do exercício desejado no `Main()` no arquivo `.cs`.
