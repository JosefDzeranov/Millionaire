
namespace MillionaireWinFormsApp
{
    public class WinningTable
    {
        private int _currentIndex { get; set; } = -1;

        public Winning[] Winnings { get; }
        public Winning? Current => _currentIndex >= 0 ? Winnings[_currentIndex] : default;


        public WinningTable()
        {
            Winnings = [
                            new Winning(100, false),
                            new Winning(200, false),
                            new Winning(300, false),
                            new Winning(500, false),
                            new Winning(1000, true),
                            new Winning(2000, false),
                            new Winning(4000, false),
                            new Winning(8000, false),
                            new Winning(16000, false),
                            new Winning(32000, true),
                            new Winning(64000, false),
                            new Winning(125000, false),
                            new Winning(250000, false),
                            new Winning(500000, false),
                            new Winning(1000000, true)
                       ];
        }

        public void Next()
        {
            _currentIndex++;
        }

        public void Loss()
        {
            for (int i = _currentIndex; i >= 0; i--)
            {
                if (Winnings[i].IsMilestone)
                {
                    _currentIndex = i;
                    return;
                }
            }

            _currentIndex = -1;
        }
    }
}
