using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CustomerStats
{
	[Header("Customer Stats")]
    public string thename; // Name of Customer
    public Sprite sprite; // Customer Sprite
    // public int gold; // amount of gold the customer has
    // public float patience; // how much patience the customer has
    public int foodPreference; // how healthy they prefer to eat

    [Header("Customer Order")]
    public Meal chosenMeal; // chosen meal
	public int orderNumber; // What number order they have
	public float costOfMeal; // cost of the meal
}
