using System;

namespace CarManagement.Core.Requests
{
    public class UpdateCarDetailRequest
    {
        public DateTime Itp { get; set; }
        public DateTime RoadTax { get; set; }
        public bool WinterTires { get; set; }
        public DateTime OilChange { get; set; }
        public int InsuranceValue { get; set; }
        public int RoadTaxValue { get; set; }
        public int TaxValue { get; set; }
    }
}