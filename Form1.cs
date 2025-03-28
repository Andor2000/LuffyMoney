using LuffyMoney.Extensions;
using LuffyMoney.Models;

namespace LuffyMoney
{
    public partial class Form1 : Form
    {
        private List<Player> _playerList = new List<Player>();
        private List<History> _historyList = new List<History>();


        public Form1()
        {
            InitializeComponent();
            LoadPlayers();
            InitializeUI();
        }

        private void InitializeUI()
        {
            LoadPlayersInMainGris(_playerList);
        }

        private void LoadPlayers()
        {
            // ��������� ������� (��������� ������)
            _playerList = new List<Player>
            {
                new Player { Id = 1, Nick = "�����1", BuyGold = 1000000, SpentChM = 500, AvailableChm = 2000 },
                new Player { Id = 2, Nick = "�����2", BuyGold = 2000000, SpentChM = 1000, AvailableChm = 3000 },
                new Player { Id = 3, Nick = "�����3", BuyGold = 500000, SpentChM = 300, AvailableChm = 1500 }
            };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateMainGrid();
        }

        private void UpdateMainGrid()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                LoadPlayersInMainGris(_playerList);
            }
            else
            {
                var players = _playerList.Where(x => x.Nick.Contains(textBox1.Text, StringComparison.CurrentCultureIgnoreCase)).ToList();
                LoadPlayersInMainGris(players);
            }
        }

        /// <summary>
        /// �������� ������� � ������� �������.
        /// </summary>
        /// <param name="players">������.</param>
        private void LoadPlayersInMainGris(List<Player> players)
        {
            dataGridView1.Rows.Clear();
            players = players.OrderBy(x => x.Nick).ToList();
            foreach (var player in players)
            {
                // ��������� ����� ������ � �������
                int rowIndex = dataGridView1.Rows.Add();

                // ��������� ������ ������ ��� ���� ������
                dataGridView1.Rows[rowIndex].Cells[0].Value = player.Nick;          // ���
                dataGridView1.Rows[rowIndex].Cells[1].Value = player.BuyGold;       // ������� �����
                dataGridView1.Rows[rowIndex].Cells[2].Value = player.SpentChM;      // ��������� ��
                dataGridView1.Rows[rowIndex].Cells[3].Value = player.AvailableChm;  // �������� ��
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nick = textBox2.Text.Trim();
            if (nick.IsNullOrDefault())
            {
                MessageBox.Show("������� ���");
                return;
            }

            if (_playerList.Any(x => x.Nick.ToLower(System.Globalization.CultureInfo.CurrentCulture) == nick.ToLower()))
            {
                MessageBox.Show("����� � ����� ����� ��� ����������");
            }


            var player = new Player { Nick = nick };
            _playerList.Add(player);

            MessageBox.Show("����� ������� ��������");
            textBox2.Text = string.Empty;
            UpdateMainGrid();
            // todo
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nick = textBox2.Text.Trim();
            if (nick.IsNullOrDefault())
            {
                MessageBox.Show("������� ���");
                return;
            }

            var player = _playerList.FirstOrDefault(x => x.Nick.ToLower(System.Globalization.CultureInfo.CurrentCulture) == nick.ToLower());
            if ((player?.Id).IsNullOrDefault())
            {
                MessageBox.Show("����� �� ������");
            }

            if (_historyList.Any(x => x.PlayerId == player.Id))
            {
                MessageBox.Show("������� ����� ������� ������ ������");
            }

            // todo
            _playerList.Remove(player!);
            UpdateMainGrid();
        }
    }
}
