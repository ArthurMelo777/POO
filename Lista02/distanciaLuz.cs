using System;

class Lista03 {
    public static void Main () {
        string[] hms = Console.ReadLine().Split(":");
        uint h = uint.Parse(hms[0]), m = uint.Parse(hms[1]), s = uint.Parse(hms[2]);
        m += h*60; s += m*60;
        Console.WriteLine($"A luz percorreu {300000*s} km nesse intervalo");
    }
}