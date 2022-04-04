using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{


    Rigidbody Controller;

    public float Speed;

    public Transform Cam;

    Vector3 Movement;


    // Start is called before the first frame update
    void Start()
    {

        Controller = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        float Horizontal = Input.GetAxisRaw("Horizontal") * Speed * Time.deltaTime;
        float Vertical = Input.GetAxisRaw("Vertical") * Speed * Time.deltaTime;

        Movement = Cam.transform.right * Horizontal + Cam.transform.forward * Vertical;
        Movement.y = 0f;




        if (Movement.magnitude != 0f)
        {
            transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * Cam.GetComponent<CameraMove>().sensivity * Time.deltaTime);


            Quaternion CamRotation = Cam.rotation;
            CamRotation.x = 0f;
            CamRotation.z = 0f;

            transform.rotation = Quaternion.Lerp(transform.rotation, CamRotation, 0.1f);

        }
    }

    private void FixedUpdate()
    {
        Controller.AddForce(Movement);
    }

}


