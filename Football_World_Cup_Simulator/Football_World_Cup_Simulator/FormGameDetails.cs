using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldCupSimulator2
{
    public partial class FormGameDetails : Form
    {
        const String gamesFormat = "{0, -15} {1, -15} {2}";
        const String resultFormat = "{0, -15} {1, -10} {2}";
        const String statsFormat = "{0, -20} {1, -10} {2}";
        const int minuteSample = 3;

        private TeamsGame game;


        public FormGameDetails(TeamsGame game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void FormGameDetails_Load(object sender, EventArgs e)
        {
            String score = game.stats[0].goals.ToString() + ":" + game.stats[1].goals.ToString();

            Lbl_Score.Text = String.Format(gamesFormat, game.teams[0].Name, score, game.teams[1].Name);

            for (int i = 0; i < game.highlights.Count; i++)
            {
                if (minuteSample * (i + 1) == 90 + minuteSample)
                {
                    String info = String.Format(resultFormat, "Dogrywka", "", "");
                    lst_details.Items.Add(info);
                }

                String time = (minuteSample * (i + 1)).ToString() + " min";
                String result = game.highlights[i][0].goals.ToString() + " : " + game.highlights[i][1].goals.ToString();
                String situation = "";

                if (game.highlights[i][0].situation != "" && game.highlights[i][1].situation != "")
                {
                    situation = game.highlights[i][0].situation +  " / " + game.highlights[i][1].situation;
                }
                else
                {
                    situation = game.highlights[i][0].situation + game.highlights[i][1].situation;
                }

                String item = String.Format(resultFormat, time, result, situation);
                lst_details.Items.Add(item);
            }

            if (game is FinalsTeamsGame)
            {
                FinalsTeamsGame extraGame = game as FinalsTeamsGame;

                if (extraGame.listOfScores.Count > 0)
                {
                    String info = String.Format(resultFormat, "Konkurs rzutów karnych", "", "");
                    lst_details.Items.Add(info);
                }

                for (int i = 0; i < extraGame.listOfScores.Count; i++)
                {
                    String round = "Seria nr " + (i + 1).ToString();
                    String result = extraGame.listOfScores[i][0].ToString() + " : " + extraGame.listOfScores[i][1].ToString();
                    String item = String.Format(resultFormat, round, result, "");
                    lst_details.Items.Add(item);
                }
            }

            int last = game.highlights.Count - 1;
            int fouls_1 = game.highlights[last][0].opponentFouls + game.highlights[last][0].yellow_card + game.highlights[last][0].red_card;
            int fouls_2 = game.highlights[last][1].opponentFouls + game.highlights[last][1].yellow_card + game.highlights[last][1].red_card;

            Lbl_fouls.Text = String.Format(statsFormat, "Faule: ", fouls_1, fouls_2);
            Lbl_yellowCards.Text = String.Format(statsFormat, "Żółte kartki: ", game.highlights[last][0].yellow_card, game.highlights[last][1].yellow_card);
            Lbl_redCars.Text = String.Format(statsFormat, "Czerwone kartki: ", game.highlights[last][0].red_card, game.highlights[last][1].red_card);
        }
    }
}
