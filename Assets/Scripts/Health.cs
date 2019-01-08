using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    [SerializeField] int health = 5;
    //[SerializeField] AudioClip deathSound;
    [SerializeField] GameObject deathEffect;

    private void Start()
    {
        if (GetComponent<Attacker>() != null)
            health = health + (health * PlayerPrefsController.GetDifficulty());
        else if (GetComponent<Defender>() != null)
            ;
        else
            return;
    }

    public void DamageHandler(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            DeathHandler();
            Destroy(gameObject);
        }
    }

    private void DeathHandler()
    {
        GameObject deathVFXObject = Instantiate(deathEffect, transform.position, transform.rotation);
        //AudioSource.PlayClipAtPoint(deathSound, transform.position);
        Destroy(deathVFXObject, 1f);
    }

}
