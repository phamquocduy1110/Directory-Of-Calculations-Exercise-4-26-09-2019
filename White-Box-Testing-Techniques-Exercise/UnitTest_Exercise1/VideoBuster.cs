namespace Exercise1
{
    public class VideoBuster
    {
        public double calcRentalFee(Tape[] tapes, Customer customer)
        {
            double total = 0;

            for (int i = 0; i < tapes.Length; i++)
            {
                total += tapes[i].price;
            }

            if (tapes.Length > 10)
                total *= 0.8;
            else if (tapes.Length > 5)
                total *= 0.9;

            if (customer.isPremium)
                total *= 0.9;

            return total;
        }
    }

    public class Tape
    {
        double dPrice;

        public double price
        {
            get { return dPrice; }
            set { dPrice = value; }
        }
    }

    public class Customer
    {
        bool bPremium;

        public bool isPremium
        {
            get { return bPremium; }
            set { bPremium = value; }
        }
    }
}