using System;
using System.Collections.Generic;



namespace WhatsApp
{
    class Program
    {
        static void Main(string[] args)
        {
          //instanciamos o metodo construtor
            Contato ann = new Contato("Vinicius", 961960432);
           
           //instancia o que esta na classe agenda  
            Agenda xxx = new Agenda();
            xxx.Cadastrar(ann);
            List<Contato> Lista = xxx.Listar();

            //agora limpa com o foreach
            foreach(Contato a in Lista)
            {
                Console.WriteLine($"Nome: {ann.Nome} - Numero: {ann.Telefone}");
            }

            Mensagem m = new Mensagem();

        }
    }
}
