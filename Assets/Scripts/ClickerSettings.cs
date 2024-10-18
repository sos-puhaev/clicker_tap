using UnityEngine;

[CreateAssetMenu(fileName = "ClickerSettings", menuName = "ScriptableObjects/ClickerSettings", order = 1)]
public class ClickerSettings : ScriptableObject
{
    public int baseCurrencyPerClick = 10;  // Базовая валюта за клик
    public float tapModifier = 1.0f; // Модификатор клика
    public float otherModifierMultiplier = 1.0f;
    public float otherModifierDivisor = 1.0f;
}
