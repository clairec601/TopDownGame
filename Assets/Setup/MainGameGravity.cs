using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameGravity : MonoBehaviour
{    void Awake () {
        Physics2D.gravity = new Vector2(0, 0); //does not need gravity
    }
}
