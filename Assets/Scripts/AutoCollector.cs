using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AutoCollector : MonoBehaviour
{
    public int autoCollectAmount = 50;
    public float collectInterval = 5.0f;
    public Text currencyText;
    public Text collectTimerText;
    private Clicker clicker;
    private int totalCurrency;

    void Start()
    {
        clicker = FindObjectOfType<Clicker>();

        if (clicker == null)
        {
            Debug.LogError("Clicker object not found!");
        }
        else
        {
            StartCoroutine(AutoCollect());
        }
    }

    private void Update()
    {
        float timeLeft = collectInterval - (Time.time % collectInterval);
        collectTimerText.text = "Начисление через: " + Mathf.CeilToInt(timeLeft).ToString() + " сек.";
    }

    IEnumerator AutoCollect()
    {
        while (true)
        {
            yield return new WaitForSeconds(collectInterval);
            CollectCurrency();
        }
    }

    private void CollectCurrency()
    {
        totalCurrency += autoCollectAmount;

        if (clicker != null)
        {
            clicker.AddCurrency(autoCollectAmount);
        }
        else
        {
            Debug.LogError("Clicker is not assigned!");
        }

        UpdateCurrencyUI();
        Debug.Log("Auto collected: " + autoCollectAmount + " | Total: " + totalCurrency);
    }

    private void UpdateCurrencyUI()
    {
        if (currencyText != null)
        {
            currencyText.text = "Начисление: " + totalCurrency.ToString();
        }
        else
        {
            Debug.LogError("CurrencyText is not assigned!");
        }
    }
}