using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transport transport = new Transport();
            //будут доступны дополнительные поля Cost TransportCode

            ITrans trans = new Transport();
            //не будет доступно два поля из Transport


            Transport big = new Transport();

        }

        public interface ITrans
        {
            string CarType { get; set; }
            int CarWeight { get; set; }
            int MaxWeight { get; set; }

            void GetTransport();
            string WeightInfo();
            double WeightParam();
        }

        public interface ITransMethod
        {
            string VinCode1 { get; set; }
            string Color1 { get; set; }
            bool isAirplane1 { get; set; }
        }

        public interface ITransAdditionalMethod
        {
            string VinCode2 { get; set; }
            string Color2 { get; set; }
            bool isAirplane2 { get; set; }
        }

        public class Transport : ITrans, ITransMethod, ITransAdditionalMethod
        {
            public string CarType { get; set; }
            public int CarWeight { get; set; }
            public int MaxWeight { get; set; }

            //можно доавлять свои свойства

            public int Cost { get; set; }
            public string TransportCode { get; set; }

            //2 - inteface
            public string VinCode1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Color1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool isAirplane1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            //3 - interface
            public string VinCode2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Color2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public bool isAirplane2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void GetTransport()
            {
                throw new NotImplementedException();
            }

            public string WeightInfo()
            {
                throw new NotImplementedException();
            }

            public double WeightParam()
            {
                throw new NotImplementedException();
            }
        }

        static void M1(Transport transport) // 40 методов
        {

        }

        static void M2(ITransAdditionalMethod transport)
        {
            //ускаются ненужные поля и методы
        }
    }
}
