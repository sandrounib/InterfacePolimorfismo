namespace ClasseInterface
{
    public class PF : Cliente, IAcao
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public PF()
        {
            
        }
        public PF(int id,string nome,string cpf, string email,string telefone,Endereco endereco)
        {
            base.Id = id;
            this.Nome = nome;
            this.CPF = cpf;
            this.Email = email;
            this.Telefone = telefone;
            this.End = endereco;            
            
        }




        public string Cadastro()
        {
            string composicao = "Id do cliente: "+Id+
                                "Nome do cliente: "+Nome+
                                "\nEndereço: "+End.Logradouro + " ,"+End.Numero+" ,"+End.Bairro+" ."+
                                "\nTelefone: "+Telefone+
                                "CPF: "+CPF+ 
                                "\nEmail: "+Email;
            
            return "Dados do Cliente\n\n"+composicao;
        }

        public string Consulta()
        {
            throw new System.NotImplementedException();
        }
    }
}