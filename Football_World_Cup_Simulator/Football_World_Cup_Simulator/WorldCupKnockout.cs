using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldCupSimulator2
{
    /// <summary>
    /// Klasa zawiera wszystkie statystki danej rundy Fazy Finałowej
    /// </summary>
    class WorldCupKnockout
    {
        private List<Team> teamsInRound = new List<Team>();
        private List<FinalsTeamsGame> gamesInRound = new List<FinalsTeamsGame>();
        private List<Label> listOfGamesInRound;
        private List<Team> winners = new List<Team>();

        public WorldCupKnockout(List<Team> teamsInRound, List<Label> listOfGamesInRound)
        {
            this.teamsInRound = teamsInRound;
            this.listOfGamesInRound = listOfGamesInRound;
        }

        public void InitializeTeamGames()
        {
            MakeGames();
            PlayGames();
            DisplayGames();
        }

        private void DisplayGames()
        {
            for (int i = 0; i < listOfGamesInRound.Count; i = i + 2)
            {
                for (int j = 0; j < gamesInRound[i / 2].teams.Count; j++)
                {
                    String penatlies = "";

                    // jezeli byl rozegrany konkurs rzutow karnych, to wypisujemy dodatkowo wynik
                    if (gamesInRound[i / 2].stats[j].penalties != 0)
                    {
                        penatlies = "(" + gamesInRound[i / 2].stats[j].penalties + ")";
                    }
                    listOfGamesInRound[i + j].Text = String.Format("{0, -22} {1} {2}",
                        gamesInRound[i / 2].teams[j].Name, gamesInRound[i / 2].stats[j].goals, penatlies);

                    // umieszczanie obiektu WorldCupKnockout do Tagu labela
                    listOfGamesInRound[i + j].Tag = gamesInRound[i / 2];
                }
            }
        }

        private void PlayGames()
        {
            for (int i = 0; i < gamesInRound.Count; i++)
            {
                // zapisujemy zwycięsców do pomocniczej listy
                winners.Add(gamesInRound[i].PlayGame());
            }
        }

        private void MakeGames()
        {
            for (int i = 0; i < teamsInRound.Count; i = i + 2)
            {
                FinalsTeamsGame game = new FinalsTeamsGame(teamsInRound[i], teamsInRound[i + 1]);
                gamesInRound.Add(game);
            }
        }

        public List<Team> Winners { get => winners; }
    }
}
