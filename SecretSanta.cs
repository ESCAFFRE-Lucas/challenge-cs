using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSharpDiscovery.Quest02
{
    public class SecretSanta_Exercice
    {
        public static Dictionary<string,string> SecretSantaDraw(HashSet<string> people)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            var rand = new Random();

            for (int i = 0; i <= people.Count + 1; i++)
            {
                int randomNumber = rand.Next(0, people.Count);
                int randomNumber2 = rand.Next(0, people.Count);

                if (randomNumber == randomNumber2 && people.Count != 2)
                {
                    randomNumber2 = rand.Next(0, people.Count);
                }
				
				if (randomNumber == randomNumber2 && people.Count == 2)
				{
					if (randomNumber == 1) 
					{
						randomNumber2 = 0;
					} 
					if (randomNumber == 0) 
					{
						randomNumber2 = 1;
					}
 				}
                var person1 = people.ElementAt(randomNumber);
                var person2 = people.ElementAt(randomNumber2);
                people.Remove(person1);
                people.Remove(person2);
                dic.Add(person1, person2);
            }
            return dic;
        }
    }
}