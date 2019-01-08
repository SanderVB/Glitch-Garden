using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int starCost = 100;
    public Vector2 position;

    public int GetStarCost()
    {
        return starCost;
    }

    public void AddStars(int amount)
    {
        FindObjectOfType<StarsDisplay>().AddStars(amount);
    }
}
