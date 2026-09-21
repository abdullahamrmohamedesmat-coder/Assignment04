
namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            //1st answer01
            //a)that is hide implements Property and methods ,Focus on what do,not how
            //b)maintenance,Reusability,Reduse complexity,Security 
            #endregion

            //Practical Answer
            DeliveryAddress delivery = new DeliveryAddress("Cairo", "Al Tahrir", 23);
            StandardShipment standardShipment = new StandardShipment("DWE-34R", "Clothos", 343, 233, delivery);
            ExpressShipment expressShipment = new ExpressShipment("IWE-232", "Cars", 23, 443, delivery, 343);
            InternationalShipment internationalShipment = new InternationalShipment("TOW-232", "LAPTOPS", 3434, 343, delivery, "Egypt", 232);


            DeliveryCentre deliveryCentre = new DeliveryCentre("Centre");
            deliveryCentre.AddShipmnent(standardShipment);
            deliveryCentre.AddShipmnent(expressShipment);
            deliveryCentre.AddShipmnent(internationalShipment);

            Console.WriteLine("All Shipments : ");
            deliveryCentre.PrintShipments();

            Console.WriteLine(standardShipment.GetTrackingStatus());
            Console.WriteLine(expressShipment.GetTrackingStatus());
            Console.WriteLine(internationalShipment.GetTrackingStatus());


            Console.WriteLine(standardShipment.CalculateInsurance());
            Console.WriteLine(expressShipment.CalculateInsurance());
            Console.WriteLine(internationalShipment.CalculateInsurance());

            ITrackable[] trackables = new ITrackable[3]
            {
                new StandardShipment("DWE-34R", "Clothos", 343, 233, delivery),
                new ExpressShipment("IWE-2","Cars", 23, 443, delivery, 343),
                new InternationalShipment("TOW-232", "LAPTOPS", 3434, 343, delivery, "Egypt", 232)
            }; 
            foreach (ITrackable trackable in trackables)
            {
                Console.WriteLine(trackable.GetTrackingStatus());

            }
            IInsurable[] insurables = new IInsurable[3]
            {
                new StandardShipment("DWE-34R", "Clothos", 343, 233, delivery),
                new ExpressShipment("IWE-2","Cars", 23, 443, delivery, 343),
                new InternationalShipment("TOW-232", "LAPTOPS", 3434, 343, delivery, "Egypt", 232)
            };
            
            foreach(IInsurable insurable1 in insurables)
            {
                Console.WriteLine(insurable1.CalculateInsurance());
            }
        }
    }
}
