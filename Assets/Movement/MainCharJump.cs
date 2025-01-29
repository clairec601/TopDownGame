using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCharJump : MonoBehaviour
{
    public GameObject player;
    Animator anim;
    Rigidbody2D rb;
    float moveForce = 3f;
    private bool isGrounded;
    private bool isJumping;
    public float jumpTimeCounter;
    public float jumpTime;
    private bool isBreadColliding;
    [SerializeField] private GameObject dialogueTrigger;
    [SerializeField] private TextAsset inkJSON;

    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.tag == ("Ground")){
            isGrounded = true;
        }

        if (col.gameObject.tag == ("Goal")){
            isBreadColliding = true;
            dialogueTrigger.SetActive(true);
        }
    }

    void OnCollisionExit2D(Collision2D col){
        if (col.gameObject.tag == ("Ground")){
            isGrounded = false;
        }

        if (col.gameObject.tag == ("Goal")){
            isBreadColliding = false;
            dialogueTrigger.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        dialogueTrigger.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isBreadColliding && Input.GetKeyDown(KeyCode.Space) && !BreadDialogueManager.instance.isPlaying){
            BreadDialogueManager.instance.EnterDialogue(inkJSON);
        }

        if (Input.GetKey(KeyCode.UpArrow) && isGrounded){
            isJumping = true;
            rb.velocity = Vector2.up * 5f;
            jumpTimeCounter = jumpTime;
        }
        if (Input.GetKey(KeyCode.UpArrow) && isJumping){
            if (jumpTimeCounter > 0){
                jumpTimeCounter -= Time.deltaTime;
                rb.velocity = Vector2.up * 5f;
            }
            else {
                isJumping = false;
            }
        }
        if (Input.GetKeyUp(KeyCode.UpArrow)){
            isJumping = false;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("isWalkingRight", true);
            rb.velocity = new Vector2(moveForce, rb.velocity.y);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow)){
            anim.SetBool("isWalkingRight", false);
            rb.velocity = Vector2.right * 0;
        }

        if (Input.GetKey(KeyCode.LeftArrow)){
            anim.SetBool("isWalkingLeft", true);
            rb.velocity = new Vector2(-moveForce, rb.velocity.y);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow)){
            anim.SetBool("isWalkingLeft", false);
            rb.velocity = Vector2.left * 0;
        }

        if (!isGrounded){
            anim.SetBool("isWalkingLeft", false);
            anim.SetBool("isWalkingRight", false);
            anim.SetBool("isLeftIdle", false);
            anim.SetBool("isRightIdle", false);
        }
        
    }
}
