namespace WhatsApp
{
    public class Contato
    {
        public string Nome { get; set; }

        public int Telefone { get; set; }
      
        public string Cadastrar { get; set; }


        public Contato(){

        }
        //metodo construtor


        public Contato(string _nome, int _telefone){
        
         this.Nome=_nome;
         this.Telefone=_telefone;

        }
    }
}