namespace MillionaireWinFormsApp
{
    public class WinningRow
    {
        public decimal Count { get; set; }

        public bool IsMilestone{ get; set; }

        public WinningRow(decimal count, bool isMilestone)
        {
            Count = count;
            IsMilestone = isMilestone;
        }
    }
}
