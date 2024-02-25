using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace Projet03
{
    class Data
    {
        //fonction de chargement des données bonbons à partir du fichier candies.data : output => tableau des candies
        public static Candy[] LoadCandies()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            const String FILE_NAME = "candies.data";
            const char DELIMITER = '|';
            Candy[] candies = new Candy[0];
            String line;
            StreamReader streamReader = new StreamReader(FILE_NAME);
            while ((line = streamReader.ReadLine()) != null)
            {
                String name = line.Split(DELIMITER)[1];
                decimal price = Convert.ToDecimal(line.Split(DELIMITER)[2]);
                int stock = int.Parse(line.Split(DELIMITER)[3]);
                

                Candy newCandy = new Candy(name,price,stock);
                candies = AddCandy(candies, newCandy);

            }

            streamReader.Close();
            return candies;

        }
        private static Candy[] AddCandy(Candy[] candies, Candy candy)
        {
            Candy[] newCandies = new Candy[candies.Length + 1];
            for (int i = 0; i < candies.Length; i++)
            {
                newCandies[i] = candies[i];
            }
            newCandies[candies.Length] = candy;
            return newCandies;
        }


    }
}
