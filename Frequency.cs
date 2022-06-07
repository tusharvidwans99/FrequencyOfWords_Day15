using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyOfWords_Hashtable_Day15
{
    public class Frequency
    {
        Hashtable MyMapNode = new Hashtable();
        private String[] sentenceSplit;


        public string[] splitString(string sentence)
        {
            
             return sentence.Split();
            
        }


        public void countWords(string[] sentenceSplit)
        {
            foreach (String s in sentenceSplit)
            {
                if (MyMapNode.ContainsKey(s))
                {
                    MyMapNode[s]= (int)MyMapNode[s] + 1;
                }
                else
                {
                    MyMapNode.Add(s, 1);
                }
            }
            foreach (DictionaryEntry item in MyMapNode)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }

    
}
