using LuffyMoney.Extensions;
using LuffyMoney.Models;
using System.Globalization;

namespace LuffyMoney
{
    public partial class Form1 : Form
    {
        private List<Player> _playerList = new List<Player>();
        private List<History> _historyList = new List<History>();

        private static double CursRub;

        private static int CursChm;

        public int l, n;

        public Form1()
        {
            this.InitializeComponent();
            this.LoadPlayers();
            this.InitializeUI();
        }

        private void InitializeUI()
        {
            this.LoadPlayersInMainGris(this._playerList);
            this.LoadHistoryGris();
            CursRub = 2;
            CursChm = 58;

            textBox5.Text = CursRub.ToString();
            textBox6.Text = CursChm.ToString();
            this.UpdateLabelCurs(label9);
            this.UpdateLabelCurs(label10);

            var firstPlayer = this._playerList.FirstOrDefault(new Player());
            comboBox2.Text = firstPlayer.Nick;
            label11.Text = GetLabel11(firstPlayer.AvailableChm);
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

                // .ToString("N0"); // "1,000,000"
                // Заполняем ячейки данных для этой строки
                dataGridView1.Rows[rowIndex].Cells[0].Value = player.Nick;                           // Ник
                dataGridView1.Rows[rowIndex].Cells[1].Value = player.BuyGold.ToString("N0");         // Куплено голд
                dataGridView1.Rows[rowIndex].Cells[2].Value = player.SpentChM.ToString("N0"); ;      // Потрачено чм
                dataGridView1.Rows[rowIndex].Cells[3].Value = player.AvailableChm.ToString("N0"); ;  // Доступно чм
            }
        }

        private void LoadHistoryGris()
        {
            dataGridView2.Rows.Clear();
            var histories = _historyList.OrderByDescending(x => x.Date).ToList();

            foreach (var history in histories)
            {
                int rowIndex = dataGridView2.Rows.Add();

                // .ToString("N0"); // "1,000,000"
                // Заполняем ячейки данных для этой строки
                dataGridView2.Rows[rowIndex].Cells[0].Value = history.Id;
                dataGridView2.Rows[rowIndex].Cells[1].Value = history.Player.Nick;
                dataGridView2.Rows[rowIndex].Cells[2].Value = history.Date.ToString("yyyy-MM-dd HH:mm:ss");
                dataGridView2.Rows[rowIndex].Cells[3].Value = history.IsBuyGold ? "Куплен голд" : "Потрачено чм";
                dataGridView2.Rows[rowIndex].Cells[4].Value = history.Count.ToString("N0");
                dataGridView2.Rows[rowIndex].Cells[5].Value = $"{(history.IsBuyGold ? "+" : "-")} {history.GetChM.ToString("N0")}чм";
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


            var result = _playerList.Any(x => x.Nick.ToLower(CultureInfo.CurrentCulture) == nick.ToLower())
                .ThrowOnCondition(x => x, "Игрок с таким ником уже существует");
            if (result)
            {
                return;
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

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Отклоняем ввод, если это не цифра и не управляющая клавиша
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V) // Проверяем Ctrl + V
            {
                string clipboardText = Clipboard.GetText();
                if (!clipboardText.All(char.IsDigit)) // Если в буфере есть нецифры – отменяем вставку
                {
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Получаем символ разделителя (например, запятая для ru-RU)
            char separator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            // Разрешаем управляющие символы (Backspace, Delete и т.п.)
            if (char.IsControl(e.KeyChar))
                return;

            // Если вводится цифра, проверяем, если после разделителя уже 2 символа
            if (char.IsDigit(e.KeyChar))
            {
                int sepIndex = textBox5.Text.IndexOf(separator);
                // Если разделитель найден и каретка расположена после него
                if (sepIndex >= 0 && textBox5.SelectionStart > sepIndex)
                {
                    // Количество символов после разделителя
                    string afterSep = textBox5.Text.Substring(sepIndex + 1);
                    // Если уже введено 2 цифры (без учёта выделенного текста) — блокируем ввод
                    if (afterSep.Length >= 2 && textBox5.SelectionLength == 0)
                    {
                        e.Handled = true;
                    }
                }
                return;
            }

            // Если вводится точка или запятая, разрешаем ввод разделителя, но только если его ещё нет
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (textBox5.Text.Contains(separator.ToString()))
                    e.Handled = true;
                else
                    e.KeyChar = separator; // Приводим к региональному разделителю
                return;
            }

            // Блокируем все остальные символы
            e.Handled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CursRub = Convert.ToDouble(textBox5.Text);
            CursChm = Convert.ToInt32(textBox6.Text);
            this.UpdateLabelCurs(label9);
            this.UpdateLabelCurs(label10);
        }

        private void UpdateLabelCurs(Label l)
        {
            l.Text = string.Format("голд 1:{0}\nчм 1:{1}", CursRub.ToString("0.##"), CursChm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = comboBox1.Text.ThrowOnCondition(x => x.IsNullOrDefault(), "Введите ник игрока");
            if (result == null) return;

            result = comboBox1.Text.ThrowOnCondition(x => !_playerList.Select(x => x.Nick.ToLower()).Contains(x.ToLower()), "Указан несуществующий игрок");
            if (result == null) return;

            result = textBox3.Text.ThrowOnCondition(string.IsNullOrWhiteSpace, "Введите число");
            if (result == null) return;

            result = textBox3.Text.ThrowOnCondition(text => !int.TryParse(text, out _), "Введите корректное число");
            if (result == null) return;

            result = textBox9.Text.ThrowOnCondition(x => x.IsNullOrDefault() || x == "0", "Укажите сколько чм добавится");
            if (result == null) return;

            var countGold = Convert.ToInt32(textBox3.Text);
            var player = _playerList.First(x => x.Nick == comboBox1.Text);
            var getCh = Convert.ToInt32(textBox9.Text.Replace("\u00A0", ""));
            var history = new History()
            {
                Id = _historyList.Count + 1,
                Player = player,
                Date = DateTime.Now,
                IsBuyGold = true,
                Count = countGold,
                GetChM = getCh,
            };

            player.BuyGold += countGold;
            player.AvailableChm += getCh;

            this._historyList.Add(history);
            textBox3.Text = string.Empty;
            textBox9.Text = string.Empty;
            label15.Text = this.GetLabel15(0);

            this.LoadHistoryGris();
            this.LoadPlayersInMainGris(_playerList);

            if (comboBox1.Text == comboBox2.Text)
            {
                label11.Text = GetLabel11(player.AvailableChm);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = comboBox2.Text.ThrowOnCondition(x => x.IsNullOrDefault(), "Введите ник игрока");
            if (result == null) return;

            result = comboBox2.Text.ThrowOnCondition(x => !_playerList.Select(x => x.Nick.ToLower()).Contains(x.ToLower()), "Указан несуществующий игрок");
            if (result == null) return;

            result = textBox4.Text.ThrowOnCondition(string.IsNullOrWhiteSpace, "Введите число");
            if (result == null) return;

            result = textBox4.Text.ThrowOnCondition(text => !int.TryParse(text, out _), "Введите корректное число");
            if (result == null) return;

            var countChm = Convert.ToInt32(textBox4.Text);
            var player = _playerList.First(x => x.Nick == comboBox2.Text);
            var history = new History()
            {
                Id = _historyList.Count + 1,
                Player = player,
                Date = DateTime.Now,
                IsBuyGold = false,
                Count = countChm,
                GetChM = countChm,
            };

            player.SpentChM += countChm;
            player.AvailableChm -= countChm;

            this._historyList.Add(history);
            textBox4.Text = string.Empty;
            label11.Text = this.GetLabel11(player.AvailableChm);

            this.LoadHistoryGris();
            this.LoadPlayersInMainGris(_playerList);
        }

        private static int ChMAdded(int gold)
        {
            return (int)(gold * (gold switch
            {
                < 1_000_000 => 0.4,  // До 1кк: 40% от суммы
                < 2_000_000 => 0.5,  // 1-2кк: 50% от суммы
                < 4_000_000 => 0.55, // 2-4кк: 55% от суммы
                < 6_000_000 => 0.6,  // 4-6кк: 60% от суммы
                < 8_000_000 => 0.65, // 6-8кк: 65% от суммы
                _ => 0.7             // 8кк и больше: 70% от суммы
            }));
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            var gold = int.TryParse(textBox3.Text, out int value) && value > 0
                ? ChMAdded(value)
                : 0;

            textBox9.Text = (gold / CursChm).ToString("N0");
            label15.Text = GetLabel15(gold);
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            textBox9.Text = textBox9.Text.Replace("\u00A0", "");
        }

        private void textBox9_KeyUp(object sender, KeyEventArgs e)
        {
            int value = 0; // Значение по умолчанию (если текстбокс пуст)
            if (!string.IsNullOrWhiteSpace(textBox9.Text)) // Проверяем, не пуст ли текст
            {
                if (int.TryParse(textBox9.Text, out int result)) // Пробуем преобразовать в число
                {
                    value = result;
                }
            }

            label15.Text = GetLabel15(value * CursChm);
        }

        private string GetLabel11(int value)
        {
            return $"Доступно {value.ToString("N0")}чм";
        }

        private string GetLabel15(int chm)
        {
            return $"Можно закупиться на {chm.ToString("N0")} голд";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var player = _playerList.FirstOrDefault(x => x.Nick == comboBox2.Text, new Player());
            label11.Text = GetLabel11(player.AvailableChm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0) // Проверяем, выбрана ли строка
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?",
                                                      "Подтверждение удаления",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) // Если нажали "Да"
                {
                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value); // Получаем ID из первой колонки

                        var history = _historyList.FirstOrDefault(x => x.Id == id);

                        var player = _playerList.FirstOrDefault(x => x.Id == history.Player.Id);

                        if (history.IsBuyGold)
                        {

                            player.BuyGold -= history.Count;
                            player.AvailableChm -= history.GetChM;
                        }
                        else
                        {
                            player.SpentChM += history.Count;
                            player.AvailableChm += history.GetChM;
                        }

                        // Удаляем из базы данных
                        // DeleteFromDatabase(id);
                        _historyList.Remove(history);
                        dataGridView2.Rows.Remove(row);

                        this.LoadHistoryGris();
                        this.LoadPlayersInMainGris(_playerList);

                        if (player.Nick == comboBox2.Text)
                        {
                            label11.Text = GetLabel11(player.AvailableChm);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
