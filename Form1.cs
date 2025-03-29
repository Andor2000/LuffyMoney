using LuffyMoney.Extensions;
using LuffyMoney.Models;
using System.Windows.Forms;

namespace LuffyMoney
{
    public partial class Form1 : Form
    {
        private List<Player> _playerList = new List<Player>();
        private List<History> _historyList = new List<History>();


        public Form1()
        {
            this.InitializeComponent();
            this.LoadPlayers();
            this.InitializeUI();
        }

        private void InitializeUI()
        {
            this.LoadPlayersInMainGris(this._playerList);
        }

        private void LoadPlayers()
        {
            // ��������� ������� (��������� ������)
            this._playerList = new List<Player>
            {
                new Player { Id = 1, Nick = "�����1", BuyGold = 1000000, SpentChM = 500, AvailableChm = 2000 },
                new Player { Id = 2, Nick = "�����2", BuyGold = 2000000, SpentChM = 1000, AvailableChm = 3000 },
                new Player { Id = 3, Nick = "�����3", BuyGold = 500000, SpentChM = 300, AvailableChm = 1500 }
            };

            this.bindingSource1.DataSource = this._playerList;
            this.SetComboBox(this.comboBox1);
            this.SetComboBox(this.comboBox2);
            this.SetComboBox(this.comboBox3);
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

            var player = _playerList.FirstOrDefault(x => x.Nick.ToLower(System.Globalization.CultureInfo.CurrentCulture) == nick.ToLower())
                .ThrowOnCondition(x => (x?.Id).IsNullOrDefault(), "����� �� ������")
                .ThrowOnCondition(x => _historyList.Any(y => y.PlayerId == x.Id), "������� ����� ������� ������ ������");

            // todo
            _playerList.Remove(player!);
            MessageBox.Show("����� ������� ������");
            textBox2.Text = string.Empty;
            UpdateMainGrid();
        }


        private void SetComboBox(ComboBox cb)
        {
            cb.DataSource = bindingSource1;
            cb.DisplayMember = "Nick";
            cb.ValueMember = "Id";
            cb.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            var cb = sender as ComboBox;
            if (cb == null) return;

            // ��������� ������� ����� � ������� �������
            string currentText = cb.Text;
            int selectionStart = cb.SelectionStart;

            // ��������� ������ �� ������ currentText

            var filteredPlayers = string.IsNullOrEmpty(currentText)
                ? _playerList
                : _playerList.Where(p => p.Nick.Contains(currentText)).ToList();

            bindingSource1.DataSource = !filteredPlayers.IsNullOrDefault() 
                ? filteredPlayers
                : new List<Player> { new Player { } };

            // ��������������� ����� � ������� �������
            cb.Text = currentText;
            cb.SelectionStart = selectionStart;
            cb.SelectionLength = 0;

            // ��������� ���������� ������, ���� ���� ����������
            cb.DroppedDown = !filteredPlayers.IsNullOrDefault();
        }
    }
}
