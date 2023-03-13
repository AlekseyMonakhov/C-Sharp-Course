// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;


string myString = "привет";
string mySecondString = "вет";
string myThirdString = "this is some test text (test first string ) and the (test secont string) and then (test third string)";



try
{
    HomeWork.CompareStrings(mySecondString, myString);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

public class HomeWork
{
    public static void findThgreeChars(string str)
    {

        if (str.Length <= 2)
        {
            throw new Exception("String cant be empty, or less then 3 symbols");
        }
        if (str.Replace(" ", "").Length == 0)
        {
            throw new Exception("Cant be only spaces");
        }

        Dictionary<char, int> dict = new Dictionary<char, int>();
        string updStr = str.Replace(" ", "").ToLower();

        foreach (char ch in updStr)
        {
            if (dict.ContainsKey(ch))
            {
                dict[ch]++;
            }
            else
            {
                dict.Add(ch, 1);
            }
        }
        List<KeyValuePair<char, int>> sortedDict = dict.ToList();

        sortedDict.Sort((x, y) => y.Value.CompareTo(x.Value));

        Console.WriteLine($"{sortedDict[0].Key}, {sortedDict[1].Key}, {sortedDict[2].Key}, are most used in this sentence");

    }
    public static void CamelCase(string str)
    {
        if (str.Length == 0)
        {
            throw new Exception("string cant be empty");
        }

        if (str.Trim().Length == 0)
        {
            throw new Exception("cant use only spaces");
        }

        char[] separators = new char[] { ' ', '.', ',' };
        List<string> stringArr = new List<string>(str.Split(separators, StringSplitOptions.RemoveEmptyEntries));

        string result = "";
        for (int i = 0; i < stringArr.Count; i++)
        {
            List<char> chars = new List<char>(stringArr[i].ToCharArray());
            if (i == 0)
            {
                chars[0] = char.ToLower(chars[0]);
                result += new string(chars.ToArray());
            }
            else
            {
                chars[0] = char.ToUpper(chars[0]);
                result += new string(chars.ToArray());
            }


        }
        Console.WriteLine(result);

    }

    public static void cutExplanations(string str)
    {
        if (str.Length == 0)
        {
            throw new Exception("string cant be empty");
        }

        if (str.Trim().Length == 0)
        {
            throw new Exception("cant use only spaces");
        }

        if (!(str.Contains('(') && str.Contains(')')))
        {
            throw new Exception("no brackets in string");
        }


        string result = "";
        bool addString = false;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '(')
            {
                addString = true;
            }
            if (addString == true)
            {
                result += str[i];
            }
            if (str[i] == ')')
            {
                addString = false;
            }
        }
        Console.WriteLine(result);
    }


    public static void CompareStrings(string str, string str2)
    {
        if (str.Length == 0 || str2.Length == 0)
        {
            throw new Exception("Some string is emty");
        }

        if (str.Trim().Length == 0 || str2.Trim().Length == 0)
        {
            throw new Exception("cant use only spaces");
        }

        List<char> firstStr = new List<char>(str.ToCharArray());
        firstStr.Sort((x, y) => x.CompareTo(y));

        List<char> secondStr = new List<char>(str2.ToCharArray());
        secondStr.Sort((x, y) => x.CompareTo(y));

        bool result = new string(firstStr.ToArray()) == new string(secondStr.ToArray());

        Console.WriteLine(result);

    }
}



