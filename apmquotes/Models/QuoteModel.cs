namespace ApmQuotes.Models
{
    public class QuoteModel
    {
        public double RoomLength { get; set; }
        public double RoomWidth { get; set; }
        public SeriesUpgrade SeriesUpgrade { get; set; }

        public double FinalCost { set; get; }
    }
}
