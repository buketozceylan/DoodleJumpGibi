using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingFloor : MonoBehaviour
{
    public float jumpForce = 20f;
    private void OnCollisionEnter2D(Collision2D collision) {
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            Vector2 jump = rb.velocity;
            jump.y=jumpForce;
            rb.velocity = jump;
        }
    }
}
