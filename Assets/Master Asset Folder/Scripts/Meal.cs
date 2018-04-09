using UnityEngine;

[CreateAssetMenu]
[System.Serializable]
public class Meal : ScriptableObject
{
    [Header("Meal Details")]
    public string mealName; // name of meal
    public int mealNumber; // unique number
    public float mealCost; // meal cost
    public Sprite mealSprite; // meal sprite
    public float mealHealth; // value of how healthy/unhealthy meal is
    public bool healthy; // tick if the meal is healthy
    public Sprite orderCard;
   

    [Header("Ingredients")]
    public Ingredient ingredient1; 
    public Ingredient ingredient2;
}

