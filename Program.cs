using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Створення товарів
        var tovar1 = new Tovar("Ноутбук", 15000, "Потужний ноутбук для роботи", "Електроніка", 4.5);
        var tovar2 = new Tovar("Телефон", 7000, "Смартфон з гарною камерою", "Електроніка", 4.7);
        var tovar3 = new Tovar("Холодильник", 12000, "Великий холодильник", "Побутова техніка", 4.3);

        // Створення користувачів
        var korytuvach1 = new Korytuvach("user1", "password1");
        var korytuvach2 = new Korytuvach("user2", "password2");

        // Створення магазину
        var magazyn = new Magazyn();
        magazyn.AddTovar(tovar1);
        magazyn.AddTovar(tovar2);
        magazyn.AddTovar(tovar3);
        magazyn.AddKorytuvach(korytuvach1);
        magazyn.AddKorytuvach(korytuvach2);

        // Пошук товарів за ціною
        Console.WriteLine("Товари в ціновому діапазоні від 5000 до 10000 грн:");
        var searchByPrice = magazyn.SearchByPrice(5000, 10000);
        magazyn.DisplayTovary(searchByPrice);

        // Пошук товарів за категорією
        Console.WriteLine("\nТовари в категорії 'Електроніка':");
        var searchByCategory = magazyn.SearchByCategory("Електроніка");
        magazyn.DisplayTovary(searchByCategory);

        // Пошук товарів за рейтингом
        Console.WriteLine("\nТовари з рейтингом від 4.5:");
        var searchByRating = magazyn.SearchByRating(4.5);
        magazyn.DisplayTovary(searchByRating);
    }
}
