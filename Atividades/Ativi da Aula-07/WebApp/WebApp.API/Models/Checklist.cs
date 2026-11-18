namespace WebApp.API.Models
{
    public class Checklist
    {
        public int id { get; set; }
        public string Nome { get; set; }
       
        public string Tarefa { get; set; }

        public string Feita { get; set; }

        public DateTime data { get; set; }
 
    }
}
