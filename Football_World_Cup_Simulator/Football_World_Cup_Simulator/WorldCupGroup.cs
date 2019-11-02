using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldCupSimulator2
{
    /// <summary>
    /// Klasa przechowuje wszystkie podstawowe statystyki danej grupy fazy grupowej
    /// </summary>
    class WorldCupGroup
    {
        const String statsFormat = "{0, -23} {1, -1} {2, -1} {3, -2}{4, -2}{5, -3}{6, -3}";
        const String gamesFormat = "{0} {1} {2}";

        private List<Team> teamTable = new List<Team>();
        private List<TeamsGame> resultsTable = new List<TeamsGame>();
        private GroupBox standingGroupBox;
        private GroupBox resultsGroupBox;


        /// <summary>
        /// Konstruktor klasy WorldCupGroup
        /// </summary>
        /// <param name="statsGroupBox"></param>
        /// <param name="gamesGroupBox"></param>
        /// <param name="teamsInGroup"></param>
        public WorldCupGroup(GroupBox statsGroupBox, GroupBox gamesGroupBox, List<Team> teamsInGroup)
        {
            this.standingGroupBox = statsGroupBox;
            this.resultsGroupBox = gamesGroupBox;
            this.teamTable = teamsInGroup;
        }


        /// <summary>
        /// Funkcja tworzy nowe obikety TeamGame, a nastepnie wypisuje ich domyslne wartosci
        /// </summary>
        public void InitializeTeamGames()
        {
            MakeGames();
            DisplayDefaultStats();
            DemonstrateView(1);
        }


        /// <summary>
        /// Funkcja wyswietla wnyiki meczy w tablicy grupy i w tablicy wynikow do UI
        /// </summary>
        public void DisplayScores()
        {
            PrintGamesResults();
            PrintGroupStats();
        }


        /// <summary>
        /// Funkcja rozgrywa mecze i sortuje grupe
        /// </summary>
        public void GenerateGamesResult()
        {
            PlayGroupsGames();
            SortingTeamsInGroups();
        }

        /// <summary>
        /// Funkcja przekazuje dwa najlepsze zespoły z grupy
        /// </summary>
        /// <returns>
        /// Lista dwóch drużyn 
        /// </returns>
        public List<Team> GetWinners()
        {
            if (resultsTable.Count != 6) return null;

            List<Team> winners = new List<Team>(teamTable.GetRange(0, 2));
            return winners;
        }

        /// <summary>
        /// Funkcja rozgrywa wczesniej utworzone mecze TeamGame
        /// </summary>
        private void PlayGroupsGames()
        {
            for (int i = 0; i < resultsTable.Count; i++)
            {
                resultsTable[i].PlayGame();
            }
        }


        /// <summary>
        /// Funcja tworzy harmongram meczy czekajacych na rozegranie
        /// </summary>
        private void MakeGames()
        {
            for (int i = 0; i < teamTable.Count; i++)
            {
                for (int j = i + 1; j < teamTable.Count; j++)
                {
                    // metoda rysowania choiki
                    TeamsGame game = new TeamsGame(teamTable[i], teamTable[j]);
                    resultsTable.Add(game);
                }
            }

            // estetyczna zamiana kolejnosci druzyn w grupie potrzebne do UI
            TeamsGame temp = resultsTable[5];
            resultsTable[5] = resultsTable[3];
            resultsTable[3] = temp;
        }


        private void PrintGroupStats()
        {
            for (int i = 0; i < teamTable.Count; i++)
            {
                String Won = teamTable[i].Won.ToString();
                String Drawn = teamTable[i].Drawn.ToString();
                String Lost = teamTable[i].Lost.ToString();
                String GoalsFor = teamTable[i].GoalsFor.ToString();
                String GoalsAgainst = teamTable[i].GoalsAgainst.ToString();
                String Points = teamTable[i].Points.ToString();

                string formatted = String.Format(statsFormat, teamTable[i].Name, Won, Drawn, Lost, GoalsFor, GoalsAgainst, Points);
                standingGroupBox.Controls[i].Text = formatted;
            }
        }

        public void DemonstrateView(int count = 4)
        {
            for (int i = 0; i < count; i++)
            {
                standingGroupBox.Controls[i].Text = String.Format(statsFormat, teamTable[i].Name, "0", "0", "0", "0", "0", "0");
            }

            if (count > 3)
            {
                for (int i = 0; i < resultsTable.Count; i++)
                {
                    String score = "-:-";
                    resultsGroupBox.Controls[i].Text = String.Format(gamesFormat, resultsTable[i].teams[0].Name, score, resultsTable[i].teams[1].Name);
                }
            }
        }

        private void PrintGamesResults()
        {
            for (int i = 0; i < resultsTable.Count; i++)
            {
                String score = resultsTable[i].stats[0].goals.ToString() + ":" + resultsTable[i].stats[1].goals.ToString();
                resultsGroupBox.Controls[i].Text = String.Format(gamesFormat, resultsTable[i].teams[0].Name, score, resultsTable[i].teams[1].Name);

                // umieszczamy mecz w Tagu etykiety
                resultsGroupBox.Controls[i].Tag = resultsTable[i];
            }
        }

        private void SortingTeamsInGroups()
        {
            // Sortowanie druzyn w tabelach G1-G8
            teamTable.Sort((team1, team2) =>
                {
                    int compare;

                    // sortujemy po punktach
                    compare = team2.Points.CompareTo(team1.Points);
                    if (compare != 0)
                        return compare;

                    // sortujemy po roznicy bramek
                    compare = (team2.GoalsFor - team2.GoalsAgainst).CompareTo(team1.GoalsFor - team1.GoalsAgainst);
                    if (compare != 0)
                        return compare;

                    // sortujemy po zdobytych bramkach
                    compare = team2.GoalsFor.CompareTo(team1.GoalsFor);
                    if (compare != 0)
                        return compare;

                    // ostatecznie losujemy druzyne
                    return (new Random().Next(-1, 1));
                }
            );
        }

        private void DisplayDefaultStats()
        {
            for (int i = 0; i < teamTable.Count; i++)
            {
                standingGroupBox.Controls[i].Text = String.Format(statsFormat, "Team " + (i+1).ToString(), "0", "0", "0", "0", "0", "0");
            }

            for (int i = 0; i < resultsTable.Count; i++)
            {
                String score = "-:-";
                resultsGroupBox.Controls[i].Text = String.Format(gamesFormat, "?", score, "?");
            }
        }
    }
}