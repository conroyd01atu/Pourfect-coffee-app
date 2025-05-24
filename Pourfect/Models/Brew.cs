using SQLite;
using System;

namespace Pourfect.Models
{
    public class Brew
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public string BeanName { get; set; }
        public string Method { get; set; }  // e.g. "V60", "Kalita"
        public double Dose { get; set; }    // grams of coffee
        public double Water { get; set; }   // ml of water
        public int BloomTime { get; set; }  // seconds
        public int TotalTime { get; set; }  // seconds
        public string Notes { get; set; }
    }
}