/*
 * PTra17_03.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra17_03
{
    public static void Main(string[] args)
    {
        string str = "りんご,みかん,いちご,ぶどう";
        string [] array = str.Split(",");
        // TODO strクラスの文字をカンマで区切って配列に変換してください

        foreach (string i in array)
        {
            Console.WriteLine("{0} ", i);
        }
        // TODO 配列の中の文字列を全て出力して下さい
        // ※ りんご
        //    みかん
        //    いちご
        //    ぶどう と出力されれば正解

    }
}
