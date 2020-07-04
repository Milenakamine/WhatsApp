using System.Collections.Generic;

namespace WhatsApp


{
    public interface IAgenda
    {
        void Cadastrar(Contato contat);
        void Excluir(string _termo);
        List<Contato> Listar();

    }

}