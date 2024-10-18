using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    public ClickerSettings clickerSettings;
    public AutoCollector autoCollector;
    public int energy = 100; // Энергия игрока
    public Text currencyText;
    private int totalCurrency;

    public void OnClick()
    {
        if (energy > 0)
        {
            int currencyEarned = CalculateCurrencyEarned();
            totalCurrency += currencyEarned;
            energy--; 
            UpdateCurrencyUI(); 
            Debug.Log("Currency Earned: " + currencyEarned + " | Total: " + totalCurrency);
        }
    }

    private void UpdateCurrencyUI()
    {
        currencyText.text = "Currency: " + totalCurrency.ToString();
    }

    private int CalculateCurrencyEarned()
    {
        float modifiedBase = clickerSettings.baseCurrencyPerClick * clickerSettings.tapModifier;
        float finalValue = modifiedBase * clickerSettings.otherModifierMultiplier / clickerSettings.otherModifierDivisor;
        
        
        float autoBonus = autoCollector.autoCollectAmount * 0.1f;
        finalValue += autoBonus;

        return Mathf.RoundToInt(finalValue);
    }

    public void AddCurrency(int amount)
    {
        totalCurrency += amount;
        UpdateCurrencyUI();
    }
}
