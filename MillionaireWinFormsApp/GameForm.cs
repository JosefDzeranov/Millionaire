namespace MillionaireWinFormsApp
{
    public partial class GameForm : Form
    {
        Game game;

        RadioButton[] winningTable;
        public GameForm()
        {
            InitializeComponent();
            winningTable = [
                                radioButton1,
                                radioButton2,
                                radioButton3,
                                radioButton4,
                                radioButton5,
                                radioButton6,
                                radioButton7,
                                radioButton8,
                                radioButton9,
                                radioButton10,
                                radioButton11,
                                radioButton12,
                                radioButton13,
                                radioButton14,
                                radioButton15
                            ];
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            game = new Game(new Player { Name = "Иосиф" });
            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            var nextQuestion = game.GetNextQuestion();

            questionTextLabel.Text = nextQuestion.Text;

            answerTextButton1.Text = nextQuestion.Answers[0].Text;
            answerTextButton2.Text = nextQuestion.Answers[1].Text;
            answerTextButton3.Text = nextQuestion.Answers[2].Text;
            answerTextButton4.Text = nextQuestion.Answers[3].Text;
        }

        private void answerTextButton_Click(object sender, EventArgs e)
        {
            var clickedButton = (Button)sender;

            var isCorrect = game.AcceptAnswer(clickedButton.Text);

            UpdateWinningTable();

            if (isCorrect)
            {
                clickedButton.BackColor = Color.Lime;

                if (game.WinningTable.Current.Count == 1_000_000)
                {
                    answerTextButton1.Enabled = false;
                    answerTextButton2.Enabled = false;
                    answerTextButton3.Enabled = false;
                    answerTextButton4.Enabled = false;

                    MessageBox.Show("Вы выиграли игру! Забирайте свои 1_000_000 рублей!");
                }
                else
                {
                    MessageBox.Show($"Правильно! Молодец! У тебя уже {game.WinningTable.Current.Count} рублей");

                    clickedButton.BackColor = Color.CornflowerBlue;
                    ShowNextQuestion();
                }
            }
            else
            {
                clickedButton.BackColor = Color.Red;
                answerTextButton1.Enabled = false;
                answerTextButton2.Enabled = false;
                answerTextButton3.Enabled = false;
                answerTextButton4.Enabled = false;
                MessageBox.Show($"Игра окончена! Ваш выигра {game.WinningTable.Current?.Count ?? 0} рублей");
            }
        }

        private void UpdateWinningTable()
        {
            foreach (var radioButton in winningTable)
            {
                var currentWinning = game.WinningTable.Winnings.First(x => x.Count.ToString() == radioButton.Text);

                if (game.WinningTable.Current != null && radioButton.Text == game.WinningTable.Current.Count.ToString())
                {
                    radioButton!.Checked = true;
                    radioButton!.Enabled = true;
                    radioButton!.BackColor = Color.Yellow;

                    continue;
                }

                radioButton.Checked = false;
                radioButton.Enabled = false;

                radioButton.BackColor = currentWinning.IsMilestone ? Color.Aqua : SystemColors.ActiveCaption;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var question = game.FiftyFifty();
            questionTextLabel.Text = question.Text;

            answerTextButton1.Text = question.Answers[0].Text;
            answerTextButton2.Text = question.Answers[1].Text;
            answerTextButton3.Text = question.Answers[2].Text;
            answerTextButton4.Text = question.Answers[3].Text;
        }
    }
}
