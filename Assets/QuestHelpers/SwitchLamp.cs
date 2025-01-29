using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLamp : MonoBehaviour
{ 
    [SerializeField] private GameObject lamp;
    public static SwitchLamp instance { get; private set; }
    Animator lampAnim;

    private void Awake(){
       instance = this;
    }
    private void Start(){
        lampAnim = lamp.GetComponent<Animator>();
    }
    public void switchSprites(string character){
        if ((character.Equals("lamp"))){
            lampAnim.SetBool("isLampAfter", true);
        }
        

    }
}
