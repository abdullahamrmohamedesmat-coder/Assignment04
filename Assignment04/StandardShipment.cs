using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class StandardShipment:Shipment,ITrackable,IInsurable
    {
        public StandardShipment(string TrackingCode, string Description, decimal Weight, decimal DeliveryFee, DeliveryAddress destination) : base(TrackingCode, Description, Weight, DeliveryFee, destination)
        {
        }

        public override decimal EstimatedCost => Deliveryfee + (Weight * 5m);

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }

        public string GetTrackingStatus()
        {
            return "Shipment SH001 is Ready.";
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"TrackingCode : {TrackingCode},Description : {Description},Weight : {Weight},DeliveryFee : {Deliveryfee},Destination : {Destination}");
        }
    }
}
