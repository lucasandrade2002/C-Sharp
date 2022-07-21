using System;

/*Desenvolva um cadastro de produtos que contenha código, descrição, unidade e preço para 20 produtos.
Defina um menu com as seguintes opções: I-Cadastrar os 20 registros | II-Pesquisar um produto pelo código | 
III-Classificar por ordem de descrição os registros cadastrados | IV-Classificar por ordem de código | V-Apresentar todos os registros | VI-Sair do programa*/

public struct cadastro{
    public string codigo;
    public string descricao;
    public int unidade;
    public double preco;
}

public class Program{
    static void Main(){
        cadastro[] produto = new cadastro[20];
        cadastro auxiliar;
        int option, qtde = 0, i, j, count = 0;

        Console.Write("\nBem-vindo(a) ao sistema de cadastro de produtos! ");
        
        cad_produtos:
        Console.Write("Informe sua escolha: \n\n1-Cadastrar produto \n2-Pesquisar pelo código \n3-Classificar por ordem de descrição \n4-Classificar por ordem de código \n5-Apresentar todos os registros \n6-Sair do programa\n");
        option = Convert.ToInt32(Console.ReadLine());

        switch(option){
            case 1:
                Console.Clear();
                Console.Write("Quantos produtos deseja cadastrar? ");
                qtde = Convert.ToInt32(Console.ReadLine());
                for(i = 0; i < qtde; i++){
                    Console.Write("\nProdutos cadastrados: {0}\n", count);
                    Console.Write("\nInforme o código do produto: ");
                    produto[i].codigo = Console.ReadLine();
                    Console.Write("Descrição do produto: ");
                    produto[i].descricao = Console.ReadLine();
                    Console.Write("Unidade do produto: ");
                    produto[i].unidade = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Preço do produto: "); 
                    produto[i].preco = float.Parse(Console.ReadLine());
                    count++;
                    Console.Clear();
                }
                goto cad_produtos;
                break;
            case 2:
                string cod;
                bool achou = false;
                Console.Clear();
                Console.Write("Informe o código do produto desejado: ");
                cod = Console.ReadLine();
                for(i = 0; i < produto.Length; i++){
                    if(cod == produto[i].codigo){
                        achou = true;
                        Console.Write("\nDescrição Produto: {0} \nPreço Produto: {1}\n\n", produto[i].descricao, produto[i].preco);
                    }
                }
                if(!achou){
                        Console.Write("O código não foi encontrado!");
                    }
                goto cad_produtos;
                break;
            case 3:
                Console.Clear();
                for(i = 0; i < (qtde - 1); i++){
                    for(j = i+1; i < qtde; i++){
                        if(produto[j].descricao.Length < produto[i].descricao.Length){
                            auxiliar = produto[j];
                            produto[j] = produto[i];
                            produto[i] = auxiliar;
                        }
                    }
                }
                Console.Write("\nProdutos ordenados de acordo com a descrição!\n\n");
                goto cad_produtos;
                break;
            case 4:
                Console.Clear();
                for(i = 0; i < (qtde - 1); i++){
                    for(j = i+1; j < qtde; j++){
                        if(produto[j].codigo.Length < produto[i].codigo.Length){
                            auxiliar = produto[j];
                            produto[j] = produto[i];
                            produto[i] = auxiliar;
                        }
                    }
                }
                Console.Write("\nProdutos ordenados de acordo com o código!\n\n");
                goto cad_produtos;
                break;
            case 5:
                Console.Clear();
                i = 0;
                Console.Write("Quantos produtos você cadastrou? ");
                qtde = Convert.ToInt32(Console.ReadLine());
                while(i < qtde){
                    Console.Write("\nProduto {0}\n", i+1);
                    Console.Write("Código: {0} \nDescrição: {1} \nUnidade: {2} \nPreço: R${3}", produto[i].codigo, produto[i].descricao, produto[i].unidade, produto[i].preco);
                    Console.Write("\n--------------------------------\n");
                    i++;
                }
                break;
            case 6:
                Console.Clear();
                Console.Write("Ok, até a próxima!");
                break;
            default:
                Console.Write("\nOpção Inválida!\n\n");
                goto cad_produtos;
        }
    }
}