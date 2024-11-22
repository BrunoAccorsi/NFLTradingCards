using NFLTradingCards.Models;
using System.Numerics;

namespace NFLTradingCards
{
    public partial class Form1 : Form
    {
        private List<Player> players;

        public Form1()
        {
            InitializeComponent();
            LoadPlayers();
            InitializeListBox();
        }

        private void LoadPlayers()
        {
            players = new List<Player>();
            string csvPath = Path.Combine(Application.StartupPath, "nflPlayers.csv");

            string filePath = File.Exists(csvPath) ? csvPath :
                             throw new FileNotFoundException("Could not find nflPlayers.csv");

            string[] lines = File.ReadAllLines(filePath);


            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                players.Add(new Player
                {
                    Name = values[0].Trim(),
                    Team = values[1].Trim(),
                    PassingYards = int.Parse(values[2]),
                    YardsPerAttempt = double.Parse(values[3]),
                    Touchdowns = int.Parse(values[7]),
                    InterceptionsThrown = int.Parse(values[8])
                });

            }
        }

        //add players to list
        private void InitializeListBox()
        {
            playerListBox.DataSource = players;
            playerListBox.DisplayMember = "Name";
        }

        private void playerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playerListBox.SelectedItem is Player selectedPlayer)
            {
                playerName.Text = selectedPlayer.Name;

                // Update the card display
                UpdateCardDisplay(selectedPlayer);
            }
        }

        private void UpdateCardDisplay(Player player)
        {
            nameLabel.Text = player.Name;

            passingYardsLabel.Text = $"Passing Yards: {player.PassingYards}";
            yardsPerAttemptLabel.Text = $"Yards/Attempt: {player.YardsPerAttempt:F2}";
            touchdownsLabel.Text = $"Touchdowns: {player.Touchdowns}";
            interceptionsLabel.Text = $"Interceptions: {player.InterceptionsThrown}";

            //Background Color based on team
            cardPanel.BackColor = GetTeamColor(player.Team);
        }


        private Color GetTeamColor(string team)
        {

            //these colors were made using AI
            switch (team)
            {
                case "Cincinnati Bengals": return Color.FromArgb(251, 79, 20);
                case "Baltimore Ravens": return Color.Purple;
                case "Minnesota Vikings": return Color.FromArgb(79, 38, 131);
                case "Seattle Seahawks": return Color.FromArgb(0, 34, 68);
                case "San Francisco 49ers": return Color.Red;
                case "Los Angeles Rams": return Color.FromArgb(0, 53, 148);
                case "Buffalo Bills": return Color.FromArgb(0, 51, 141);
                case "Tampa Bay Buccaneers": return Color.FromArgb(213, 10, 10);
                case "Detroit Lions": return Color.FromArgb(0, 118, 182);
                case "New York Jets": return Color.FromArgb(18, 87, 64);
                case "Kansas City Chiefs": return Color.FromArgb(227, 24, 55);
                case "Houston Texans": return Color.FromArgb(3, 32, 47);
                case "Washington Commanders": return Color.FromArgb(63, 16, 16);
                case "Denver Broncos": return Color.FromArgb(251, 79, 20);
                case "Philadelphia Eagles": return Color.FromArgb(0, 76, 84);
                case "Los Angeles Chargers": return Color.FromArgb(0, 128, 198);
                case "Green Bay Packers": return Color.FromArgb(24, 48, 40);
                case "Indianapolis Colts": return Color.FromArgb(0, 44, 95);
                case "Cleveland Browns": return Color.FromArgb(49, 29, 0);
                case "Chicago Bears": return Color.FromArgb(11, 22, 42);
                case "New Orleans Saints": return Color.FromArgb(211, 188, 141);
                case "Carolina Panthers": return Color.FromArgb(0, 133, 202);
                case "Pittsburgh Steelers": return Color.FromArgb(255, 182, 18);
                case "New England Patriots": return Color.FromArgb(0, 34, 68);
                case "New York Giants": return Color.FromArgb(1, 35, 82);
                default: return Color.Gray;
            }
        }

    }
}
