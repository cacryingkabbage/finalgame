using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    [SerializeField] private float damage;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if (collision.tag == "Player")
            collision.GetComponent<Health>().Hurt(damage);
       */
    }
}
