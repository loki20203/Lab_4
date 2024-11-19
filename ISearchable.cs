using System.Collections.Generic;

public interface ISearchable
{
    List<Tovar> SearchByPrice(decimal minPrice, decimal maxPrice);
    List<Tovar> SearchByCategory(string category);
    List<Tovar> SearchByRating(double minRating);
}
