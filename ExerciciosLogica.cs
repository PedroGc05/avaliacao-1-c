// Exercício 1: Validador de Senhas Fortes
using System;
using System.Text.RegularExpressions;

class Exercicio1 {
    public static void Executar() {
        Console.Write("Digite uma senha: ");
        string senha = Console.ReadLine();

        bool tamanho = senha.Length >= 8;
        bool maiuscula = Regex.IsMatch(senha, "[A-Z]");
        bool numero = Regex.IsMatch(senha, "[0-9]");
        bool especial = Regex.IsMatch(senha, "[!@#\$%\^&\*]");

        if (tamanho && maiuscula && numero && especial)
            Console.WriteLine("Senha forte.");
        else
            Console.WriteLine("Senha fraca.");
    }
}

// Exercício 2: Tabuada Completa com Laço
class Exercicio2 {
    public static void Executar() {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++) {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}

// Exercício 3: Cálculo de Fatorial com while
class Exercicio3 {
    public static void Executar() {
        Console.Write("Digite um número inteiro positivo: ");
        int n = int.Parse(Console.ReadLine());
        int fatorial = 1;
        while (n > 1) {
            fatorial *= n;
            n--;
        }
        Console.WriteLine("Fatorial: " + fatorial);
    }
}

// Exercício 4: Conversor de Temperaturas com Menu
class Exercicio4 {
    public static void Executar() {
        int opcao;
        do {
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao) {
                case 1:
                    Console.Write("Temperatura em Celsius: ");
                    double c = double.Parse(Console.ReadLine());
                    Console.WriteLine("Fahrenheit: " + (c * 9 / 5 + 32));
                    break;
                case 2:
                    Console.Write("Temperatura em Fahrenheit: ");
                    double f = double.Parse(Console.ReadLine());
                    Console.WriteLine("Celsius: " + ((f - 32) * 5 / 9));
                    break;
            }
        } while (opcao != 3);
    }
}

// Exercício 5: Verificador de Palíndromos
class Exercicio5 {
    public static void Executar() {
        Console.Write("Digite uma palavra ou frase: ");
        string texto = Console.ReadLine().ToLower().Replace(" ", "");
        char[] array = texto.ToCharArray();
        Array.Reverse(array);
        string invertido = new string(array);
        Console.WriteLine(texto == invertido ? "É um palíndromo." : "Não é um palíndromo.");
    }
}

// Exercício 6: Cadastro Simples de Produtos
class Produto {
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }
}

class Exercicio6 {
    public static void Executar() {
        Produto[] produtos = new Produto[3];
        for (int i = 0; i < 3; i++) {
            produtos[i] = new Produto();
            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produtos[i].Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            produtos[i].Quantidade = int.Parse(Console.ReadLine());
        }

        foreach (Produto p in produtos) {
            double total = p.Preco * p.Quantidade;
            Console.WriteLine($"{p.Nome} - Total em estoque: R$ {total:F2}");
        }
    }
}

// Exercício 7: Soma de Números Pares de um Array
class Exercicio7 {
    public static void Executar() {
        int[] numeros = new int[10];
        int soma = 0;
        for (int i = 0; i < 10; i++) {
            Console.Write($"Digite o número {i+1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
            if (numeros[i] % 2 == 0) soma += numeros[i];
        }
        Console.WriteLine("Soma dos pares: " + soma);
    }
}

// Exercício 8: Cálculo de IMC com Classificação
class Exercicio8 {
    public static void Executar() {
        Console.Write("Peso (kg): ");
        double peso = double.Parse(Console.ReadLine());
        Console.Write("Altura (m): ");
        double altura = double.Parse(Console.ReadLine());
        double imc = peso / (altura * altura);
        Console.WriteLine("IMC: " + imc.ToString("F2"));
        if (imc < 18.5) Console.WriteLine("Abaixo do peso");
        else if (imc < 25) Console.WriteLine("Peso normal");
        else if (imc < 30) Console.WriteLine("Sobrepeso");
        else Console.WriteLine("Obesidade");
    }
}

// Exercício 9: Jogo da Adivinhação
class Exercicio9 {
    public static void Executar() {
        Random rnd = new Random();
        int numero = rnd.Next(1, 101);
        int tentativa, tentativas = 0;
        do {
            Console.Write("Tente adivinhar o número (1-100): ");
            tentativa = int.Parse(Console.ReadLine());
            tentativas++;
            if (tentativa < numero) Console.WriteLine("Muito baixo.");
            else if (tentativa > numero) Console.WriteLine("Muito alto.");
        } while (tentativa != numero);
        Console.WriteLine($"Parabéns! Tentativas: {tentativas}");
    }
}

// Exercício 10: Lista de Tarefas
using System.Collections.Generic;

class Exercicio10 {
    public static void Executar() {
        List<string> tarefas = new List<string>();
        string entrada;
        do {
            Console.Write("Digite uma tarefa (ou 'sair' para finalizar): ");
            entrada = Console.ReadLine();
            if (entrada.ToLower() != "sair") tarefas.Add(entrada);
        } while (entrada.ToLower() != "sair");

        Console.WriteLine("\nTarefas inseridas:");
        foreach (string t in tarefas) Console.WriteLine("- " + t);
    }
}

// Programa Principal
class Program {
    static void Main(string[] args) {
        // Chamar os exercícios individualmente conforme necessário:
        // Exemplo:
        // Exercicio1.Executar();
    }
}
