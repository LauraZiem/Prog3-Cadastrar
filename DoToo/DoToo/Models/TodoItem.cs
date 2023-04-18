using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace DoToo.Models
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Sobrenome { get; set; }
        public DateTime DtNsc { get; set; }
        public string Sexo {get; set; }
        public string Endereco {get; set; }
        public string Cidade {get; set; }
        public string UF {get; set; }
    }
}
