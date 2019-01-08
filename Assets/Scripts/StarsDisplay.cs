using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsDisplay : MonoBehaviour {

    [SerializeField] int stars = 100;
    Text starsText;

    private void Start()
    {
        starsText = GetComponent<Text>();
        UpdateText();
    }

    private void UpdateText()
    {
        starsText.text = stars.ToString();
    }

    public void AddStars(int starsToAdd)
    {
        stars += starsToAdd;
        UpdateText();
    }

    public void SpendStars(int starsToSpend)
    {
        if (stars >= starsToSpend)
        {
            stars -= starsToSpend;
            UpdateText();
        }
    }

    public bool enoughStars(int amount)
    {
        return stars >= amount;
    }
}
