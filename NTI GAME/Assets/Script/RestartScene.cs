using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{

    // Update is called once per frame
    public GameObject UI;

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void RestartShow()
    {
        Debug.Log("Win");
        UI.SetActive(true);
    }



}
