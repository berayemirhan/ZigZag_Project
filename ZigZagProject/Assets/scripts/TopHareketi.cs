using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopHareketi : MonoBehaviour
{
    Vector3 yön;
    public float hız;
    public static bool düştü_mü;
    public ZeminSpawner zeminspawnerscripti;
    public float eklenecekhız;
    
    
    void Start()
    {
        yön = Vector3.forward;
        düştü_mü = false;
    }

    
    void Update()
    {
       if(transform.position.y<=0.5f)
        {
            düştü_mü = true;
            
            
        }
        if(düştü_mü==true)
        {
            return;
        }
        if(Input.GetMouseButtonDown(0))
        {
            if(yön.x==0)
            {
                yön = Vector3.left;
            }
            else
            {
                yön = Vector3.forward;
            }
            hız += eklenecekhız * Time.deltaTime; 
        }
    }
    public void FixedUpdate()
    {
        Vector3 hareket = yön * Time.deltaTime * hız;
        transform.position += hareket;
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag=="zemin")
        {
            Score.score++;
            collision.gameObject.AddComponent<Rigidbody>();
            zeminspawnerscripti.zemin_olustur();
            StartCoroutine(zeminiSil(collision.gameObject));
        }
    }
    IEnumerator zeminiSil(GameObject silinecekzemin)
    {
        yield return new WaitForSeconds(3f);
        Destroy(silinecekzemin);
    }
}
