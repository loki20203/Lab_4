using System;
using System.Collections.Generic;
using System.Linq;

public class Magazyn : ISearchable
{
    public List<Tovar> Tovary { get; set; }
    public List<Korytuvach> Korytuvachi { get; set; }
    public List<Zamovlennya> Zamovlennya { get; set; }

    public Magazyn()
    {
        Tovary = new List<Tovar>();
        Korytuvachi = new List<Korytuvach>();
        Zamovlennya = new List<Zamovlennya>();
    }

    public void AddTovar(Tovar tovar)
    {
        Tovary.Add(tovar);
    }

    public void AddKorytuvach(Korytuvach korytuvach)
    {
        Korytuvachi.Add(korytuvach);
    }

    public void AddZamovlennya(Zamovlennya zamovlennya)
    {
        Zamovlennya.Add(zamovlennya);
    }

    public List<Tovar> SearchByPrice(decimal minPrice, decimal maxPrice)
    {
        return Tovary.Where(t => t.Tcyna >= minPrice && t.Tcyna <= maxPrice).ToList();
    }

    public List<Tovar> SearchByCategory(string category)
    {
        return Tovary.Where(t => t.Kategoriya.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Tovar> SearchByRating(double minRating)
    {
        return Tovary.Where(t => t.Reyting >= minRating).ToList();
    }

    public void DisplayTovary(List<Tovar> tovary)
    {
        foreach (var tovar in tovary)
        {
            Console.WriteLine(tovar.Info());
        }
    }
}
