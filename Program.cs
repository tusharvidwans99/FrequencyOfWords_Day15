namespace FrequencyOfWords_Hashtable_Day15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the program where we are counting words in a string");

            Frequency frequency = new Frequency();
            string str = "to be or not to be";
            string str2 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] sentencesplit = frequency.splitString(str2);
            frequency.countWords(sentencesplit);

        }
    }
}