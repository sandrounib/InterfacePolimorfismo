using System;
using ClasseInterface;

namespace ExemploInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            //*****uma maneira de passar dados
            Produto pr = new Produto(){
                Id = 30,
                Nome = "Sabão",
                Descricao="Em pó",
                Preco = 30                     

            };
            pr.Cadastro();
            System.Console.WriteLine(pr.Cadastro());
          
            
            /* 
             //******outra maneira
             Produto pr = new Produto();
             pr.Id= 30;
             pr.Nome ="Sabaõ"            ;
             pr.Descricao ="Em Pó";
             pr.Preco = 30;
             */
             
             Endereco endereco = new Endereco();
             endereco.Logradouro = "Rua Divina Comedia";
             endereco.Numero ="104 A";
             endereco.Bairro ="jardim Presidente";


             PF pf = new PF(10,"helena","232323","helena@bol.com.br","4546",endereco);
             System.Console.WriteLine(pf.Cadastro());




        
        }
    }
}
