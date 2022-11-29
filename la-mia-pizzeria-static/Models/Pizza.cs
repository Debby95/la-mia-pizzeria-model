using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [Column(TypeName = "text")]
        public string Descrizione { get; set; }
        //public string Image { get; set; }

        public int Prezzo { get; set; }


        public Pizza(string nome, string descrizione, int prezzo)
        {
            this.Nome = nome;
            this.Descrizione = descrizione;
            this.Prezzo = prezzo;
        }
    }
}
