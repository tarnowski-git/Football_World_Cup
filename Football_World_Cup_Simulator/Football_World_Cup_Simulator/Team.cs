using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCupSimulator2
{
    /// <summary>
    /// Klasa zawiera statystki danej druzyny
    /// </summary>
    public class Team
    {
        // podstawowe informacje o druzynie
        public string Confederation { get; private set; }
        public string Name { get; private set; }
        public int Power { get; private set; }

        // podstawowe statystki druzyny
        public int Won { get; private set; } = 0;
        public int Drawn { get; private set; } = 0;
        public int Lost { get; private set; } = 0;
        public int GoalsFor { get; private set; } = 0;
        public int GoalsAgainst { get; private set; } = 0;
        public int Points { get; private set; } = 0;


        // konstruktor argumentowy
        public Team(string _Name, string _Confederation, int _Power = 1)
        {
            Name = _Name;
            Confederation = _Confederation;
            Power = _Power;
        }

        // funkcja aktualizujaca wynik po kazdym meczu
        public void UpdateScore(int GoalsScored, int GoalsLost)
        {
            GoalsFor = GoalsFor + GoalsScored;
            GoalsAgainst = GoalsAgainst + GoalsLost;

            if (GoalsScored > GoalsLost)
            {
                Won = Won + 1;
                Points = Points + 3;
            }
            else if (GoalsScored < GoalsLost)
            {
                Lost = Lost + 1;
            }
            else
            {
                Drawn = Drawn + 1;
                Points = Points + 1;
            }
        }
    }
}
