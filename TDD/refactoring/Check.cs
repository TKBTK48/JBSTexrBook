/*
 * Check.cs
 *   作成	IT-College	2019
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */
using System;

namespace refactoring
{
    /**
     * 入力された値をカスタマイズ・入力チェックを行うクラスです。
     * 現状で単体テストが通りますので、テスト結果が変わらないようリファクタリングして下さい。
     * @author IT-College
     *
     */
    public class Check
    {
        public static void Main(string[] args)
        {
            // nothing
        }
        /**
         * 文字列を、大文字に変換して逆順に並び替えるメソッド
         */
        public static string ToReverseString(string value)
        {
            try
            {
                char[] a = value.ToCharArray();
                string b = "";
                int c;
                System.Collections.Generic.List<int> d = new System.Collections.Generic.List<int>();
                bool e = true;
                while(e)
                {
                    for (int f = 0; f < a.Length; f++)
                    {
                        c = a[f];
                        if (97 <= c && c < 122)
                            c = c - 32;
                        d.Add(c);
                    }
                    e = false;
                }
                c = 0;
                try
                {
                    while (true)
                    {
                        String f = b;
                        f = b + Convert.ToString((char)((int)d[d.Count - 1 - c]));
                        if (c < d.Count)
                            f += ",";
                        c++;
                        b = f.Substring(0, f.Length - 1);
                    }
                }
                catch (System.Exception g)
                {
                }
                return b;
            }
            catch (System.Exception e)
            {
                return "";
            }
        }
    }
}
