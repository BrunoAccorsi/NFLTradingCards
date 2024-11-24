namespace NFLTradingCards.Models
{
    public class Player
    {
        public required string Name { get; set; }
        public required string Team { get; set; }
        public int PassingYards { get; set; }
        public double YardsPerAttempt { get; set; }
        public int Touchdowns { get; set; }
        public int InterceptionsThrown { get; set; }
    }
} 