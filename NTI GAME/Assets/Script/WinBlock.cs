using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBlock : MonoBehaviour
{

    public RestartScene restart;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //Load Win Scene
            restart.RestartShow();

        }
    }
}
