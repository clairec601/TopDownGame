using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhythmGameNotes : MonoBehaviour
{

    public static bool lastWasDestroyed;
    public KeyCode KeyPress;
    private bool canPress;

    private void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.tag == "Line"){
            canPress = true;
        }
    }

     private void OnTriggerExit2D(Collider2D col){
        if (col.gameObject.tag == "Line"){
            canPress = false;
        }
        if (this.gameObject.tag == "LastNote"){
            lastWasDestroyed = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ManateeDialogueManager.waitToStart){
            transform.position -= new Vector3(0f, 1.5f * Time.deltaTime, 0f);

            if (canPress){
                if (Input.GetKeyDown(KeyPress)){
                    if (this.gameObject.tag == "LastNote"){
                        lastWasDestroyed = true;
                    }
                    Destroy(this.gameObject);
                }
            }
        } 
    }
}
