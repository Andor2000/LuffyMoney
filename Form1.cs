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

                // .ToString("N0"); // "1,000,000"
                // ��������� ������ ������ ��� ���� ������
                dataGridView1.Rows[rowIndex].Cells[0].Value = player.Nick;                           // ���
                dataGridView1.Rows[rowIndex].Cells[1].Value = player.BuyGold.ToString("N0");         // ������� ����
                dataGridView1.Rows[rowIndex].Cells[2].Value = player.SpentChM.ToString("N0"); ;      // ��������� ��
                dataGridView1.Rows[rowIndex].Cells[3].Value = player.AvailableChm.ToString("N0"); ;  // �������� ��
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
                // ��������� ������ ������ ��� ���� ������
                dataGridView2.Rows[rowIndex].Cells[0].Value = history.Id;
                dataGridView2.Rows[rowIndex].Cells[1].Value = history.Player.Nick;
                dataGridView2.Rows[rowIndex].Cells[2].Value = history.Date.ToString("yyyy-MM-dd HH:mm:ss");
                dataGridView2.Rows[rowIndex].Cells[3].Value = history.IsBuyGold ? "������ ����" : "��������� ��";
                dataGridView2.Rows[rowIndex].Cells[4].Value = history.Count.ToString("N0");
                dataGridView2.Rows[rowIndex].Cells[5].Value = $"{(history.IsBuyGold ? "+" : "-")} {history.GetChM.ToString("N0")}��";
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


            var result = _playerList.Any(x => x.Nick.ToLower(CultureInfo.CurrentCulture) == nick.ToLower())
                .ThrowOnCondition(x => x, "����� � ����� ����� ��� ����������");
            if (result)
            {
                return;
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

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ��������� ����, ���� ��� �� ����� � �� ����������� �������
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V) // ��������� Ctrl + V
            {
                string clipboardText = Clipboard.GetText();
                if (!clipboardText.All(char.IsDigit)) // ���� � ������ ���� ������� � �������� �������
                {
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            // �������� ������ ����������� (��������, ������� ��� ru-RU)
            char separator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            // ��������� ����������� ������� (Backspace, Delete � �.�.)
            if (char.IsControl(e.KeyChar))
                return;

            // ���� �������� �����, ���������, ���� ����� ����������� ��� 2 �������
            if (char.IsDigit(e.KeyChar))
            {
                int sepIndex = textBox5.Text.IndexOf(separator);
                // ���� ����������� ������ � ������� ����������� ����� ����
                if (sepIndex >= 0 && textBox5.SelectionStart > sepIndex)
                {
                    // ���������� �������� ����� �����������
                    string afterSep = textBox5.Text.Substring(sepIndex + 1);
                    // ���� ��� ������� 2 ����� (��� ����� ����������� ������) � ��������� ����
                    if (afterSep.Length >= 2 && textBox5.SelectionLength == 0)
                    {
                        e.Handled = true;
                    }
                }
                return;
            }

            // ���� �������� ����� ��� �������, ��������� ���� �����������, �� ������ ���� ��� ��� ���
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (textBox5.Text.Contains(separator.ToString()))
                    e.Handled = true;
                else
                    e.KeyChar = separator; // �������� � ������������� �����������
                return;
            }

            // ��������� ��� ��������� �������
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
            l.Text = string.Format("���� 1:{0}\n�� 1:{1}", CursRub.ToString("0.##"), CursChm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = comboBox1.Text.ThrowOnCondition(x => x.IsNullOrDefault(), "������� ��� ������");
            if (result == null) return;

            result = comboBox1.Text.ThrowOnCondition(x => !_playerList.Select(x => x.Nick.ToLower()).Contains(x.ToLower()), "������ �������������� �����");
            if (result == null) return;

            result = textBox3.Text.ThrowOnCondition(string.IsNullOrWhiteSpace, "������� �����");
            if (result == null) return;

            result = textBox3.Text.ThrowOnCondition(text => !int.TryParse(text, out _), "������� ���������� �����");
            if (result == null) return;

            result = textBox9.Text.ThrowOnCondition(x => x.IsNullOrDefault() || x == "0", "������� ������� �� ���������");
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
            var result = comboBox2.Text.ThrowOnCondition(x => x.IsNullOrDefault(), "������� ��� ������");
            if (result == null) return;

            result = comboBox2.Text.ThrowOnCondition(x => !_playerList.Select(x => x.Nick.ToLower()).Contains(x.ToLower()), "������ �������������� �����");
            if (result == null) return;

            result = textBox4.Text.ThrowOnCondition(string.IsNullOrWhiteSpace, "������� �����");
            if (result == null) return;

            result = textBox4.Text.ThrowOnCondition(text => !int.TryParse(text, out _), "������� ���������� �����");
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
                < 1_000_000 => 0.4,  // �� 1��: 40% �� �����
                < 2_000_000 => 0.5,  // 1-2��: 50% �� �����
                < 4_000_000 => 0.55, // 2-4��: 55% �� �����
                < 6_000_000 => 0.6,  // 4-6��: 60% �� �����
                < 8_000_000 => 0.65, // 6-8��: 65% �� �����
                _ => 0.7             // 8�� � ������: 70% �� �����
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
            int value = 0; // �������� �� ��������� (���� ��������� ����)
            if (!string.IsNullOrWhiteSpace(textBox9.Text)) // ���������, �� ���� �� �����
            {
                if (int.TryParse(textBox9.Text, out int result)) // ������� ������������� � �����
                {
                    value = result;
                }
            }

            label15.Text = GetLabel15(value * CursChm);
        }

        private string GetLabel11(int value)
        {
            return $"�������� {value.ToString("N0")}��";
        }

        private string GetLabel15(int chm)
        {
            return $"����� ���������� �� {chm.ToString("N0")} ����";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var player = _playerList.FirstOrDefault(x => x.Nick == comboBox2.Text, new Player());
            label11.Text = GetLabel11(player.AvailableChm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0) // ���������, ������� �� ������
            {
                DialogResult result = MessageBox.Show("�� �������, ��� ������ ������� ��������� ������?",
                                                      "������������� ��������",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) // ���� ������ "��"
                {
                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value); // �������� ID �� ������ �������

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

                        // ������� �� ���� ������
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
                MessageBox.Show("�������� ������ ��� ��������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
