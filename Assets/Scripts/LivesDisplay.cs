using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] int lives = 5;
    Text livesText;

    // Use this for initialization
    private void Start()
    {
        lives -= PlayerPrefsController.GetDifficulty();
        livesText = GetComponent<Text>();
        UpdateText();
    }

    private void UpdateText()
    {
        livesText.text = lives.ToString();
    }

    public void LivesLost(int livesLost)
    {
        lives -= livesLost;
        UpdateText();

        if(lives <=0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
}
