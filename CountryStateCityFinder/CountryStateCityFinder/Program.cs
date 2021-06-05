using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace CountryStateCityFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program prog = new Program();
            prog.GetData();

        }


        public void GetData()
        {
            if (File.Exists(@"C:\repos\Others\CountryStateCityFinder\CountryStateCityFinder\CountryStateCityFinder\countrystatecity.json"))
            {
                string jsontxt = File.ReadAllText(@"C:\repos\Others\CountryStateCityFinder\CountryStateCityFinder\CountryStateCityFinder\countrystatecity.json");
                var countryList = JsonConvert.DeserializeObject<IEnumerable<Country>>(jsontxt);

                var unitedStates = countryList.Where(c => c.Name == "United States");
            }

            
        }



    }

    public class Country
    {
        public string Name { get; set; }
        public IEnumerable<States> States { get; set; }
    }

    public class States
    {
        public string Name { get; set; }
        public IEnumerable<Cities> Cities { get; set; }
    }

    public class Cities
    {
        public string Name { get; set; }
    }


}
