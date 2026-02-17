using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Text.Json;

namespace GCubeGame
{
    public partial class MainForm : Form
    {
        // ゲームの核
        private Random rnd = new Random();  // ランダムな数値を生成するためのRandomクラスのインスタンス
        private Color[] cubeColors =
        {
             Color.White,   // 空のキューブは白色
             Color.FromArgb(255, 83, 83),     // 数字1のキューブは赤色
             Color.FromArgb(0, 255, 0),   // 数字2のキューブは緑色
             Color.FromArgb(43, 211, 223)     // 数字3のキューブは青色
        };

        // ゲームの状態を表す変数
        private int count = 0;
        private int[] cubelist = new int[9];    // キューブの数字を表す
        private int[] rawcubelist = new int[9]; // キューブの数字を表す（判定用）
        private int[] cubeNextList = new int[2];   // キューブの次とその次に出現する数字を表す
        private bool gameOver = false;    // ゲームオーバーかどうかを表すフラグ
        private bool gameClear = false; // ゲームクリアかどうかを表すフラグ
        private bool isScoreSaved = false; // スコアが保存されたかどうかを表すフラグ
        private bool isPrepareCompleted = false;    // 準備が終わったかどうか

        public MainForm()
        {
            for (int i = 0; i < cubelist.Length; i++)
            {
                cubelist[i] = 0;
            }
            InitializeComponent();
        }

        private void SetCubeStyle(Control cube, int index)
        {
            cube.BackColor = cubeColors[cubelist[index]];
            cube.Text = cubelist[index].ToString();
        }

        private void setCube()
        {
            // キューブ設定
            // フィールド上キューブ
            SetCubeStyle(Tile0, 0);
            SetCubeStyle(Tile1, 1);
            SetCubeStyle(Tile2, 2);
            SetCubeStyle(Tile3, 3);
            SetCubeStyle(Tile4, 4);
            SetCubeStyle(Tile5, 5);
            SetCubeStyle(Tile6, 6);
            SetCubeStyle(Tile7, 7);
            SetCubeStyle(Tile8, 8);

            // セカンド、サード
            SecondCube.BackColor = cubeColors[cubeNextList[0]]; // セカンドの色を変える
            SecondCube.Text = cubeNextList[0].ToString();   // セカンドのテキストを変える
            ThirdCube.BackColor = cubeColors[cubeNextList[1]];  // サードの色を変える
            ThirdCube.Text = cubeNextList[1].ToString();    // サードのテキストを変える
            ScoreDisp.Text = count.ToString();  // スコアを更新
            if (!cubelist.Contains(0))  // ゲームオーバー判定
            {
                GameStatusPanel.Text = "GAME OVER";
                GameStatusPanel.BackColor = cubeColors[1];  // 赤色
                GameStatusPanel.Visible = true; // 表示する
                gameOver = true;    // ゲームオーバーを有効
            }
            if (!cubelist.Contains(1) && !cubelist.Contains(2) && !cubelist.Contains(3))    // ゲームクリア判定
            {
                GameStatusPanel.Text = "GAME CLEAR";
                GameStatusPanel.BackColor = cubeColors[2];  // 緑色
                GameStatusPanel.Visible = true; // 表示する
                gameClear = true;   // ゲームクリアを有効
                if (MessageBox.Show("Would you like to save your score?","info",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string name = Interaction.InputBox("Please enter your name here!", "GCG ScoreBoard", "");
                    Program.scoreboard.Add(name, count);
                    SaveScoreBoard(); // スコアボードを保存
                }
            }
        }

        private void ResetGame()
        {
            // cubelistの表示
            Debug.WriteLine(string.Join(',', cubelist));

            // ゲーム終了判定を無効化
            gameClear = false;
            gameOver = false;

            // scoreをリセット
            count = 0;

            GameStatusPanel.Visible = false;    // ステータスパネルを非表示

            int kazu = 0;
            for (int i = 0; i < 9; i++) // 9というのはキューブの総配置数
            {
                if (kazu != 2 && rnd.Next(0, 3) == 0)
                {
                    int num = rnd.Next(1, 3);
                    cubelist[i] = num;
                    kazu++;
                }
                else cubelist[i] = 0;
                if (i == 8 && kazu < 2) i--; ;
            }
            cubeNextList[0] = rnd.Next(1, 3);   // 次に出現するキューブの数字をランダムに生成
            cubeNextList[1] = rnd.Next(1, 3);   // 次の次に出現するキューブの数字をランダムに生成
            if (GameStatusPanel.Visible)
            {
                GameStatusPanel.Visible = false;   // ゲームステータスパネルを非表示にする
            }
            isScoreSaved = false; // スコアが保存されたかどうかをリセット

            // cubelistの表示
            Debug.WriteLine(string.Join(',', cubelist));

            setCube();
        }

        private void Logic(int index)
        {
            if (!gameOver && !gameClear)
            {
                if (cubelist[index] == 0)
                {
                    // キューブを配置
                    cubelist[index] = cubeNextList[0];
                    cubeNextList[0] = cubeNextList[1];
                    cubeNextList[1] = rnd.Next(1, 4);  // 1-3の範囲
                    Debug.WriteLine(string.Join(',', cubelist));

                    // 配置後の状態で判定（配列を値コピー）
                    rawcubelist = (int[])cubelist.Clone();
                    Debug.WriteLine($"raw: {string.Join(',', rawcubelist)}");

                    // 横（X方向）の判定
                    CheckAndClearLine(0, 1, 2);
                    CheckAndClearLine(3, 4, 5);
                    CheckAndClearLine(6, 7, 8);

                    // 縦（Y方向）の判定
                    CheckAndClearLine(0, 3, 6);
                    CheckAndClearLine(1, 4, 7);
                    CheckAndClearLine(2, 5, 8);

                    // 斜めの判定
                    CheckAndClearLine(0, 4, 8);
                    CheckAndClearLine(2, 4, 6);

                    count++;  // カウントを1増やす

                    // 判定結果をcubelistに反映
                    cubelist = rawcubelist;

                    setCube();
                }
            }
        }

        private void CheckAndClearLine(int idx1, int idx2, int idx3)
        {
            // 全て0の場合は判定しない
            if (rawcubelist[idx1] == 0 || rawcubelist[idx2] == 0 || rawcubelist[idx3] == 0)
                return;

            // 全て同じ数字
            if (rawcubelist[idx1] == rawcubelist[idx2] && rawcubelist[idx2] == rawcubelist[idx3])
            {
                rawcubelist[idx1] = rawcubelist[idx2] = rawcubelist[idx3] = 0;
                return;
            }

            // 昇順の連番 (1-2-3 または 2-3-4)
            if (rawcubelist[idx1] + 1 == rawcubelist[idx2] && rawcubelist[idx2] + 1 == rawcubelist[idx3])
            {
                rawcubelist[idx1] = rawcubelist[idx2] = rawcubelist[idx3] = 0;
                return;
            }

            // 降順の連番 (3-2-1 または 4-3-2)
            if (rawcubelist[idx1] - 1 == rawcubelist[idx2] && rawcubelist[idx2] - 1 == rawcubelist[idx3])
            {
                rawcubelist[idx1] = rawcubelist[idx2] = rawcubelist[idx3] = 0;
                return;
            }
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

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // スコアボードの読み込み
            LoadScoreBoard();

            // ゲーム初期化
            ResetGame();
        }

        private void TileA1_Click(object sender, EventArgs e)
        {
            Logic(0);
        }

        private void TileA2_Click(object sender, EventArgs e)
        {
            Logic(1);
        }

        private void TileA3_Click(object sender, EventArgs e)
        {
            Logic(2);
        }

        private void TileB1_Click(object sender, EventArgs e)
        {
            Logic(3);
        }

        private void TileB2_Click(object sender, EventArgs e)
        {
            Logic(4);
        }

        private void TileB3_Click(object sender, EventArgs e)
        {
            Logic(5);
        }

        private void TileC1_Click(object sender, EventArgs e)
        {
            Logic(6);
        }

        private void TileC2_Click(object sender, EventArgs e)
        {
            Logic(7);
        }

        private void TileC3_Click(object sender, EventArgs e)
        {
            Logic(8);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void RankingButton_Click(object sender, EventArgs e)
        {
            RankingForm rf = new RankingForm();
            rf.ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // cubelistとcubeNextListをまとめる
            List<int> rawraw = new List<int>();
            for (int i = 0; i < cubelist.Length; i++)
            {
                rawraw.Add(cubelist[i]);
            }
            rawraw.Add(cubeNextList[0]);
            rawraw.Add(cubeNextList[1]);

            // stringに変換
            string raw = JsonSerializer.Serialize(rawraw);
            var dialog = new SaveFileDialog();
            dialog.Filter = "GCubeGame JSON|*.gcgjson";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string? path = dialog.FileName;
                if (path == null) return;
                File.WriteAllText(path, raw);
                MessageBox.Show("Complete to save tiles!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "GCubeGame JSON|*.gcgjson";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string? path = dialog.FileName;
                if (path == null) return;
                string? raw = File.ReadAllText(path);
                List<int> rawraw = JsonSerializer.Deserialize<List<int>>(raw)
                    ?? new List<int>();
                for (int i = 0; i < cubelist.Length; i++)
                {
                    if (i < cubelist.Length)
                    {
                        cubelist[i] = rawraw[i];
                    }
                    else
                    {
                        cubeNextList[i - cubelist.Length] = rawraw[i];
                    }
                }
                setCube();
                MessageBox.Show("Complete to load tiles!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
