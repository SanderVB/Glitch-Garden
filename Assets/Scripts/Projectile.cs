using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    [Range(0f, 20f)] [SerializeField] float speed = 3f;
    [SerializeField] public int damageToDeal = 1;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Attacker")
        {
            var health = collision.GetComponent<Health>();
            var attacker = collision.GetComponent<Attacker>();
            if (attacker && health)
            {
                health.DamageHandler(damageToDeal);
                Destroy(gameObject);
            }
        }
    }
}
