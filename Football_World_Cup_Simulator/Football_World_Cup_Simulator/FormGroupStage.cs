using System;
using System.Collections;
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
    public partial class FormGroupStage : Form
    {
        // atrybuty klasy
        List<Team> QualifiedTeams = new List<Team>();
        List<WorldCupGroup> stageGroup = new List<WorldCupGroup>();
        int step = 2;

        public FormGroupStage(List<Team> teams)
        {
            InitializeComponent();

            this.QualifiedTeams = teams;

            // utworzenie tablicy osmiu grupy-etykiet, ktore wyswietlaja statystyki w oknie "fazy grupowej"
            List<GroupBox> groups = new List<GroupBox>(new GroupBox[] { groupAStats, groupBStats,
                groupCStats, groupDStats, groupEStats, groupFStats, groupGStats, groupHStats});

            // oficjalne losowanie grup
            List<List<Team>> listOfGroups = DrawProcedure();

            // utworzenie osmiu grup mistrzosw swiata
            WorldCupGroup groupA = new WorldCupGroup(groupAStats, groupAGames, listOfGroups[0]);
            WorldCupGroup groupB = new WorldCupGroup(groupBStats, groupBGames, listOfGroups[1]);
            WorldCupGroup groupC = new WorldCupGroup(groupCStats, groupCGames, listOfGroups[2]);
            WorldCupGroup groupD = new WorldCupGroup(groupDStats, groupDGames, listOfGroups[3]);
            WorldCupGroup groupE = new WorldCupGroup(groupEStats, groupEGames, listOfGroups[4]);
            WorldCupGroup groupF = new WorldCupGroup(groupFStats, groupFGames, listOfGroups[5]);
            WorldCupGroup groupG = new WorldCupGroup(groupGStats, groupGGames, listOfGroups[6]);
            WorldCupGroup groupH = new WorldCupGroup(groupHStats, groupHGames, listOfGroups[7]);

            stageGroup.Add(groupA);
            stageGroup.Add(groupB);
            stageGroup.Add(groupC);
            stageGroup.Add(groupD);
            stageGroup.Add(groupE);
            stageGroup.Add(groupF);
            stageGroup.Add(groupG);
            stageGroup.Add(groupH);
        }

        private void FormGroupStage_Load(object sender, EventArgs e)
        {
            InitializeLabelHeaders();
            InitializeAllGroups();
        }


        /// <summary>
        /// Prywatna metoda losujaca zespoly do grup
        /// </summary>
        /// <param name="qualifiedTeams"></param>
        /// <returns></returns>
        private List<List<Team>> DrawProcedure()
        {
            // delegata - funkcja wywolan zwrotnych dla metody Count()
            Func<Team, bool> UEFAteams = delegate (Team team) { return team.Confederation == "UEFA"; };

            // 8-elemntowa lista 4-elementowych list przechowujaca obiekty Team
            List<List<Team>> Groups = new List<List<Team>> {
                    new List<Team>(), new List<Team>(), new List<Team>(), new List<Team>(),
                    new List<Team>(), new List<Team>(), new List<Team>(), new List<Team>()
            };

            Random random = new Random();

            Boolean IsDeadlock;

            do
            {
                // ustaw flage o zakleszczeniu jako falsz
                IsDeadlock = false;

                // definiujemy kolejki i przypisujemy im posortowane druzyny
                Queue<Team> Pot1 = new Queue<Team>(QualifiedTeams.GetRange(0, 8));
                Queue<Team> Pot2 = new Queue<Team>(QualifiedTeams.GetRange(8, 8));
                Queue<Team> Pot3 = new Queue<Team>(QualifiedTeams.GetRange(16, 8));
                Queue<Team> Pot4 = new Queue<Team>(QualifiedTeams.GetRange(24, 8));

                // permutacja druzyn w kolejkach
                Pot1 = new Queue<Team>(Pot1.OrderBy(item => random.Next()).ToList());
                Pot2 = new Queue<Team>(Pot2.OrderBy(item => random.Next()).ToList());
                Pot3 = new Queue<Team>(Pot3.OrderBy(item => random.Next()).ToList());
                Pot4 = new Queue<Team>(Pot4.OrderBy(item => random.Next()).ToList());


                // zespoly z pierwszej kolejki
                for (int i = 0; i < 8; i++)
                {
                    Groups[i].Add(Pot1.Dequeue());
                }

                // zespoly z drugiej kolejki
                for (int i = 0; i < 8 && IsDeadlock == false; i++)
                {
                    Queue<Team> CheckedTeams2 = new Queue<Team>();

                    while (CheckedTeams2.Count < Pot2.Count)
                    {
                        Team current_team = Pot2.Dequeue();

                        CheckedTeams2.Enqueue(current_team);

                        if ((Groups[i][0].Confederation != current_team.Confederation) 
                            || (current_team.Confederation == "UEFA" && Groups[i].Count(UEFAteams) < 2))
                        {
                            Groups[i].Add(current_team);
                            break;
                        }
                        else
                        {
                            Pot2.Enqueue(current_team);
                        }
                    }
                    // jesli zakleszczenie wystapilo
                    if (Groups[i].Count != 2)
                    {
                        // ustawiamy flage o zakleszczeniu
                        IsDeadlock = true;
                    }
                }


                // zespoly trzeciej kolejki
                for (int i = 0; i < 8 && IsDeadlock == false; i++)
                {
                    Queue<Team> CheckedTeams3 = new Queue<Team>();

                    while (CheckedTeams3.Count < Pot3.Count)
                    {
                        Team current_team = Pot3.Dequeue();

                        CheckedTeams3.Enqueue(current_team);

                        if ((Groups[i][0].Confederation != current_team.Confederation 
                            && Groups[i][1].Confederation != current_team.Confederation) 
                            || (current_team.Confederation == "UEFA" && Groups[i].Count(UEFAteams) < 2))
                        {
                            Groups[i].Add(current_team);
                            break;
                        }
                        else
                        {
                            Pot3.Enqueue(current_team);
                        }
                    }
                    // jesli zakleszczenie wystapilo
                    if (Groups[i].Count != 3)
                    {
                        // ustawiamy flage o zakleszczeniu
                        IsDeadlock = true;
                    }
                }


                // zespoly z czwartego koszyka
                for (int i = 0; i < 8 && IsDeadlock == false; i++)
                {
                    Queue<Team> CheckedTeams4 = new Queue<Team>();

                    while (CheckedTeams4.Count <  Pot4.Count)
                    {
                        Team current_team = Pot4.Dequeue();

                        CheckedTeams4.Enqueue(current_team);

                        if ((Groups[i][0].Confederation != current_team.Confederation 
                            && Groups[i][1].Confederation != current_team.Confederation 
                            && Groups[i][2].Confederation != current_team.Confederation) 
                            || (current_team.Confederation == "UEFA" && Groups[i].Count(UEFAteams) < 2))
                        {
                            Groups[i].Add(current_team);
                            break;
                        }
                        else
                        {
                            Pot4.Enqueue(current_team);
                        }
                    }

                    if (Groups[i].Count != 4)
                    {
                        // ustawiamy flage o zakleszczeniu
                        IsDeadlock = true;
                    }
                }

                // jesli wystapilo zakleszczenie
                if (IsDeadlock == true)
                {
                    // czyscimy grupy mistrzostw swiata
                    for (int k = 0; k < 8; k++)
                    {
                        Groups[k].Clear();
                    }
                }

            } while (IsDeadlock == true);

            return Groups;
        }

        private void InitializeAllGroups()
        {
            for (int i = 0; i < stageGroup.Count; i++)
            {
                stageGroup[i].InitializeTeamGames();
            }
        }

        private void InitializeLabelHeaders()
        {
            List<Label> groupHeaders = new List<Label>() { lbl_GroupHeader, label81, label82, label83, label84, label85, label86, label87 };
            foreach (var header in groupHeaders)
            {
                header.Text = String.Format("{0, -23} {1, -1} {2, -1} {3, -2}{4, -2}{5, -3}{6, -3}", "", "W", "D", "L", "GF", "GA", "PTS");
            }
        }


        private void Btn_FinalStage_Click(object sender, EventArgs e)
        {
            if (step > 5)
            {
                List<Team> winnerTeams = new List<Team>();

                for (int i = 0; i < stageGroup.Count; i++)
                {
                    winnerTeams.AddRange(stageGroup[i].GetWinners());
                }

                FormFinalStage newForm = new FormFinalStage(winnerTeams);
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Najpierw należy przejść przez fazę losowania i wygenerowania wyników meczów", "Help Caption");
            }
        }

        private void Btn_GenerateScore_Click(object sender, EventArgs e)
        {
            switch (step)
            {
                case 2:
                    for (int i = 0; i < 8; i++)
                    {
                        stageGroup[i].DemonstrateView(step);
                    }
                    btn_GenerateScore.Text = "Wylosuj trzecie zespoły";
                    break;

                case 3:
                    for (int i = 0; i < 8; i++)
                    {
                        stageGroup[i].DemonstrateView(step);
                    }
                    btn_GenerateScore.Text = "Wylosuj czwarte zespoły";
                    break;

                case 4:
                    for (int i = 0; i < 8; i++)
                    {
                        stageGroup[i].DemonstrateView(step);
                    }
                    btn_GenerateScore.Text = "Generuj wyniki meczów";
                    break;

                case 5:
                    for (int i = 0; i < 8; i++)
                    {
                        stageGroup[i].GenerateGamesResult();
                        stageGroup[i].DisplayScores();
                    }
                    break;

                default:
                    break;
            }
            step++;
        }


        /// <summary>
        /// Funkcja generyczna umożliwiajaca podejrzenie wynikow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowGameResult_Click(object sender, EventArgs e)
        {
            try
            {
                var l = (Label)sender;
                TeamsGame game = (TeamsGame)l.Tag;

                if (game != null)
                {
                    FormGameDetails form = new FormGameDetails(game);
                    form.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kliknąć możesz jedynie na pole meczu.", "Help Caption");
            }
        }
    }
}