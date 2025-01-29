using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadGameGravity : MonoBehaviour
{
    void Awake () {
        Physics2D.gravity = new Vector2(0, -9.81f); //relies on normal gravity
    }
}
