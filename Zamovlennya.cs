using System;
using System.Collections.Generic;

public class Zamovlennya
{
    public List<Tovar> Tovary { get; set; }
    public int Kilst { get; set; }
    public decimal ZagalnaVartist { get; set; }
    public string Status { get; set; }

    public Zamovlennya(List<Tovar> tovary, int kilst, decimal zagalnaVartist, string status)
    {
        Tovary = tovary;
        Kilst = kilst;
        ZagalnaVartist = zagalnaVartist;
        Status = status;
    }
}
