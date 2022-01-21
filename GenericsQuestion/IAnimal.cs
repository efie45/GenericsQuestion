namespace GenericsQuestion;

public interface IAnimal<T> where T : IFood
{
    string Id { get; set; }
    string Nickname { get; set; }
    List<T> FoodList { get; set; }
}