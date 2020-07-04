using System;

namespace WhatsApp
{
    public class Mensagem
    {
        public string Text { get; set; }

        public string Destinatario { get; set; }

        //estrutura para enviar a mensagem
        public void Enviar(Contato contat){
            //mandar a mensagem
            System.Console.WriteLine($"Escreva uma mensagem para: {contat.Nome}.");
            //o individuo vai escrever a mensagem 
            Text = Console.ReadLine();
            //mensagem enviada 
            System.Console.WriteLine($"A mensagem {Text} foi enviada com sucesso para {Destinatario}");

        }
    }
}