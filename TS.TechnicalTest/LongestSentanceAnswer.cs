
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        //split string into sentences using full stop
        string[] sentences = s.Split('.');
        string[]? longestSentenceWords = null;

        //loop trough each sentence and get the words count
        foreach (string sentence in sentences)
        {
            //get words from a sentence 
            var sentenceWords = sentence.Split(new char[] { ' ','?','!'}, StringSplitOptions.RemoveEmptyEntries);
            //check if the sentence number of words is grether than longestSentenceWords
            if (longestSentenceWords == null || sentenceWords.Length > longestSentenceWords.Length)
            {
                longestSentenceWords = sentenceWords;
            }
        }

        return longestSentenceWords.Length;
    }


}
