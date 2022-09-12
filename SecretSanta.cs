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

            for (int i = 0; i <= people.Count; i++)
            {
                int randomNumber = rand.Next(0, people.Count);
                int randomNumber2 = rand.Next(0, people.Count);

                while (randomNumber == randomNumber2)
                {
                    randomNumber2 = rand.Next(people.Count);
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