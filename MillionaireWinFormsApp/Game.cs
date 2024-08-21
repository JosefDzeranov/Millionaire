
namespace MillionaireWinFormsApp
{
    public class Game
    {
        int currentQuestionIndex = -1;
        public Question[] Questions { get; set; }

        public Player Player { get; set; }

        public Game(Player player)
        {
            Player = player;
            Questions = InitializeQuestions();
        }

        private Question[] InitializeQuestions()
        {
            var questions1 = new Question()
            {
                Text = "Кто написал пьесу «Ромео и Джульетта»?",
                Answers =
                        [
                            new Answer{ Text = "Уильям Шекспир", IsCorrect = true },
                            new Answer{ Text = "Лев Толстой", IsCorrect = false },
                            new Answer{ Text = "Антон Чехов", IsCorrect = false },
                            new Answer{ Text = "Александр Блок", IsCorrect = false },
                        ]
            };

            var questions2 = new Question()
            {
                Text = "Какой элемент обозначается химическим символом «О»?",
                Answers =
                        [
                            new Answer{ Text = "Осмий", IsCorrect = false },
                            new Answer{ Text = "Калий", IsCorrect = false },
                            new Answer{ Text = "Водород", IsCorrect = false },
                            new Answer{ Text = "Кислород", IsCorrect = true },
                        ]
            };

            var questions3 = new Question()
            {
                Text = "Как называется прямая линия, у которой есть начало, но нет конца?",
                Answers =
                        [
                            new Answer{ Text = "Вектор", IsCorrect = false },
                            new Answer{ Text = "Луч", IsCorrect = true },
                            new Answer{ Text = "Отрезок", IsCorrect = false },
                            new Answer{ Text = "Штанга", IsCorrect = false },
                        ]
            };

            return [questions1, questions2, questions3];
        }

        public Question GetNextQuestion()
        {
            currentQuestionIndex++;
            return Questions[currentQuestionIndex];
        }

        public bool AcceptAnswer(string answerText)
        {
            var currentQuestion = Questions[currentQuestionIndex];
            var selectedAnswer = currentQuestion.Answers.First(x => x.Text == answerText);

            return selectedAnswer.IsCorrect;
        }

        public void End()
        {
            Player.CurrentWinning = 0;
        }

        public void IncreaseWinning()
        {
            Player.CurrentWinning += 100;
        }
    }
}
