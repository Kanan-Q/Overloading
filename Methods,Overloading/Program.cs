
using static System.Console;
internal class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int num = Array(arr);
        WriteLine($"en kicik element:{num}");

        string sentence = "proqramlaşdırma dili";
        string firstLetters = FirstLetters(sentence);
        WriteLine("Sozlerin bas herfleri: " + firstLetters);

        string sentences = "Hello World";
        string result = Delete(sentences);
        WriteLine(result);

    }

    static int Array(int[] arr)
    {
        int min = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {

            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }
    static string FirstLetters(string sentence)
    {
        string result = "";
        bool Word = true;
        for (int i = 0; i < sentence.Length; i++)
        {
            if (Word && sentence[i] != ' ')
            {
                result += sentence[i];
                Word = false;
                break;
            }
            else if (sentence[i] == ' ')
            {
                Word = true;
            }
        }

        return result;
    }


    static string Delete(string sentence)
    {
        string newSentence = "";

        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] != ' ')
            {
                newSentence += sentence[i];
            }
        }

        return newSentence;
    }
}
