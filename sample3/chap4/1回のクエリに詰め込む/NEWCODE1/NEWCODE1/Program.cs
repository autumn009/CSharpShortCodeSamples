using System;
using System.Linq;

class Item
{
    internal DateTime 購入日;
    internal string 購入者名;
    internal string 商品;
}

class Program
{
    private static Item[] items =
    {
        new Item() { 購入日 = new DateTime(2019,12,20),
            購入者名 = "タロウ", 商品 = "ガステレビ"},
        new Item() { 購入日 = new DateTime(2020,4,30),
            購入者名 = "ジロウ", 商品 = "BSチューナー"},
        new Item() { 購入日 = new DateTime(2021,5,17),
            購入者名 = "サブロー", 商品 = "ガステレビ"},
        new Item() { 購入日 = new DateTime(2022,1,3),
            購入者名 = "ハナコ", 商品 = "BSチューナー"},
        new Item() { 購入日 = new DateTime(2023,3,27),
            購入者名 = "シロー", 商品 = "AMチューナー"},
    };

    static void Main()
    {
        var q = from n in items where n.購入日.Year >= 2020 orderby n.購入日 group n by n.商品;
        foreach (var n in q)
        {
            Console.WriteLine("商品={0}", n.Key);
            foreach (var m in n) Console.WriteLine("\t買ったのは{0}さん", m.購入者名);
        }
    }
}
