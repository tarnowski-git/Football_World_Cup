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
    public partial class FormFinalStage : Form
    {
        List<Team> teams;

        List<Label> roundOf16Labels;
        List<Label> quarterFinalsLabels;
        List<Label> semiFinalsLabels;
        List<Label> firstPlaceLabels;
        List<Label> thirdPlaceLabels;

        public FormFinalStage(List<Team> teams)
        {
            // inicjalizacji elementów okna
            InitializeComponent();

            this.teams = teams;

            // tworzenie listy etykiet do przekazania do obiektow
            roundOf16Labels = new List<Label> {
                label1, label2, label3, label4, label5, label6, label7,
                label8, label9, label10, label11, label12, label13, label14,
                label15, label16
            };

            quarterFinalsLabels = new List<Label> {
                label17, label18, label19, label20,
                label21, label22, label23, label24
            };

            semiFinalsLabels = new List<Label> {
                label25, label26, label27, label28
            };

            firstPlaceLabels = new List<Label>{ label29, label30 };
            thirdPlaceLabels = new List<Label> { label31, label32 };
        }


        private void FormFinalStage_Load(object sender, EventArgs e)
        {
            // ukladanie druzyn w odpowiedniej kolejnosci
            List<Team> sortedFinalTeams = new List<Team>();
            
            for (int i = 0; i < 16; i = i + 4)
            {
                sortedFinalTeams.Add(teams[i]);
                sortedFinalTeams.Add(teams[i + 3]);
            }

            for (int i = 0; i < 16; i = i + 4)
            {
                sortedFinalTeams.Add(teams[i + 1]);
                sortedFinalTeams.Add(teams[i + 2]);
            }

            // rozegranie 1/8 mistrzostw
            WorldCupKnockout roundOf16games = new WorldCupKnockout(sortedFinalTeams, roundOf16Labels);
            roundOf16games.InitializeTeamGames();

            // rozegranie 1/4 mistrzostw
            WorldCupKnockout quarterFinalGames = new WorldCupKnockout(roundOf16games.Winners, quarterFinalsLabels);
            quarterFinalGames.InitializeTeamGames();

            // rozegranie 1/2 mistrzostw
            WorldCupKnockout semiFinalGames = new WorldCupKnockout(quarterFinalGames.Winners, semiFinalsLabels);
            semiFinalGames.InitializeTeamGames();

            // pomocnicza lista zwierajaca przegrane druzyny
            List<Team> loosers = quarterFinalGames.Winners;
            loosers.Remove(semiFinalGames.Winners[0]);
            loosers.Remove(semiFinalGames.Winners[1]);

            // rozegranie meczu o trzecie miejsce
            WorldCupKnockout thirdPlaceGame = new WorldCupKnockout(loosers, thirdPlaceLabels);
            thirdPlaceGame.InitializeTeamGames();

            // rozegranie finalu
            WorldCupKnockout firstPlaceGame = new WorldCupKnockout(semiFinalGames.Winners, firstPlaceLabels);
            firstPlaceGame.InitializeTeamGames();
        }

        private void ShowGameResult_Click(object sender, EventArgs e)
        {
            var l = (Label)sender;
            FinalsTeamsGame game = (FinalsTeamsGame)l.Tag;

            if (game != null)
            {
                FormGameDetails form = new FormGameDetails(game);
                form.Show();
            }
        }
    }
}