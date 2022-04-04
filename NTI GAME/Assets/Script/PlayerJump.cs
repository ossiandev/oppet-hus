using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody rigidbody;
    Vector3 jumpVector;


    // Start is called before the first frame update
    void Start()
    {
       rigidbody = GetComponent<Rigidbody>();
    }


    void Jump()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpVector.y = 5f;

        }

        rigidbody.AddForce(jumpVector);



    }


    // Update is called once per frame
    void Update()
    {
 
    }
}
