namespace BlackGarlic.DTO.Models.Caddies
{
    public class ShipAmount
    {
        public int Id { get; set; }
        public string District { get; set; }
        public double Amount { get; set; }

        public ShipAmount()
        {

        }

        public ShipAmount(int id, string district, double amount)
        {
            Id = id;
            District = district;
            Amount = amount;
        }
    }
}