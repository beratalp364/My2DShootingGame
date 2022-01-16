using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class bulletScript : MonoBehaviour
{
    public GameObject effect;
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect_= Instantiate(effect, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
        Destroy(effect_, 0.5f);
        
       

    }


    private void LateUpdate()
    {
        Destroy(this.gameObject,1f);
    }
}
