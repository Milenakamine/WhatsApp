
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WhatsApp
{
    public class Agenda : IAgenda
    {
        //impletando a interface
        // public void Cadastrar(Contato contat)
        // {
        //     throw new System.NotImplementedException();
        // }

        // public void Excluir(string _termo)
        // {
        //     throw new System.NotImplementedException();
        // }

        // public void Listar()
        // {
        //     throw new System.NotImplementedException();
        // }


         List<Contato> contat;

       //entrada ao csv
        private const string PATH = "Database/contat.csv";

          //se a pasta não existir, ela é criada :
        public Agenda () 
        {
            string pasta = PATH.Split ('/') [0];
            if (!Directory.Exists (pasta)) {
                Directory.CreateDirectory (pasta);
            }
            //PATH - arquivo, caso ele tambem não exista, ele é criado da mesma forma q a pasta, com o ! 
            if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }
        }


         public void Cadastrar(Contato ann)
        {
            var line = new string[] { PrepararLinha(ann) };
            File.AppendAllLines(PATH, line);
        }




          public void Excluir (string _termo) 
        {
            //criação de lista 
            List<string> linhas = new List<string>();
            
            using (StreamReader arquivo = new StreamReader (PATH)) {
                string linha;
                while ((linha = arquivo.ReadLine()) != null) 
                {
                    linhas.Add (linha);
                }
            }
            linhas.RemoveAll (l => l.Contains(_termo));
            
            //reescreve o csv de novo 
            // using (StreamWriter output = new StreamWriter (PATH))
            //como acontece a mesma coisa duas vezes é poivel criar um metodo para sua otimização
           // output.Write (String.Join (Environment.NewLine, linhas.ToArray ()));
                
             Reescrever(linhas);
            
        }

        

            //lista os contatos no csv
           public List<Contato> Listar(){
            List<Contato> lista = new List<Contato>();

            string[] linhas = File.ReadAllLines(PATH);
            
            lista = lista.OrderBy(m => m.Nome).ToList();
            return lista;
        }  


        //CRUD
         private void Reescrever(List<string> lines){
            // Reescrevendo o csv do zero
            using(StreamWriter output = new StreamWriter(PATH))
            {
                foreach(string ln in lines)
                {
                    output.Write(ln + "\n");
                }
            }   
        }


   
         private string PrepararLinha(Contato cont)
        {
            return $"Nome: {cont.Nome} - Telefone: {cont.Telefone}";
        }
    }


}
