
namespace ClasseInterface
{
    public class Produto:IAcao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Produto()
        {
            
        }
        public Produto(int id,string nome,string descricao,double preco)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Preco = preco;     
            
            
        }

        public string Cadastro()
        {
            string composicao = "Id do Produto: "+Id+
                                "Nome do Produto: "+Nome.ToUpper()+
                                "Descrição do Prcdduto: "+Descricao+
                                "\nPreço do Produto: "+string.Format("{0:C2}",Preco);
            
            return "Produto cadastrado\n"+composicao;

        }

        public string Consulta()
        {
            throw new System.NotImplementedException();
        }
    }
}