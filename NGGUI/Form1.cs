using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGGUI
{
    public partial class Numbers_Game : Form
    {
        
        private int[] selectedNumbers = new int[6];
        private int goal;
        private string solution;
        private System.Random rnd = new System.Random();
        private int result;
        int big;


        public Numbers_Game()
        {
            InitializeComponent();
            Game(2);
        }

        void newGameBtn_Click(Object sender,
                           EventArgs e)
        {
            Button clickedButton = (Button)sender;
            textBoxSolution.Clear();
            Game(big);
        }

        void submitBtn_Click(Object sender,
                           EventArgs e)
        {
            Button clickedButton = (Button)sender;
            solution = textBoxSolution.Text;
            if (!ValidSolution(solution))
            {
                ResultLable.Text = "Invalid solution";
                return;
            }
            result = Calculate(solution);

            ResultLable.Visible = true;
            ResultLable.Text = CalculateGameResult();

        }

        void numericUpDown_SelectBig(Object sender,
                           EventArgs e)
        {
            big = (int)numericUpDown1.Value;
        }




        private void Game(int big)
        {

            System.Windows.Forms.TextBox[] textBoxes = { selectedNumber1, selectedNumber2, selectedNumber3, selectedNumber4, selectedNumber5, selectedNumber6 };
            
            goal = rnd.Next(100, 1000);
            textBox8.Text = goal.ToString();

            SelectNumbers(big);//promeni kasnije

            int i = 0;
            foreach (System.Windows.Forms.TextBox tb in textBoxes)
            {
                tb.Text = selectedNumbers[i].ToString();
                tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                i++;
            }

            ResultLable.Visible = false;
            
        }

        public bool SelectNumbers(int big)
        {
            if (big > 4)
            {
                return false;
            }
            int small = 6 - big;
            for (int i = 0; i < small; i++)
            {
                selectedNumbers[i] = rnd.Next(1, 10);
                int exists = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (i != 0 && selectedNumbers[i] == selectedNumbers[j])
                        exists++;
                }
                if (exists >= 2)
                {
                    selectedNumbers[i] = 0;
                    i--;
                }

            }
            if (big == 4)
            {
                for (int i = 2; i < 6; i++)
                {
                    selectedNumbers[i] = 25 * (i - 1);
                }
            }
            else if (big == 3)
            {
                int notSelected = rnd.Next(1, 5);
                switch (notSelected)
                {
                    case 1:
                        selectedNumbers[3] = 50;
                        selectedNumbers[4] = 75;
                        selectedNumbers[5] = 100;
                        break;
                    case 2:
                        selectedNumbers[3] = 25;
                        selectedNumbers[4] = 75;
                        selectedNumbers[5] = 100;
                        break;
                    case 3:
                        selectedNumbers[3] = 25;
                        selectedNumbers[4] = 50;
                        selectedNumbers[5] = 100;
                        break;
                    case 4:
                        selectedNumbers[3] = 25;
                        selectedNumbers[4] = 50;
                        selectedNumbers[5] = 75;
                        break;
                    default:
                        selectedNumbers[3] = 25;
                        selectedNumbers[4] = 50;
                        selectedNumbers[5] = 100;
                        break;

                }
            }
            else
            {
                for (int i = small; i < big + small; i++)
                {
                    int selected = rnd.Next(1, 5);
                    switch (selected)
                    {
                        case 1:
                            selectedNumbers[i] = 25;
                            break;
                        case 2:
                            selectedNumbers[i] = 50;
                            break;
                        case 3:
                            selectedNumbers[i] = 75;
                            break;
                        case 4:
                            selectedNumbers[i] = 100;
                            break;
                        default:
                            i--;
                            break;
                    }
                    if (big == 2 && i != small && selectedNumbers[i] == selectedNumbers[i - 1]) i--;
                }
            }
            return true;
        }

        public string RemoveBrackets(ref string solution, ref int i)
        {
            string t = ""; i++;
            while (solution[i] != ')')
            {
                if (solution[i] == '(')
                {
                    RemoveBrackets(ref solution, ref i);
                    return solution;
                }
                t += solution[i];
                i++;
            }
            solution = solution.Replace('(' + t + ')', Calculate(t).ToString());
            i = -1;
            return solution;
        }

        public int Calculate(string solution)
        {
            int l = 0, r = 0;

            if (!(solution.Contains("(") || solution.Contains("-") || solution.Contains("+") ||
                solution.Contains("/") || solution.Contains("*"))) return Int32.Parse(solution);

            for (int i = 0; i < solution.Length; i++)
            {
                if (solution[i] == '(')
                {
                    solution = RemoveBrackets(ref solution, ref i);
                    if (!(solution.Contains("(") || solution.Contains("-") || solution.Contains("+") ||
                    solution.Contains("/") || solution.Contains("*"))) return Int32.Parse(solution);
                    continue;
                }
                if (!"+-/*".Contains(solution[i].ToString())) continue;
                switch (solution[i])
                {
                    case '+':
                        l = Calculate(solution.Remove(i));
                        r = Calculate(solution.Remove(0, i + 1));
                        return l + r;
                    case '-':
                        if (solution.Remove(0, i + 1).Contains("-") || solution.Remove(0, i + 1).Contains("+")) continue;
                        l = Calculate(solution.Remove(i));
                        r = Calculate(solution.Remove(0, i + 1));
                        return l - r;
                    case '*':
                        if (solution.Remove(0, i).Contains("+") || solution.Remove(0, i).Contains("-")) continue;
                        l = Calculate(solution.Remove(i));
                        r = Calculate(solution.Remove(0, i + 1));
                        return l * r;
                    case '/':
                        if (solution.Remove(0, i).Contains("+") || solution.Remove(0, i).Contains("-")) continue;
                        l = Calculate(solution.Remove(i));
                        r = Calculate(solution.Remove(0, i + 1));
                        return l / r;
                    default:
                        continue;
                }
            }
            return 0;
        }

        public bool ValidSolution(string solution)
        {
            if (!BracketsCorrect(solution)) return false;

            foreach (char c in solution)
                if (!"0123456789+-/*()".Contains(c.ToString())) return false;



            string[] t = solution.Split(new char[] { '/', '*', '+', '-', ')', '(' }, StringSplitOptions.RemoveEmptyEntries);
            bool acp = true;

            for (int i = 0; i < t.Length; i++)
            {
                for (int j = 0; j < selectedNumbers.Length; j++)
                {
                    if (System.Int32.Parse(t[i]) == selectedNumbers[j])
                    {
                        selectedNumbers[j] = 0;
                        acp = true;
                        break;
                    }
                    else acp = false;
                }
            }
            return acp;
        }

        public static bool BracketsCorrect(string s)
        {
            int nrBrackets = 0;
            foreach (char c in s)
            {
                if (c == '(') nrBrackets++;
                if (c == ')') nrBrackets--;
                if (nrBrackets < 0) return false;

            }
            if (nrBrackets == 0) return true;
            return false;
        }

        public string CalculateGameResult()
        {
            switch (Math.Abs(goal - result))
            {
                case 0:
                    return $"{ result }\nYou've scored 10 points!";
                case 1:
                    return $"{ result }\nYou've scored 7 points!";
                case 2:
                    return $"{ result }\nYou've scored 5 points!";
                case 3:
                    return $"{ result }\nYou've scored 3 points.";
                default:
                    return  $"{ result }\nSorry, not close enough to the goal. You've scored 0 points.";
            }
        }


        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button newGameButton;
    }

}

