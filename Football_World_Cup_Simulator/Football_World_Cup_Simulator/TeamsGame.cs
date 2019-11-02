using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCupSimulator2
{
    public class TeamsGame
    {
        public struct Stats
        {
            public int goals;
            public int red_card;
            public int yellow_card;
            public int opponentFouls;
            public int penalties;
            public String situation;

            public static Stats operator +(Stats item1, Stats item2)
            {
                Stats ephemeral = new Stats
                {
                    goals = item1.goals + item2.goals,
                    red_card = item1.red_card + item2.red_card,
                    yellow_card = item1.yellow_card + item2.yellow_card,
                    opponentFouls = item1.opponentFouls + item2.opponentFouls,
                    penalties = item1.penalties + item2.penalties
                };
                return ephemeral;
            }
        }

        static Random random = new Random();

        public List<Team> teams = new List<Team>();

        public Stats[] stats { get; protected set; }

        public List<Stats[]> highlights { get; protected set; }


        public TeamsGame(Team team_1, Team team_2)
        {
            stats = new Stats[2];
            highlights = new List<Stats[]>();

            teams.Add(team_1);
            teams.Add(team_2);
        }

        protected int ShowRedCard(double yellows = 0)
        {
            int rand = random.Next(0, 100);

            if (rand < 99 - (int)yellows)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        
        protected int ShoweYellowCard()
        {
            int rand = random.Next(0, 100);

            if (rand < 90)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        protected int Foul()
        {
            int rand = random.Next(0, 100);

            if (rand < 85)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        protected String GoalSituation()
        {
            int rand = random.Next(0, 100);

            if (rand < 50)
            {
                return "Akcja";
            }
            else if (50 >= rand && rand < 70)
            {
                return "Rzut wolny";
            }
            else if (70 >= rand && rand < 85)
            {
                return "Rzut rożny";
            }
            else if (85 >= rand && rand < 95)
            {
                return "Rzut karny";
            }
            else
            {
                return "Samobój";
            }
        }


        // algorytm losowania wynikow 
        public virtual Team PlayGame(int startTime = 0, int endTime = 90)
        {
            Team winner;
            int totalProbability = 0;
            int[] basicProbability = {97, 94, 91, 89};
            int penalty = 0;
            

            for (int minute = startTime; minute < endTime; minute = minute + 3)
            {
                for (int i = 0; i < 2; i++)
                {
                    stats[i].red_card += ShowRedCard(stats[i].yellow_card * 0.5);
                    stats[i].yellow_card += ShoweYellowCard();
                    stats[i].opponentFouls += Foul();

                    penalty = 5 * stats[i].red_card + 2 * stats[i].yellow_card - 1 * stats[i].opponentFouls;
                    totalProbability = basicProbability[teams[i].Power - 1] + penalty;

                    int rand = random.Next(0, 100);

                    if (rand > totalProbability)
                    {
                        stats[i].goals += 1;
                        stats[i].situation = GoalSituation();
                    }
                    else
                    {
                        stats[i].situation = "";
                    }
                }

                Stats[] ephemeral = new Stats[2];
                for (int i = 0; i < 2; i++)
                {
                    ephemeral[i] = stats[i];
                }
                highlights.Add(ephemeral);
            }

            //uzupeniamy statystyki druzyny o wygenerowany wynik
            teams[0].UpdateScore(stats[0].goals, stats[1].goals);
            teams[1].UpdateScore(stats[1].goals, stats[0].goals);

            if (stats[0].goals > stats[1].goals)
            {
                winner = teams[0];
            }
            else if (stats[0].goals < stats[1].goals)
            {
                winner = teams[1];
            }
            else
            {
                winner = null;
            }

            return winner;
        }
    }


    class FinalsTeamsGame : TeamsGame
    {
        static Random rand = new Random();

        public List<int[]> listOfScores { get; protected set; }

        // konstruktor klasy
        public FinalsTeamsGame(Team team_1, Team team_2) : base(team_1, team_2)
        {
            listOfScores = new List<int[]>();
        }


        private Team PenaltyKicks()
        {
            Team winner;

            int[] score = new int[2];  // przechowuje wyniki w formie tablicy

            // pierwsze 5 serii rzutow karnych
            for (int shoot = 1; shoot <= 5; shoot++)
            {
                int[] temp; // pomaga zmiennej round w zapisaniu wyniku

                // tura druzyny nr 1
                if (rand.Next(0, 100) - teams[0].Power < 85) //85% - 89% szansy
                {
                    stats[0].penalties += 1;
                    score[0] += 1;
                }

                // tura druzyny nr 2
                if (rand.Next(0, 100) - teams[1].Power < 85) //85% - 89% szansy
                {
                    stats[1].penalties += 1;
                    score[1] += 1;
                }

                // zapisujemy wynik
                temp = (int[])score.Clone();
                listOfScores.Add(temp);

                // sprawdzamy arytmetyczne szanse na dalsza gre
                if (Math.Abs(stats[0].penalties - stats[1].penalties) > 5 - shoot)
                {
                    if (stats[0].penalties > stats[1].penalties)
                    {
                        winner = teams[0];
                    }
                    else
                    {
                        winner = teams[1];
                    }
                    return winner;
                }
            }

            // jezeli po piatej rundzie mamy remis, to rozgrywamy dodatkowa serie
            for (int shoot = 6; shoot <= 10; shoot++)
            {
                int[] temp; // pomaga zmiennej round w zapisaniu wyniku
                
                // tura druzyny nr 1
                if (rand.Next(0, 100) - teams[0].Power < 85) //85% - 89% szansy
                {
                    stats[0].penalties += 1;
                    score[0] += 1;
                }

                // tura druzyny nr 2
                if (rand.Next(0, 100) - teams[1].Power < 85) //85% - 89% szansy
                {
                    stats[1].penalties += 1;
                    score[1] += 1;
                }

                // zapisujemy wynik
                temp = (int[])score.Clone();
                listOfScores.Add(temp);

                // sprawdzamy arytmetyczne szanse na dalsza gre
                if (Math.Abs(stats[0].penalties - stats[1].penalties) > 10 - shoot)
                {
                    if (stats[0].penalties > stats[1].penalties)
                    {
                        winner = teams[0];
                    }
                    else
                    {
                        winner = teams[1];
                    }
                    return winner;
                }
            }

            while (stats[0].penalties == stats[1].penalties)
            {
                int[] temp; // pomaga zmiennej round w zapisaniu wyniku

                // tura druzyny nr 1
                if (rand.Next(0, 100) - teams[0].Power < 85) //85% - 89% szansy
                {
                    stats[0].penalties += 1;
                    score[0] += 1;
                }

                // tura druzyny nr 2
                if (rand.Next(0, 100) - teams[1].Power < 85) //85% - 89% szansy
                {
                    stats[1].penalties += 1;
                    score[1] += 1;
                }

                // zapisujemy wynik
                temp = (int[])score.Clone();
                listOfScores.Add(temp);
            }
            // wskazujemy zwycieska druzyne
            if (stats[0].penalties > stats[1].penalties)
            {
                winner = teams[0];
            }
            else
            {
                winner = teams[1];
            }
            return winner;
        }

        public override Team PlayGame(int startTime = 0, int endTime = 0)
        {
            Team winner;

            // rozgrywamy mecz w regulaminowym czasie
            Team regularTime = base.PlayGame(0, 90);

            if (regularTime == null)
            {
                // rozgrywamy dogrywke 2 x 15min
                Team extraTime = base.PlayGame(90, 120);
                if (extraTime == null)
                {
                    Team penalties = PenaltyKicks();
                    winner = penalties;
                }
                else
                {
                    winner = extraTime;
                }
                return winner;
            }
            else
            {
                winner = regularTime;
                return winner;
            }
        }
    }
}