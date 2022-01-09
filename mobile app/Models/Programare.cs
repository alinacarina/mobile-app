using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace Mobile_app.Models
{
    public class Programare
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Cod { get; set; }
        public string Denumire { get; set; }
        public DateTime Date { get; set; }
    }
}