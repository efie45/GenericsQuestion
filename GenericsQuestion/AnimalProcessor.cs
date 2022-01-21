namespace GenericsQuestion;

public class AnimalProcessor
{
    private string GetAnimalNickname<TAnimal>(TAnimal animal )
    where TAnimal : IAnimal<IFood>
    {
        return animal.Nickname;
    }
    
    public string CatNameAndFood(Cat cat)
    {
        var nickname = GetAnimalNickname(cat);
        return $"{nickname}:{cat.FoodList[0].CatFoodName}";
    }

    public string DogNameAndFood(Dog dog)
    {
        var nickname = GetAnimalNickname(dog);
        return $"{nickname}:{dog.FoodList[0].DogFoodName}";
    }
}
