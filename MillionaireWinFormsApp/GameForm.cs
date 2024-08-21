namespace MillionaireWinFormsApp
{
    public partial class GameForm : Form
    {
        Game game;
        public GameForm()
        {
            InitializeComponent();
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

            if (isCorrect)
            {
                game.IncreaseWinning();

                currentWinningLabel.Text = game.Player.CurrentWinning.ToString();

                ShowNextQuestion();
            }
            else
            {
                game.End();
                MessageBox.Show("Игра окончена!");
            }
        }
    }
}
