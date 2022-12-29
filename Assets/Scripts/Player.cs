using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private BoxCollider2D BoxCollider;
    private Vector3 moveDelta;
    private float x = 0;
    private float y = 0;

    private void Start()
    {
        BoxCollider = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        // Reset MoveDelta
        moveDelta = new Vector3(x, y, 0);

        // Swap which direction the sprite is facing based on movement
        if(moveDelta.x > 0) {
            transform.localScale = Vector3.one;
        } else if(moveDelta.x < 0) {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        // Moving the sprite
        transform.Translate(moveDelta * Time.deltaTime);
    }
}
