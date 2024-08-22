

namespace MillionaireWinFormsApp
{
    public class Game
    {
        int currentQuestionIndex = -1;
        public Question[] Questions { get; set; }

        public Player Player { get; set; }

        public WinningTable WinningTable { get; set; }

        public Game(Player player)
        {
            Player = player;
            Questions = InitializeQuestions();
            WinningTable = new WinningTable();
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

            var questions4 = new Question()
            {
                Text = "Сколько костей в человеческом теле?",
                Answers =
                         [
                             new Answer{ Text = "458", IsCorrect = false },
                            new Answer{ Text = "307", IsCorrect = false },
                            new Answer{ Text = "308", IsCorrect = false },
                            new Answer{ Text = "206", IsCorrect = true },
                        ]
            };

            var questions5 = new Question()
            {
                Text = "На каком языке говорят в Бразилии?",
                Answers =
                [
                    new Answer{ Text = "Китайский", IsCorrect = false },
                    new Answer{ Text = "Французский", IsCorrect = false },
                    new Answer{ Text = "Бразильский", IsCorrect = false },
                    new Answer{ Text = "Португальский", IsCorrect = true },
                ]
            };

            var questions6 = new Question()
            {
                Text = "Какая планета ближе всего к Солнцу?",
                Answers =
                [
                    new Answer{ Text = "Титан", IsCorrect = false },
                    new Answer{ Text = "Юпитер", IsCorrect = false },
                    new Answer{ Text = "Меркурий", IsCorrect = true },
                    new Answer{ Text = "Винера", IsCorrect = false },
                ]
            };

            var questions7 = new Question()
            {
                Text = "Какое первое название было у мороженого?",
                Answers =
                [
                    new Answer{ Text = "Шейк", IsCorrect = false },
                    new Answer{ Text = "Айскрим", IsCorrect = false },
                    new Answer{ Text = "Джелато", IsCorrect = true },
                    new Answer{ Text = "Лёдник", IsCorrect = false },
                ]
            };

            var questions8 = new Question()
            {
                Text = "Какое национальное животное Шотландии?",
                Answers =
                [
                    new Answer{ Text = "Единорог", IsCorrect = true },
                    new Answer{ Text = "Рыба", IsCorrect = false },
                    new Answer{ Text = "Лошадь", IsCorrect = false },
                    new Answer{ Text = "Заяц", IsCorrect = false },
                ]
            };

            var questions9 = new Question()
            {
                Text = "Какая последняя буква была добавлена в английский алфавит?",
                Answers =
                [
                    new Answer{ Text = "Z", IsCorrect = false },
                    new Answer{ Text = "J", IsCorrect = true },
                    new Answer{ Text = "Y", IsCorrect = false },
                    new Answer{ Text = "U", IsCorrect = false },
                ]
            };

            var questions10 = new Question()
            {
                Text = "Как долго длилась самая короткая война?",
                Answers =
                [
                    new Answer{ Text = "5 минут", IsCorrect = false },
                    new Answer{ Text = "38 минут", IsCorrect = true },
                    new Answer{ Text = "2 дня", IsCorrect = false },
                    new Answer{ Text = "20 минут", IsCorrect = false },
                ]
            };

            var questions11 = new Question()
            {
                Text = "Какой русский писатель написал знаменитую “Анну Каренину”?",
                Answers =
                [
                    new Answer{ Text = "Антон Чехов", IsCorrect = false },
                    new Answer{ Text = "Николай Гоголь", IsCorrect = false },
                    new Answer{ Text = "Лев Толстой", IsCorrect = true },
                    new Answer{ Text = "Фёдор Достоевский", IsCorrect = false },
                ]
            };

            var questions12 = new Question()
            {
                Text = "Как называется точка над буквами i и j?",
                Answers =
                [
                    new Answer{ Text = "Тильда", IsCorrect = false },
                    new Answer{ Text = "Дельта", IsCorrect = false },
                    new Answer{ Text = "Титло", IsCorrect = true },
                    new Answer{ Text = "Альфа", IsCorrect = false },
                ]
            };

            var questions13 = new Question()
            {
                Text = "Сколько элементов в периодической таблице?",
                Answers =
                [
                    new Answer{ Text = "118", IsCorrect = true },
                    new Answer{ Text = "214", IsCorrect = false },
                    new Answer{ Text = "145", IsCorrect = false },
                    new Answer{ Text = "148", IsCorrect = false },
                ]
            };

            var questions14 = new Question()
            {
                Text = "Как именовали корабли США, созданные с целью полёта на Луну?",
                Answers =
                [
                    new Answer{ Text = "Атлас", IsCorrect = false },
                    new Answer{ Text = "Аполлон", IsCorrect = true },
                    new Answer{ Text = "Дейтерий", IsCorrect = false },
                    new Answer{ Text = "Скайнет", IsCorrect = false },
                ]
            };


            var questions15 = new Question()
            {
                Text = "Как называется галактика, в которую входит Земля?",
                Answers =
                [
                    new Answer{ Text = "Млечный Путь", IsCorrect = true },
                    new Answer{ Text = "Мир", IsCorrect = false },
                    new Answer{ Text = "Земля", IsCorrect = true },
                    new Answer{ Text = "Галактика Андромеды", IsCorrect = false },
                ]
            };


            return [questions1, questions2, questions3,
                    questions4, questions5, questions6,
                    questions7, questions8, questions9,
                    questions10, questions11, questions12,
                    questions13, questions14, questions15];
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

            if (selectedAnswer.IsCorrect)
            {
                WinningTable.Next();
            }
            else
            {
                WinningTable.Loss();
            }

            return selectedAnswer.IsCorrect;
        }

        public bool IsWin()
        {
            return WinningTable.GetCurrent().Count == 1_000_000;
        }

        public Question FiftyFifty()
        {
            var currentQuestion = Questions[currentQuestionIndex];

            var incorrectAnswers = currentQuestion.Answers.Where(x => !x.IsCorrect).ToArray();

            var random = new Random();
            var randomIncorrectAnswerIndex = random.Next(0, incorrectAnswers.Length);

            for (int i = 0; i < incorrectAnswers.Length; i++)
            {
                if (i != randomIncorrectAnswerIndex)
                {
                    incorrectAnswers[i].Text = string.Empty;
                }
            }

            return currentQuestion;
        }
    }
}
