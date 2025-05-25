using SQLite;
using System;

namespace Pourfect.Models
{
    public class Bean
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Origin { get; set; }
        public string Variety { get; set; }
        public string Process { get; set; }
        public string Roaster { get; set; }
        public string RoastDate { get; set; }
        public string RoastType{ get; set; }
        public string Notes { get; set; }
    }
}
