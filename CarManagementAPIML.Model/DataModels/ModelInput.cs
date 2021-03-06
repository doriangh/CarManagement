//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace CarManagementAPIML.Model.DataModels
{
    public class ModelInput
    {
        [ColumnName("cc"), LoadColumn(0)]
        public float Cc { get; set; }


        [ColumnName("make"), LoadColumn(1)]
        public string Make { get; set; }


        [ColumnName("model"), LoadColumn(2)]
        public string Model { get; set; }


        [ColumnName("odometer"), LoadColumn(3)]
        public float Odometer { get; set; }


        [ColumnName("year"), LoadColumn(4)]
        public float Year { get; set; }


        [ColumnName("price"), LoadColumn(5)]
        public float Price { get; set; }


    }
}
