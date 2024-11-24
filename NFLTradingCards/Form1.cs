using Microsoft.VisualBasic.ApplicationServices;
using NFLTradingCards.Models;
using System.Numerics;

namespace NFLTradingCards
{
    public partial class Form1 : Form
    {
        private List<Player> players;

        public Form1()
        {
            players = new List<Player>(); // Initialize the players list
            InitializeComponent();
            LoadPlayers();
            InitializeListBox();
        }

        private void LoadPlayers()
        {
            string csvPath = Path.Combine(Application.StartupPath, "nflPlayers.csv");

            string filePath = File.Exists(csvPath) ? csvPath :
                             throw new FileNotFoundException("Could not find nflPlayers.csv");

            string[] lines = File.ReadAllLines(filePath);

            players = new List<Player>();

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

                // Update the picture display
                LoadPlayerImage(selectedPlayer);
            }
        }

        private void LoadPlayerImage(Player player)
        {
            string imageName = player.Name.Replace(" ", "") + ".jpg";

            string? projectPath = Directory.GetParent(Application.StartupPath)?.Parent?.Parent?.Parent?.FullName;

            if (projectPath is null)
            {
                throw new InvalidOperationException("Project path could not be determined.");
            }

            string imagePath = Path.Combine(projectPath, "playerPics", imageName);

            if (File.Exists(imagePath))
            {
                playerPicture.Image = Image.FromFile(imagePath);
            }
            else
            {
                playerPicture.Image = null;
            }
        }

        private static readonly Dictionary<string, string> TeamImageMapping = new Dictionary<string, string>
        {
            { "Cincinnati Bengals", "Bengals.jpg" },
            { "Baltimore Ravens", "Ravens.jpg" },
            { "Minnesota Vikings", "Vikings.jpg" },
            { "Seattle Seahawks", "Seahawks.jpg" },
            { "San Francisco 49ers", "49ers.jpg" },
            { "Los Angeles Rams", "Rams.jpg" },
            { "Buffalo Bills", "Bills.jpg" },
            { "Tampa Bay Buccaneers", "Buccaneers.jpg" },
            { "Detroit Lions", "Lions.jpg" },
            { "New York Jets", "Jets.jpg" },
            { "Kansas City Chiefs", "Chiefs.jpg" },
            { "Houston Texans", "Texans.jpg" },
            { "Washington Commanders", "Commanders.jpg" },
            { "Denver Broncos", "Broncos.jpg" },
            { "Philadelphia Eagles", "Eagles.jpg" },
            { "Los Angeles Chargers", "Chargers.jpg" },
            { "Green Bay Packers", "Packers.jpg" },
            { "Indianapolis Colts", "Colts.jpg" },
            { "Cleveland Browns", "Browns.jpg" },
            { "Chicago Bears", "Bears.jpg" },
            { "New Orleans Saints", "Saints.jpg" },
            { "Carolina Panthers", "Panthers.jpg" },
            { "Pittsburgh Steelers", "Steelers.jpg" },
            { "New England Patriots", "Patriots.jpg" },
            { "New York Giants", "Giants.jpg" }
        };

        private void UpdateCardDisplay(Player player)
        {
            passingYardsLabel.Text = $"Passing Yards: {player.PassingYards}";
            yardsPerAttemptLabel.Text = $"Yards/Attempt: {player.YardsPerAttempt:F2}";
            touchdownsLabel.Text = $"Touchdowns: {player.Touchdowns}";
            interceptionsLabel.Text = $"Interceptions: {player.InterceptionsThrown}";
            
            // Background Color based on team
            cardPanel.BackColor = GetTeamColor(player.Team);

            // Load team picture
            LoadTeamImage(player.Team);
        }

        private void LoadTeamImage(string team)
        {
            if (TeamImageMapping.TryGetValue(team, out string imageName))
            {
                string? projectPath = Directory.GetParent(Application.StartupPath)?.Parent?.Parent?.Parent?.FullName;

                if (projectPath is null)
                {
                    throw new InvalidOperationException("Project path could not be determined.");
                }

                string imagePath = Path.Combine(projectPath, "teamPics", imageName);

                if (File.Exists(imagePath))
                {
                    teamPicture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    teamPicture.Image = null;
                }
            }
            else
            {
                teamPicture.Image = null;
            }
        }


        private static Color GetTeamColor(string team) =>
            team switch //these colors were made using AI
            {
                "Cincinnati Bengals" => Color.FromArgb(251, 79, 20),
                "Baltimore Ravens" => Color.Purple,
                "Minnesota Vikings" => Color.FromArgb(79, 38, 131),
                "Seattle Seahawks" => Color.FromArgb(0, 34, 68),
                "San Francisco 49ers" => Color.Red,
                "Los Angeles Rams" => Color.FromArgb(0, 53, 148),
                "Buffalo Bills" => Color.FromArgb(0, 51, 141),
                "Tampa Bay Buccaneers" => Color.FromArgb(213, 10, 10),
                "Detroit Lions" => Color.FromArgb(0, 118, 182),
                "New York Jets" => Color.FromArgb(18, 87, 64),
                "Kansas City Chiefs" => Color.FromArgb(227, 24, 55),
                "Houston Texans" => Color.FromArgb(3, 32, 47),
                "Washington Commanders" => Color.FromArgb(63, 16, 16),
                "Denver Broncos" => Color.FromArgb(251, 79, 20),
                "Philadelphia Eagles" => Color.FromArgb(76, 187, 23),
                "Los Angeles Chargers" => Color.FromArgb(0, 128, 198),
                "Green Bay Packers" => Color.FromArgb(24, 48, 40),
                "Indianapolis Colts" => Color.FromArgb(0, 44, 95),
                "Cleveland Browns" => Color.FromArgb(49, 29, 0),
                "Chicago Bears" => Color.FromArgb(11, 22, 42),
                "New Orleans Saints" => Color.FromArgb(211, 188, 141),
                "Carolina Panthers" => Color.FromArgb(0, 133, 202),
                "Pittsburgh Steelers" => Color.FromArgb(255, 182, 18),
                "New England Patriots" => Color.FromArgb(0, 34, 68),
                "New York Giants" => Color.FromArgb(1, 35, 82),
                _ => Color.Gray,
            };
        private void PlayerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playerListBox.SelectedItem is Player selectedPlayer)
            {
                playerName.Text = selectedPlayer.Name;

                // Update the card display
                UpdateCardDisplay(selectedPlayer);

                // Update the picture display
                LoadPlayerImage(selectedPlayer);
            }
        }
    }
}
