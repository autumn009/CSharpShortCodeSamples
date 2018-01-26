using System;
using System.IO;
using System.Collections.Generic;
public class Person
{
    public string Name;
    public void Say(string s)
    {
        if (Name == "") Console.WriteLine(s);
        else Console.WriteLine("{0}: {1}", Name, s);
    }
}
public class Persons
{
    public static Person 独白 = new Person() { Name = "" };
    public static Person 探偵 = new Person() { Name = "探偵" };
    public static Person 犯人 = new Person() { Name = "犯人" };
}
public class QuickTalk
{
    private Dictionary<string, Person> talkers = new Dictionary<string, Person>();
    public void Play(string text)
    {
        char[] whiteSpaces = { ' ', '\t', '　' };
        StringReader reader = new StringReader(text);
        for (; ; )
        {
            string s = reader.ReadLine();
            if (s == null) break;
            s = s.Trim();
            // 空行は無視
            if (s.Length == 0) continue;
            Person talker = null;
            string body;
            int firstWhiteSpacePos = s.IndexOfAny(whiteSpaces);
            if (firstWhiteSpacePos < 0 || firstWhiteSpacePos > 2)
            {
                talker = Persons.独白;
                body = s;
            }
            else
            {
                string shortName = s.Substring(0, firstWhiteSpacePos);
                if (talkers.ContainsKey(shortName))
                {
                    talker = talkers[shortName];
                }
                if (talker == null)
                {
                    throw new ApplicationException(string.Format("QuickTalk構文エラー。{0}は定義されていない短いTalker名です。", shortName));
                }
                body = s.Substring(firstWhiteSpacePos + 1).Trim();
            }
            talker.Say(body);
        }
    }
    public void AddTalker(string shortName, Person talker)
    {
        talkers[shortName] = talker;
    }
}
class Program
{
    static void Main()
    {
        var q = new QuickTalk();
        q.AddTalker("t", Persons.探偵);
        q.AddTalker("h", Persons.犯人);
        q.Play(@"
t 犯人はおまえだ!
h くっ、どうしてばれた。完全犯罪だったはずだ!
t お手伝いさんが見ていたんだよ。おまえが裏口から台所に入り込むところをね。
h そ、そんな。
t その直後、不審に思ったお手伝いさんが台所に戻ってケーキの数を確認したんだ。
h まさか。
t そうだ。君が立ち去ったあと、ケーキが1つ減っていたのだ。だから食い逃げ犯はおまえだ!
");
    }
}
