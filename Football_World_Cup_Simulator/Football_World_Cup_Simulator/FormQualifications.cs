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
    public partial class FormQualifications : Form
    {
        // format zastosowany w listBoxach (element, odstep)
        String listBoxFormat = "{0, -22} {1, -10} {2}";
        String listBoxFormat_2 = "{0, -22} {1, -2} {2, -10} {3, -2} {4, -10} {5, -2} {6, -10} {7, -2} {8, -10} {9, -2} {10, -10}";

        // listy z listboxami
        List<ListBox> lst_ChooseTeams;
        List<ListBox> lst_Pots;

        // zmienne pomocnicze
        int counterOfTeams = 0;
        int numberOfUEFA = 14, numberOfAFC = 5, numberOfCAF = 5, numberOfCONMEBOL = 5, numberOfCONCACAF = 3;


        public FormQualifications()
        {
            InitializeComponent();

            lst_Pots = new List<ListBox>() { lst_Pot1, lst_Pot2, lst_Pot3, lst_Pot4 };
            lst_ChooseTeams = new List<ListBox>() { lst_UEFA_region, lst_AFC_region, lst_CAF_region, lst_CONCACAF_region, lst_CONMEBOL_region };
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormQualifications_Load(object sender, EventArgs e)
        {
            InitializedLabelHeaders();
            InitializedAllTeamToListbox();
        }

        private void InitializedLabelHeaders()
        {
            lbl_TeamsCounter.Text = String.Format(listBoxFormat, "Liczba wybranych drużyn:", counterOfTeams.ToString(), "");
            lbl_information1.Text = String.Format(listBoxFormat, "Kraj", "Strefa", "Siła");
            lbl_information2.Text = String.Format(listBoxFormat, "Kraj", "Strefa", "Siła");
            lbl_information3.Text = String.Format(listBoxFormat, "Kraj", "Strefa", "Siła");
            lbl_TeamsCounter.Text = String.Format(listBoxFormat_2, "Dostępne drużyny:", "UEFA =", numberOfUEFA.ToString(), "AFC=", numberOfCAF.ToString(), 
                "CAF=", numberOfCAF.ToString(), "CONMEBOL=", numberOfCONMEBOL.ToString(), "CONCACAF=", numberOfCONCACAF.ToString());
        }

        private void InitializedAllTeamToListbox()
        {
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Palestine", "AFC", "3"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Iran", "AFC", "3"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "South Korea", "AFC", "3"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Syria", "AFC", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Uzbekistan", "AFC", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "China PR", "AFC", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Qatar", "AFC", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Japan", "AFC", "3"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Saudi Arabia", "AFC", "3"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Australia", "AFC", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "United Arab Emirates", "AFC", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Iraq", "AFC", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Thailand", "AFC", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Tunisia", "CAF", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "DR Congo", "CAF", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Libya", "CAF", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Guinea", "CAF", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Morocco", "CAF", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Ivory Coast", "CAF", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Gabon", "CAF", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Mali", "CAF", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Egypt", "CAF", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Uganda", "CAF", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Ghana", "CAF", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Congo", "CAF", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Nigeria", "CAF", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Zambia", "CAF", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Cameroon", "CAF", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Algeria", "CAF", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Senegal", "CAF", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Burkina Faso", "CAF", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Cape Verde", "CAF", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "South Africa", "CAF", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Mexico", "CONCACAF", "3"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Costa Rica", "CONCACAF", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Panama", "CONCACAF", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Honduras", "CONCACAF", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "United States", "CONCACAF", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Trinidad and Tobago", "CONCACAF", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Brazil", "CONMEBOL", "4"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Uruguay", "CONMEBOL", "3"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Argentina", "CONMEBOL", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Colombia", "CONMEBOL", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Peru", "CONMEBOL", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Chile", "CONMEBOL", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Paraguay", "CONMEBOL", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Ecuador", "CONMEBOL", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Bolivia", "CONMEBOL", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Venezuela", "CONMEBOL", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "New Zealand", "OFC", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "New Caledonia", "OFC", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Fiji", "OFC", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Solomon Islands", "OFC", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Tahiti", "OFC", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Papua New Guinea", "OFC", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "France", "UEFA", "4"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Sweden", "UEFA", "3"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Netherlands", "UEFA", "3"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Bulgaria", "UEFA", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Luxembourg", "UEFA", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Belarus", "UEFA", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Serbia", "UEFA", "4"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Republic of Ireland", "UEFA", "3"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Wales", "UEFA", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Austria", "UEFA", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Georgia", "UEFA", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Moldova", "UEFA", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Spain", "UEFA", "4"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Italy", "UEFA", "4"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Albania", "UEFA", "3"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Macedonia", "UEFA", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Liechtenstein", "UEFA", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Portugal", "UEFA", "4"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Switzerland", "UEFA", "3"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Hungary", "UEFA", "3"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Faroe Islands", "UEFA", "3"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Latvia", "UEFA", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Andorra", "UEFA", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Denmark", "UEFA", "3"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Montenegro", "UEFA", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Romania", "UEFA", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Armenia", "UEFA", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Kazakhstan", "UEFA", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Belgium", "UEFA", "4"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Greece", "UEFA", "3"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Bosnia and Herzegovina", "UEFA", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Estonia", "UEFA", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Cyprus", "UEFA", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Gibraltar", "UEFA", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Northern Ireland", "UEFA", "3"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Czech Republic", "UEFA", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Norway", "UEFA", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Azerbaijan", "UEFA", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "San Marino", "UEFA", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "England", "UEFA", "4"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Slovakia", "UEFA", "3"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Scotland", "UEFA", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Slovenia", "UEFA", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Lithuania", "UEFA", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Malta", "UEFA", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Iceland", "UEFA", "4"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Croatia", "UEFA", "3"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Ukraine", "UEFA", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Turkey", "UEFA", "2"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Finland", "UEFA", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Kosovo", "UEFA", "1"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Russia", "UEFA", "3"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Israel", "UEFA", "4"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Poland", "UEFA", "4"));
            lst_AllTeams.Items.Add(String.Format(listBoxFormat, "Germany", "UEFA", "4"));
        }

        /// <summary>
        /// Przycisk wywolujacy funkcje sortujaca i przypisy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Pots_Click(object sender, EventArgs e)
        {
            // uzupelniamy koszyki w oparciu o druzyny ze stref
            if (counterOfTeams == 32)
            {
                // czyscimy dane w koszykach, jesli cos zawieraja
                foreach (var Pot in lst_Pots)
                {
                    Pot.Items.Clear();
                }

                for (int power = 4; power > 0 ; power--)
                {
                    foreach (var region in lst_ChooseTeams)
                    {
                        foreach (var item in region.Items)
                        {
                            string text = item.ToString();

                            if (text.Contains(power.ToString()) == true)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    if (lst_Pots[i].Items.Count < 8)
                                    {
                                        lst_Pots[i].Items.Add(text);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie wybrałeś wszystkich wymaganych drużyn, żeby przejść dalej.");
                return;
            }
        }


        /// <summary>
        /// Przycisk do wybrania zaznaczonych elementow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_select_Click(object sender, EventArgs e)
        {
            int count = lst_AllTeams.SelectedItems.Count;

            // dla wszystkich zaznaczonych elementow wykonaj przeniesienie
            for (int i = 0; i < count && (lst_AFC_region.Items.Count + lst_CAF_region.Items.Count  + lst_CONCACAF_region.Items.Count +
                lst_CONMEBOL_region.Items.Count + lst_UEFA_region.Items.Count) < 32; i++)
            {
                var a1 = lst_AllTeams.SelectedItem;
                var b = lst_AllTeams.SelectedIndex;

                string a = a1.ToString();


                if (a.Contains("UEFA") == true && lst_UEFA_region.Items.Count < 14)
                {
                    lst_UEFA_region.Items.Add(a);
                    numberOfUEFA--;
                }
                else if (a.Contains("AFC") == true && lst_AFC_region.Items.Count < 5)
                {
                    lst_AFC_region.Items.Add(a);
                    numberOfAFC--;
                }
                else if (a.Contains("CAF") == true && a.Contains("CONCACAF") == false && lst_CAF_region.Items.Count < 5)
                {
                    lst_CAF_region.Items.Add(a);
                    numberOfCAF--;
                }
                else if (a.Contains("CONMEBOL") == true && lst_CONMEBOL_region.Items.Count < 5)
                {
                    lst_CONMEBOL_region.Items.Add(a);
                    numberOfCONMEBOL--;
                }
                else if (a.Contains("CONCACAF") == true && lst_CONCACAF_region.Items.Count < 3)
                {
                    lst_CONCACAF_region.Items.Add(a);
                    numberOfCONCACAF--;
                }
                else
                {
                    lst_AllTeams.SetSelected(b, false);
                    continue;
                }
                lst_AllTeams.Items.RemoveAt(b);
                counterOfTeams++;
            }
            lbl_TeamsCounter.Text = String.Format(listBoxFormat_2, "Dostępne drużyny:", "UEFA =", numberOfUEFA.ToString(), "AFC=", numberOfAFC.ToString(),
                "CAF=", numberOfCAF.ToString(), "CONMEBOL=", numberOfCONMEBOL.ToString(), "CONCACAF=", numberOfCONCACAF.ToString());
        }

        /// <summary>
        /// Przycisk do wycofywania zaznaczonych zespolow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_back_Click(object sender, EventArgs e)
        {
            foreach (var selectedListbox in lst_ChooseTeams)
            {
                int count = selectedListbox.SelectedItems.Count;

                // dla wszystkich zaznaczonych elementow, wykonaj przeniesienie
                for (int i = 0; i < count; i++)
                {
                    var a1 = selectedListbox.SelectedItem;
                    string a = a1.ToString();

                    var b = selectedListbox.SelectedIndex;

                    lst_AllTeams.Items.Add(a);
                    selectedListbox.Items.RemoveAt(b);

                    if (a.Contains("UEFA") == true)
                    {
                        numberOfUEFA++;
                    }
                    else if (a.Contains("AFC") == true)
                    {
                        numberOfAFC++;
                    }
                    else if (a.Contains("CAF") == true && a.Contains("CONCACAF") == false)
                    {
                        numberOfCAF++;
                    }
                    else if (a.Contains("CONMEBOL") == true)
                    {
                        numberOfCONMEBOL++;
                    }
                    else if (a.Contains("CONCACAF") == true)
                    {
                        numberOfCONCACAF++;
                    }
                    counterOfTeams--;
                }
                lbl_TeamsCounter.Text = String.Format(listBoxFormat_2, "Dostępne drużyny:", "UEFA =", numberOfUEFA.ToString(), "AFC=", numberOfAFC.ToString(),
                    "CAF=", numberOfCAF.ToString(), "CONMEBOL=", numberOfCONMEBOL.ToString(), "CONCACAF=", numberOfCONCACAF.ToString());
            }
        }


        private void Btn_GroupStage_Click(object sender, EventArgs e)
        {
            if (lst_Pot1.Items.Count + lst_Pot2.Items.Count + lst_Pot3.Items.Count  + lst_Pot4.Items.Count != 32)
            {
                MessageBox.Show("Koszyki są puste. Najpierw wybierz drużyny.");
                return;
            }

            List<Team> teams = new List<Team>();

            foreach (var selectedListbox in lst_Pots)
            {
                foreach (var item in selectedListbox.Items)
                {
                    // dzielimy łańcuch znaków na tablicę wartości bez spacji
                    char[] delimiter = new char[] { ' ' };
                    string[] values = item.ToString().Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

                    // łączymy nazwy kilku krajów ( maks 3)
                    string name = "";
                    int count = 0;
                    count = values.Count();

                    switch (count)
                    {
                        case 3:
                            name = values[0];
                            break;
                        case 4:
                            name = values[0] + " " + values[1];
                            break;
                        case 5:
                            name = values[0] + " " + values[1] + " " + values[2];
                            break;
                        default:
                            MessageBox.Show("Wystapił błąd");
                            return;
                    }

                    string association = values[count - 2];
                    int power = int.Parse(values[count - 1]);

                    Team team = new Team(name, association, power);
                    teams.Add(team);
                }
            }

            // otwieramy formularz fazy grupowej
            FormGroupStage newForm = new FormGroupStage(teams);
            newForm.Show();
        }


        /// <summary>
        /// Funkcja generyczna do odznaczania rekorow w listboxach
        /// </summary>
        private void UnselectItems_DoubleClick(object sender, EventArgs e)
        {
            ListBox listbox;
            if (sender is ListBox)
            {
                listbox = sender as ListBox;
                listbox.ClearSelected();
            }
        }
    }
}