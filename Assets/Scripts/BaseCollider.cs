using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCollider : MonoBehaviour {
    [SerializeField] int damagePerAttacker = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Attacker"))
        {
            FindObjectOfType<LivesDisplay>().LivesLost(damagePerAttacker);
            Destroy(collision.gameObject);
        }
    }

}
