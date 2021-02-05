using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class Player : NetworkBehaviour
{

    public float movementSpeed = 0.5f;
    void HandleMovement()
    {
        if(isLocalPlayer)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal * movementSpeed, moveVertical * movementSpeed, 0);
            transform.position = transform.position + movement;
        }
    }

    private void Update()
    {
        //I have added a comment
        HandleMovement();
    }
}
