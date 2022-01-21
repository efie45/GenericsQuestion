using GenericsQuestion;

public class Dog : IAnimal<DogFood>
{
    public string Id { get; set; }
    public string Nickname { get; set; }
    public List<DogFood>? FoodList { get; set; }
}
