using System.Collections.Generic;

namespace WhatsApp


{
    public interface IAgenda
    {
        void Cadastrar(Contato contat);
        void Excluir(Contato contat);
        List<Contato> Listar();

    }

}