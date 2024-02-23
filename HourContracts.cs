namespace Course.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public double Hours { get; set; }

        public HourContract(){}

        public HourContract(DateTime date, double valuePerHour, double hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}