using System.Collections.Generic;
using System.IO;// PESQUISAR SOBRE ESSA LIBRARY
namespace MVC___Projeto_de_Console.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        
        private const string PATH = "Database/Produto.csv";

        public Produto()
        {
            //torna a pasta database como posição 0
            string pasta = PATH.Split("/")[0]; 

            //Verificar se a pasta DATABASE existe, se não, criá-la
             if (!Directory.Exists(pasta))
             {
                //Sintaxe para a criação de pasta da condição IF
                Directory.CreateDirectory(pasta);
             }

            //Verificar se o arquivo PRODUTO.CSV existe, se não, criá-lo
            if (!File.Exists(PATH))
            {
                //Sintaxe para a criação de arquivo da condição IF
                File.Create(PATH);
            }
        }
        public List<Produto> Ler()
        {
            List<Produto> itens = new List<Produto>();

            //fazer a LEIRURA de dados do CSV
            string[] linhas = File.ReadAllLines(PATH);
            
            foreach (var item in linhas)
            {
                //faz a separação de atributos pelo " ; "
                string[] atributos = item.Split(";");

                //criar um produto vazio (COM A POSIÇÃO DE CADA ATRIBUTO DEFINIDA) para inserir na lista principal de Produtos
                Produto prod    = new Produto();

                prod.Codigo     = int.Parse(atributos[0]);
                prod.Nome       = atributos[1];
                prod.Preco      = float.Parse(atributos[2]);

                //posteriormente, adicionar à lista
                itens.Add(prod);
            }

            return itens;

        }
        
        public void Inserir(Produto _prod)
        {
            //Necessário criar um array de string para inserir as informações captadas no método PREPARARLINHASCSV
            string[] linhas = {PrepararLinhaCSV(_prod)}; 

            //Coletar as informações do array(acima) e inserindo nas linhas do CSV
            File.AppendAllLines(PATH,linhas);

        }

        public string PrepararLinhaCSV(Produto prod)
        {
            //Formatação das linhas para inserir no arquivo CSV
            return $"{prod.Codigo}; {prod.Nome};{prod.Preco}";
        }
        
    }
}