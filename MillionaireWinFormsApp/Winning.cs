
namespace MillionaireWinFormsApp
{
    public class Winning
    {
        public decimal Count { get; set; }
        public bool IsMilestone { get; set; }

        public Winning(decimal count, bool isMilestone)
        {
            Count = count;
            IsMilestone = isMilestone;
        }
    }
}
