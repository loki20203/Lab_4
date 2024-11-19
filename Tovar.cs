using System;

public class Tovar
{
    public string Nazva { get; set; }
    public decimal Tcyna { get; set; }
    public string Opys { get; set; }
    public string Kategoriya { get; set; }
    public double Reyting { get; set; }

    public Tovar(string nazva, decimal tcyna, string opys, string kategoriya, double reyting)
    {
        Nazva = nazva;
        Tcyna = tcyna;
        Opys = opys;
        Kategoriya = kategoriya;
        Reyting = reyting;
    }

    public string Info()
    {
        return $"Назва: {Nazva}, Ціна: {Tcyna} грн, Опис: {Opys}, Категорія: {Kategoriya}, Рейтинг: {Reyting}";
    }
}
