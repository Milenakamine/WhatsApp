using System;

namespace WhatsApp
{
    public class Mensagem
    {
        public string Text { get; set; }

        public Contato Destinatario { get; set; }

        //estrutura para enviar a mensagem
        public string Enviar(){
           
           return $"Para {Destinatario.Nome} - Mensagem:{Text}.";
        }
    }
}