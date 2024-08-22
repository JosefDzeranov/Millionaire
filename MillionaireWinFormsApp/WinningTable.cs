namespace MillionaireWinFormsApp
{
    public class WinningTable
    {
        int currentRowIndex = -1;
        public WinningRow[] Winnings { get; set; }

        public WinningRow GetCurrent()
        {
            if (currentRowIndex >= 0)
            {
                return Winnings[currentRowIndex];
            }

            return null;
        }

        public WinningTable()
        {
            Winnings = [
                            new WinningRow(100, false),
                            new WinningRow(200, false),
                            new WinningRow(300, false),
                            new WinningRow(500, false),
                            new WinningRow(1000, true),
                            new WinningRow(2000, false),
                            new WinningRow(4000, false),
                            new WinningRow(8000, false),
                            new WinningRow(16000, false),
                            new WinningRow(32000, true),
                            new WinningRow(64000, false),
                            new WinningRow(125000, false),
                            new WinningRow(250000, false),
                            new WinningRow(500000, false),
                            new WinningRow(1000000, true)
                       ];
        }

        public void Next()
        {
            currentRowIndex++;
        }

        public void Loss()
        {
            for (int i = currentRowIndex; i >= 0; i--)
            {
                if (Winnings[i].IsMilestone)
                {
                    currentRowIndex = i;
                    return;
                }
            }

            currentRowIndex = -1;
        }
    }
}
