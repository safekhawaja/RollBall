using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddJump : MonoBehaviour
{

    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    public float jumpspeed = 2f;

    Rigidbody rb;

    void Awake(){
       rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate(){
         if (Input.GetButtonDown("Jump")) { rb.velocity += Vector3.up * jumpspeed; };

         if (rb.velocity.y < 0) {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        } 
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump")) {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }
}
