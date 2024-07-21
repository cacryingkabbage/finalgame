using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startHealth;
    [SerializeField] private LayerMask spikeLayer;
    private BoxCollider2D boxCollider;
    private float Currenthealth;
    public Animator anim;

    // Start is called before the first frame update
    private void Awake()
    {
        Currenthealth = startHealth;
        boxCollider = GetComponent<BoxCollider2D>();
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    { 
    
        //check if player collides
        if (isHurt())
            {
            //set anim bool once
            if (anim.GetBool("Alive"))
            {
                anim.SetBool("Alive", false);
                GetComponent<Move>().enabled = false;
            }
        }
    
    }

    // Function that checks for collision with spikes/enemis
    private bool isHurt()
    {
        //check for collision with spikes/enemy layer then return true if yes
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, spikeLayer);
        return raycastHit.collider != null;
    }


    /*public void Hurt(float Damage)
    {
        Currenthealth = Mathf.Clamp(Currenthealth - Damage, 0, startHealth);

        if (Currenthealth < 0)
        {
            anim.SetBool("Death", true);
            GetComponent<Move>().enabled = false;
        }
    }*/
}
