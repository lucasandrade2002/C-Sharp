/* Elabore um algoritmo para cadastro de dez pessoas, contendo as seguintes informações:
nome | idade | altura | peso. O menu deve apresentar as seguintes opções: I-Cadastrar os dez registros
II-Ordenar os registros por idade III-Apresentar a média de peso das pessoas IV-Apresentar
o nome das pessoas com peso acima de 50Kg V-Sair do programa */

using System;

public struct Pessoa{
    public string nome;
    public int idade;
    public double altura;
    public double peso;

}

public class Program{

    static int qtde = 0;

    static void Main(){

        int option;
        int i;
        Pessoa[] registros = new Pessoa[10];
        char continuar;

        Console.Write("Bem-vindo(a) ao sistema de cadastro de pessoas! ");
        cad_pessoas:
        Console.Write("Informe sua escolha: \n\nI-Cadastrar os dez registros \nII-Ordenar os registros por idade \nIII-Apresentar a média de peso das pessoas \nIV-Apresentar o nome das pessoas com peso acima de 50Kg \nV-Sair do programa\n");
        option = Convert.ToInt32(Console.ReadLine());

        switch(option){
            case 1:
                Console.Clear();
                Console.Write("Quantas pessoas deseja cadastrar? [Máximo de 10 pessoas] ");
                qtde = Convert.ToInt32(Console.ReadLine());
                for(i = 0; i < qtde; i += 1){
                    Console.Write("\nInforme o nome da pessoa {0}: ", i+1);
                    registros[i].nome = Console.ReadLine();
                    Console.Write("Informe a idade da pessoa {0}: ", i+1);
                    registros[i].idade = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Informe a altura da pessoa {0}: ", i+1);
                    registros[i].altura = double.Parse(Console.ReadLine());
                    Console.Write("Informe o peso da pessoa {0}: ", i+1);
                    registros[i].peso = double.Parse(Console.ReadLine());
                    Console.Clear();
                }
                    Console.Write("Deseja efetuar outra operação?[S/N] ");
                    continuar = char.Parse(Console.ReadLine());
                    Console.Clear();
                    if(continuar == 'S' || continuar == 's') goto cad_pessoas;
                    else Console.Write("Ok. Até a próxima!");
                break;
            case 2:
                Console.Clear();
                ordenaPorIdade(registros);
                Console.Write("Registros ordenados por idade :)\n");
                Console.Write("\nDeseja efetuar outra operação?[S/N] ");
                continuar = char.Parse(Console.ReadLine());
                Console.Clear();
                if(continuar == 'S' || continuar == 's') goto cad_pessoas;
                else Console.Write("Ok. Até a próxima!");
                break;
            case 3:
                Console.Clear();
                apresentaMediaDePeso(registros);
                Console.Write("\nDeseja efetuar outra operação?[S/N] ");
                continuar = char.Parse(Console.ReadLine());
                Console.Clear();
                if(continuar == 'S' || continuar == 's') goto cad_pessoas;
                else Console.Write("Ok. Até a próxima!");
                break;
            case 4:
                apresentaPessoasComPesoAcimaDe50(registros);
                Console.Write("\nDeseja efetuar outra operação?[S/N] ");
                continuar = char.Parse(Console.ReadLine());
                Console.Clear();
                if(continuar == 'S' || continuar == 's') goto cad_pessoas;
                else Console.Write("Ok. Até a próxima!");
                break;
            case 5:
                Console.Write("\nAté a próxima!");
                break;
            default:
                Console.Write("Opção Inválida!\n");
                goto cad_pessoas;
                break;
        }
    }

    public static void ordenaPorIdade(Pessoa[] registros){
        int i,j;
        Pessoa troca;
        for(i = 0; i < (registros.Length-1); i++){
            for(j = i+1; j < registros.Length; j++){
                if(registros[i].idade > registros[j].idade){
                    troca = registros[j];
                    registros[j] = registros[i];
                    registros[i] = troca;
                }
            }
        }
    }

    public static void apresentaMediaDePeso(Pessoa[] registros){
        int i=0;
        double media = 0;

        while(i < qtde){
            media += registros[i].peso;
            i++;
        }
        Console.Write("A média de peso das pessoas cadastradas é de: {0}\n", media/qtde);
    }

    public static void apresentaPessoasComPesoAcimaDe50(Pessoa[] registros){
        int i;

        for(i = 0; i < qtde; i++){
            if(registros[i].peso > 50){
                Console.Write("\nNome: {0} \nPeso: {1}Kg", registros[i].nome, registros[i].peso);
                Console.Write("\n---------");
            }
        }
    }
}