// See https://aka.ms/new-console-template for more information

using GenericsQuestion;

Dog dog1 = new Dog
{
    Id = "123123",
    Nickname = "Fido", 
    FoodList = new List<DogFood>
    {
       new()
       {
           FoodId = "1", 
           DogFoodName = "PurinaOne"
       }
    }
};

Cat cat1 = new Cat
{
    Id = "789",
    Nickname = "Gato",
    FoodList = new List<CatFood>
    {
        new()
        {
            FoodId = "4",
            CatFoodName = "KittyKibble",
            CatFoodBrand = "MeowMix"
        }
    }
};

