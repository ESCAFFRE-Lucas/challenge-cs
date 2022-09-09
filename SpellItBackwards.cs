﻿namespace CSharpDiscovery.Quest01
{
    public class SpellItBackwards_Exercice
    {
        public static string SpellItBackward(string str)
        {
            char[] chars = str.ToCharArray();  
            for (int i = 0, j = str.Length - 1; i < j; i++, j--) {  
                char c = chars[i];  
                chars[i] = chars[j];  
                chars[j] = c;  
            }  
            return new string(chars);
        }
    }
}