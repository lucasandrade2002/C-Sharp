using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

/*Desenvolva um algoritmo que solicite a entrada do nome, email, telefone e rg de um determinado usuário
e grave em um arquivo de texto. Exiba as informações na tela a partir do arquivo de texto gerado*/

namespace exercicio_08{
    
    public class Pessoa{
        private string nome;
        private string email;
        private long telefone;
        private long RG;

        public string name{
            get{
                return this.nome;
            }
            set{
                this.nome = value;
            }
        }

        public string mail{
            get{
                return this.email;
            }
            set{
                this.email = value;
            }
        }

        public long phone{
            get{
                return this.telefone;
            }
            set{
                this.telefone = value;
            }
        }

        public long rg{
            get{
                return this.RG;
            }
            set{
                this.RG = value;
            }
        }

        public void info(){
            Console.Write("\n----Informações----\n");
            Console.Write("\nNome: {0} \nE-mail: {1} \nPhone: {2} \nRG: {3}\n", this.nome, this.email, this.telefone, this.RG); 
        }
    }

    public class Program{
        static void Main(){

            Pessoa[] p = new Pessoa[5];
            int escolha = 1;
            int i = 0, counter = 0;
            
            Console.Write("Bem-vindo(a) ao sistema de cadastro em arquivo!\n");

            do{
                
                p[i] = new Pessoa();

                Console.Write("\nInforme seu nome: ");
                p[i].name = Console.ReadLine();
                Console.Write("Informe seu e-mail: ");
                p[i].mail = Console.ReadLine();
                Console.Write("Informe seu telefone: ");
                try{
                    p[i].phone = long.Parse(Console.ReadLine());
                }catch{
                    throw new Exception("Os dados inseridos no campo telefone devem ser do tipo inteiro e\n não podem conter espaços ou caracteres especiais!");
                }
                Console.Write("Informe seu RG: ");
                try{
                    p[i].rg = long.Parse(Console.ReadLine());
                }catch{
                    throw new Exception("Os dados inseridos no campo RG devem ser do tipo inteiro e\n não podem conter espaços ou caracteres especiais!");
                }
                i++;
                counter++;

                Console.Write("\nDeseja adicionar mais um usuário? [1-Sim/2-Não] ");
                escolha = Convert.ToInt32(Console.ReadLine());

            }while(escolha != 2 && i < 5);

            Console.Clear();

            StreamWriter sw = new StreamWriter("arquivo.txt", true);

            for(i = 0; i < counter; i++){
                sw.Write("Nome: {0}", p[i].name);
                sw.Write("\nEmail: {0}", p[i].mail);
                sw.Write("\nTelefone: {0}", p[i].phone);
                sw.Write("\nRG: {0}", p[i].rg);
                sw.Write("\n----------------------\n\n");
            }

            sw.Close();

            /* Impressão do conteúdo que está no arquivo */

            StreamReader sr = new StreamReader("arquivo.txt");

            while(!sr.EndOfStream){
                Console.Write("{0}\n", sr.ReadLine());
            }
        }
    }
}