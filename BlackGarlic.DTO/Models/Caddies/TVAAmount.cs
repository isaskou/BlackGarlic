namespace BlackGarlic.DTO.Models.Caddies
{
    public class TVAAmount
    {
        public int Id { get; set; }
        public double TVAType { get; set; }

        public TVAAmount()
        {

        }

        public TVAAmount(int id, double tvaType)
        {
            Id = id;
            TVAType = tvaType;
        }
    }
}