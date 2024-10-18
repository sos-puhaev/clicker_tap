using UnityEngine;

[CreateAssetMenu(fileName = "ClickerSettings", menuName = "ScriptableObjects/ClickerSettings", order = 1)]
public class ClickerSettings : ScriptableObject
{
    public int baseCurrencyPerClick = 10; 
    public float tapModifier = 1.0f;
    public float otherModifierMultiplier = 1.0f;
    public float otherModifierDivisor = 1.0f;
}
