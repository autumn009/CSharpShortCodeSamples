using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
public class Person
{
    public string Name;
}
public class Persons
{
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
            string s = reader.ReadLine()?.Trim();
            if (s == null) break;
            if (s.Length == 0) continue;
            var shortName = s.Split(whiteSpaces).FirstOrDefault();
            if (shortName == null) continue;
            if (talkers.ContainsKey(shortName))
                Console.WriteLine($"{talkers[shortName].Name}: {s.Substring(shortName.Length).Trim()}");
            else
                Console.WriteLine(s);
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
犯人はがっくり崩れ落ちた。
");
    }
}
