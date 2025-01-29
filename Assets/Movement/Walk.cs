using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;

public class Walk : MonoBehaviour
{
    public GameObject player;
    Animator anim;
    Rigidbody2D rb;
    float moveForce = 4f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueManager.instance.isPlaying){
            rb.velocity = Vector2.zero;
        }
        else {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("isWalkingForward", true);
            if (anim.GetBool("isWalkingForward")){
                rb.velocity = new Vector2(0, -moveForce);
            }
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow)){
            rb.velocity = Vector2.down * 0;
            anim.SetBool("isWalkingForward", false);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("isWalkingBackward", true);
            
            if (anim.GetBool("isWalkingBackward")){
                rb.velocity = new Vector2(0, moveForce);
            }
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow)){
            rb.velocity = Vector2.up * 0;
            anim.SetBool("isWalkingBackward", false);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("isWalkingRight", true);
            
            if (anim.GetBool("isWalkingRight")){
                rb.velocity = new Vector2(moveForce, 0);
            }
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow)){
            rb.velocity = Vector2.right * 0;
            anim.SetBool("isWalkingRight", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("isWalkingLeft", true);
            
            if (anim.GetBool("isWalkingLeft")){
                rb.velocity = new Vector2(-moveForce, 0);
            }
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow)){
            rb.velocity = Vector2.left * 0;
            anim.SetBool("isWalkingLeft", false);
        }
        }
      
    }
}
