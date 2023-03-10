using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform lookAt;
    public float boundX = 0.25f;
    public float boundY = 0.15f;

    private void LateUpdate() {
        Vector3 delta = Vector3.zero;

        // Checks if the player is inside the bounds on the x axis
        float deltaX = lookAt.position.x - transform.position.x;
        if(deltaX > boundX || deltaX < -boundX)
        {
            if(transform.position.x < lookAt.position.x)
            {
                delta.x = deltaX - boundX;
            } else
            {
                delta.x = deltaX + boundX;
            }
        }

        // Checks if the player is inside the bounds on the y axis
        float deltaY = lookAt.position.y - transform.position.y;
        if(deltaY > boundY || deltaY < -boundY)
        {
            if(transform.position.y < lookAt.position.y)
            {
                delta.y = deltaY - boundY;
            } else
            {
                delta.y = deltaY + boundY;
            }
        }

        transform.position += new Vector3(delta.x, delta.y, 0);
    }

}
