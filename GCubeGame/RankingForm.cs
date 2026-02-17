using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCubeGame
{
    public partial class RankingForm : Form
    {
        public RankingForm()
        {
            InitializeComponent();
        }
        private void SaveScoreBoard()   // スコアボードの書き込み
        {
            string raw = JsonSerializer.Serialize(Program.scoreboard);
            File.WriteAllText("./scoreboard.json", raw);
        }
        private int LoadScoreBoard()    // スコアボードの読み込み
        {
            if (File.Exists("./scoreboard.json"))
            {
                string raw = File.ReadAllText("./scoreboard.json");
                Program.scoreboard = JsonSerializer.Deserialize<Dictionary<string, int>>(raw)
                    ?? new Dictionary<string, int>();
                return 0;
            }
            else
            {
                SaveScoreBoard();
                return 1;
            }
        }

        private void RankingForm_Shown(object sender, EventArgs e)
        {
            LoadScoreBoard();   // スコアボードの読み込み
            int i = 1;
            foreach (var dict in Program.scoreboard.OrderBy(c => c.Value))
            {
                listBox1.Items.Add($"{i}: {dict.Key} ({dict.Value.ToString()})");
                i++;
            }
        }
    }
}
