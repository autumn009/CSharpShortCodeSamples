using System;
using System.Linq;
using static ColorClass;

enum ColorClass { 赤組, 白組, 青組, 黄組 };

class Member
{
    internal ColorClass Group { get; }
    internal string Name { get; }
    internal Member(ColorClass group, string name) => (Group, Name) = (group, name);
}

class Program
{
    static void Main()
    {
        Member[] members = {
            new Member(白組, "たろう"),
            new Member(白組, "じろう"),
            new Member(赤組, "はなこ"),
            new Member(赤組, "はなえ"),
            new Member(青組, "エアーズ・ブルー"),
            new Member(青組, "シアン"),
            new Member(黄組, "イエロー・ベルモント"),
            new Member(黄組, "オレンジ"),
        };

        foreach (var item in Enum.GetValues(typeof(ColorClass)))
        {
            var found = members.First(c => c.Group == (ColorClass)item);
            Console.WriteLine($"{found.Group}, {found.Name}");
        }
    }
}
