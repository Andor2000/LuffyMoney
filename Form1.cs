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
            // Загружаем игроков (примерные данные)
            this._playerList = new List<Player>
            {
                new Player { Id = 1, Nick = "Игрок1", BuyGold = 1000000, SpentChM = 500, AvailableChm = 2000 },
                new Player { Id = 2, Nick = "Игрок2", BuyGold = 2000000, SpentChM = 1000, AvailableChm = 3000 },
                new Player { Id = 3, Nick = "Игрок3", BuyGold = 500000, SpentChM = 300, AvailableChm = 1500 }
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
        /// Загрузка игроков в главную таблицу.
        /// </summary>
        /// <param name="players">Игрики.</param>
        private void LoadPlayersInMainGris(List<Player> players)
        {
            dataGridView1.Rows.Clear();
            players = players.OrderBy(x => x.Nick).ToList();
            foreach (var player in players)
            {
                // Добавляем новую строку в таблицу
                int rowIndex = dataGridView1.Rows.Add();

                // Заполняем ячейки данных для этой строки
                dataGridView1.Rows[rowIndex].Cells[0].Value = player.Nick;          // Ник
                dataGridView1.Rows[rowIndex].Cells[1].Value = player.BuyGold;       // Куплено голды
                dataGridView1.Rows[rowIndex].Cells[2].Value = player.SpentChM;      // Потрачено чм
                dataGridView1.Rows[rowIndex].Cells[3].Value = player.AvailableChm;  // Доступно чм
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nick = textBox2.Text.Trim();
            if (nick.IsNullOrDefault())
            {
                MessageBox.Show("Введите ник");
                return;
            }

            if (_playerList.Any(x => x.Nick.ToLower(System.Globalization.CultureInfo.CurrentCulture) == nick.ToLower()))
            {
                MessageBox.Show("Игрок с таким ником уже существует");
            }


            var player = new Player { Nick = nick };
            _playerList.Add(player);

            MessageBox.Show("Игрок успешно добавлен");
            textBox2.Text = string.Empty;
            UpdateMainGrid();
            // todo
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nick = textBox2.Text.Trim();
            if (nick.IsNullOrDefault())
            {
                MessageBox.Show("Введите ник");
                return;
            }

            var player = _playerList.FirstOrDefault(x => x.Nick.ToLower(System.Globalization.CultureInfo.CurrentCulture) == nick.ToLower())
                .ThrowOnCondition(x => (x?.Id).IsNullOrDefault(), "Игрок не найден")
                .ThrowOnCondition(x => _historyList.Any(y => y.PlayerId == x.Id), "Сначала нужно удалить сторию игрока");

            // todo
            _playerList.Remove(player!);
            MessageBox.Show("Игрок успешно удален");
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

            // Сохраняем текущий текст и позицию курсора
            string currentText = cb.Text;
            int selectionStart = cb.SelectionStart;

            // Фильтруем список на основе currentText

            var filteredPlayers = string.IsNullOrEmpty(currentText)
                ? _playerList
                : _playerList.Where(p => p.Nick.Contains(currentText)).ToList();

            bindingSource1.DataSource = !filteredPlayers.IsNullOrDefault() 
                ? filteredPlayers
                : new List<Player> { new Player { } };

            // Восстанавливаем текст и позицию курсора
            cb.Text = currentText;
            cb.SelectionStart = selectionStart;
            cb.SelectionLength = 0;

            // Открываем выпадающий список, если есть совпадения
            cb.DroppedDown = !filteredPlayers.IsNullOrDefault();
        }
    }
}
