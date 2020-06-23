/*
 * StringCheck.cs
 *   作成	IT-College
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */
/*
 * ------------------------------<< 演習課題 >>----------------------------------
 * 下記のプログラムは、とある短文投稿サイトの投稿部分のプログラムです。
 * しかし、下記のプログラムをチェックしたところ、以下のようなバグが確認されました。
 *
 * ①：何も入力していなかったとしても投稿できてしまう
 * ②：何文字でも投稿できてしまう
 *
 * それを踏まえて、以下のような仕様へ変更することとなった。
 * その対応を行ってください。
 *
 * a：何も入力していなかった場合は、「何も入力されていません」と表示させ再度入力待ち状態にする。
 * 		※「いまなにしてる？」という文言も再度表示させる。
 * b：141文字以上の場合、「投稿文が長すぎます」と表示させ再度入力待ち状態にする。
 * c：スペースのみで入力されている場合、「何も入力されていません」と表示させ再度入力待ち状態にする。
 * d：両端にスペースがあった場合は、そのスペースを除去する。
 *
 * ------------------------------------------------------------------------------
 */

using System;
using System.Text;
using System.IO;
/**
 * 単文投稿を行うプログラムです。
 * @author rhizome
 *
 */
public class StringCheck
{

    /**
     * 単文投稿を行うプログラムのメインです。
     * @param args
     */
    public static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine("いまなにしてる？");
            string str = InputString();
            str = str.Trim();
            int l = str.Length;
            if (l == 0)
            {
                Console.WriteLine("何も入力されていません");
                continue;
            }
            else if (l >= 141)
            {
                Console.WriteLine("投稿文が長すぎます");
                continue;
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("↓↓↓↓↓↓　投稿されました　↓↓↓↓↓↓");
                Console.WriteLine(str);
                break;
            }
        }
    }
    /**
     * 単文を入力させるメソッドです。
     * @return
     */

    public static string InputString()
    {
        // Console.ReadLine()は半角254文字、全角128文字までしか許容しないため削除
        // var str = Console.ReadLine();
        var maxLength = 4000000;    // とりあえず4000000バイト入力可能。文字数変えたい場合はこちらを修正
                                    // 半角254文字、全角128文字以上入力したいなら、OpenStandardInput()を使用する
        Stream inputStream = Console.OpenStandardInput();
        byte[] bytes = new byte[maxLength];
        int outputLength = inputStream.Read(bytes, 0, maxLength);
        // UTF-8を指定したいが、コマンドプロンプトがSJISなので文字コードをShift-JISに設定
        char[] chars = Encoding.GetEncoding("shift_jis").GetChars(bytes, 0, outputLength);
        return new string(chars);
    }

}

