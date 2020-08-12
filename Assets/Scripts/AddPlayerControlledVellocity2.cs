using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlledVellocity2 : MonoBehaviour
{

    [SerializeField]
    Vector3 v3Force;

    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegative;

    void FixedUpdate()
    {
        if (Input.GetKey(keyPositive))
            gameObject.GetComponent<Rigidbody>().velocity += v3Force; 

        if (Input.GetKey(keyNegative))
            gameObject.GetComponent<Rigidbody>().velocity -= v3Force;
    }
}
