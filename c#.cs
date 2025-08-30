using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("C#のテスト用プログラムです！");
        
        // 簡単な計算
        int a = 5;
        int b = 3;
        int sum = a + b;
        Console.WriteLine($"a + b = {sum}");

        // ユーザー入力を受け付ける
        Console.Write("あなたの名前を入力してください: ");
        string name = Console.ReadLine();
        Console.WriteLine($"こんにちは、{name}さん！");
    }
}
