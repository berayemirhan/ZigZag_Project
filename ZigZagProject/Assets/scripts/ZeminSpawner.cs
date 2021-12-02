using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminSpawner : MonoBehaviour
{
   public GameObject sonzemin;
    
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            zemin_olustur();
            
        }
    }
    public void zemin_olustur()
    {
        Vector3 yön;
        if(Random.Range(0,2)==0)
        {
            yön = Vector3.left;
        }
        else
        {
            yön = Vector3.forward;
        }
        sonzemin = Instantiate(sonzemin, sonzemin.transform.position + yön, sonzemin.transform.rotation);
    }
}
