using System;
using System.Collections.Generic;



namespace WhatsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda xxx = new Agenda();

          //instanciamos o metodo construtor
            Contato c1= new Contato("Vinicius", 961960432);
            Contato c2= new Contato("Milena", 961960432);
            Contato c3= new Contato("Melissa", 961960432);
            Contato c4= new Contato("Eduardo", 961960432);
           
            xxx.Cadastrar(c1);
            xxx.Cadastrar(c2);
            xxx.Cadastrar(c3);
            xxx.Cadastrar(c4);
        
            
            xxx.Excluir(c1);

            //agora limpa com o foreach
            foreach(Contato c in xxx.Listar())
            {
                Console.WriteLine($"Nome: {c.Nome} ; Tel: {c.Telefone}");
            }

            Mensagem m = new Mensagem();
            m.Destinatario=c3;
            m.Text="OI " +m.Destinatario.Nome+ "!";
            Console.WriteLine(m.Enviar());


        }
    }
}
