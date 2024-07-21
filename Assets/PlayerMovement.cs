using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator playerAnim;

    void Start()
    {
        //playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerAnim.SetBool("Walk", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            playerAnim.SetBool("Walk", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            playerAnim.SetBool("Walk", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            playerAnim.SetBool("Walk", false);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerAnim.SetBool("Walk", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            playerAnim.SetBool("Walk", false);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerAnim.SetBool("Walk", true);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            playerAnim.SetBool("Walk", false);
        }
    }
}
