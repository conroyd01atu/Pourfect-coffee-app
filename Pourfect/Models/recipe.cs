using SQLite;

namespace Pourfect.Models
{
    public class Recipe
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Method { get; set; }        // e.g. "V60"
        public double DefaultRatio { get; set; }  // e.g. 16.0 for 1:16
        public int DefaultBloomTime { get; set; }
        public int DefaultTotalTime { get; set; }
        public double DefaultWaterTemp { get; set; }
        public string Steps { get; set; }         // Store JSON or plain text
    }
}