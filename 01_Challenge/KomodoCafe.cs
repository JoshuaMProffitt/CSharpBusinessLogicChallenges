public class KomodoCafe
{
	public enum Ingredients
    {
		BurgerFriesDrink, HotDogFriesDrink, Nachos
    }
    public int MealNumber { get; set; }
	public string Cafe { get; set; }
    public Ingredients OfIngredients { get; set; }
    public string MealName { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public KomodoCafe() { }
    public KomodoCafe(int mealNumber, string mealName, Ingredients ofIngredients, string description, double price)
    {
        MealNumber = mealNumber;
        MealName = mealName;
        OfIngredients = ofIngredients;
        Description = description;
        Price = price;
    }
}