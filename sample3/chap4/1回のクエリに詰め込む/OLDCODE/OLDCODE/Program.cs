using System;
using System.Collections.Generic;

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
        var list = new List<Item>();
        foreach (var item in items)
        {
            if (item.購入日.Year >= 2020) list.Add(item);
        }
        list.Sort((x, y) => Math.Sign(x.購入日.Ticks - y.購入日.Ticks));
        var 商品一覧 = new List<string>();
        foreach (var item in list)
        {
            if (商品一覧.Contains(item.商品)) continue;
            商品一覧.Add(item.商品);
            Console.WriteLine("商品={0}", item.商品);
            foreach (var item2 in list)
            {
                if (item2.商品 != item.商品) continue;
                Console.WriteLine("\t買ったのは{0}さん",
                item2.購入者名);
            }
        }
    }
}

