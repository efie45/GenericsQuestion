namespace GenericsQuestion;

public class Cat : IAnimal<CatFood>
{
    public string Id { get; set; }
    public string Nickname { get; set; }
    public List<CatFood> FoodList { get; set; }
}