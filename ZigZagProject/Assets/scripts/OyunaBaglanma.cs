using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunaBaglanma : MonoBehaviour
{
     public void oyunagiris()
    {
        SceneManager.LoadScene(1);
    }
    public void oyundançıkış()
    {
        Application.Quit();
    }
    public void menü()
    {
        SceneManager.LoadScene(0);
    }

}
