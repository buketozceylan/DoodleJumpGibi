using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;

    private float horizontal;
    public float velocity;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();

    }
    private void Update() {
        horizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontal*velocity*250*Time.deltaTime,rb.velocity.y);
    }
}
