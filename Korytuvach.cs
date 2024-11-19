using static Magazyn;
using System;
using System.Collections.Generic;

public class Korytuvach
{
    public string Login { get; set; }
    public string Parol { get; set; }
    public List<Zamovlennya> IstoriyaPokupok { get; set; }

    public Korytuvach(string login, string parol)
    {
        Login = login;
        Parol = parol;
        IstoriyaPokupok = new List<Zamovlennya>();
    }
}
