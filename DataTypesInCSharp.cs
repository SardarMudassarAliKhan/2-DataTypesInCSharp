using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_DataTypesInCSharp
{
    public class DataTypesInCSharp
    {
        public int IntDataType { get; set; } = 1;
        public string StringDataType { get; set; } = "Sardar Mudassar Ali Khan";
        public float floatDataType { get; set; } = 14.5f;
        public double doubleDataType { get; set; } = 25.20;
        public char charDataType { get; set; } = 'S';
        public bool boolDataType { get; set; } = true;
        public decimal decimalDataType { get; set; } = 15482.25M;
        public byte byteDataType { get; set; } = 255;
        public short shortDataType { get; set; } = 1000;
        public long longDataType { get; set; } = 1000000000000000L;

        public void DisplayDataTypesInCSharp()
        {
            Console.WriteLine("1-Int data type: " + IntDataType);
            Console.WriteLine("2-string data type: \n" + StringDataType);
            Console.WriteLine("3-float data type: \n" + floatDataType);
            Console.WriteLine("4-double data type: \n" + doubleDataType);
            Console.WriteLine("5-char data type: \n" + charDataType);
            Console.WriteLine("6-decimal data type: \n" + decimalDataType);
            Console.WriteLine("7-bool data type: \n" + boolDataType);
            Console.WriteLine("8-byte data type: \n" + byteDataType);
            Console.WriteLine("9-short data type: \n" + shortDataType);
            Console.WriteLine("10-long data type: \n" + longDataType);
        }


    }
}
