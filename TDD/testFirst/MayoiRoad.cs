/*
 * MayoiRoad.cs
 *   作成	IT-College	2019
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */
using System;

namespace testFirst
{
    /**
     * テスト技法・設計手法演習問題です。
     * このクラスを対象としたテストクラス：MayoiRoadTestのテストメソッドを実行した時に、
     * 全てのテストメソッドがグリーンで完了するよう実装して下さい
     *
     * ※もちろん、テストケース以外のパターンでも正常動作するようにしてください
     * @author IT-College
     *
     */
    public class MayoiRoad
    {
        public static void Main(string[] args)
        {
            // nothing
        }

        /**
         * N が与えられたとき、P を出力するプログラムです。
         * @param 試行回数
         * @return Bにたどり着ける回数
         */
        public static string check(int n)
        {
            /*
             * N を「反転回数の上限」とします。言い換えるなら N は「その回数までは反転してかまわないという数」です。
             * P を「A から入って B から出るルートの種類の数」とします
             */
            /* ex)
             * もしも N が 1 の場合、B から出るルートは、
             * • A → イ → ウ → イ → ア → B
             * • A → イ → ア → B
             * という 2 種類があるので、P は 2 になります。
             */
            /* ex)
             * もしも N が 4 の場合、B から出るルートは、
             * • X → イ → ウ → イ → ア → B
             * • X → イ → ウ → イ → ア → イ → ウ → イ → ア → B
             * • X → イ → ウ → イ → ア → イ → ア → B
             * • X → イ → ウ → イ → ウ → イ → ア → B
             * • X → イ → ア → B
             * • X → イ → ア → イ → ウ → イ → ア → B
             * • X → イ → ア → イ → ア → B
             * という 7 種類があるので、P は 7 になります。
             */
            return null;
        }
    }
}
