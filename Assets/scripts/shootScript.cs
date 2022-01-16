using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootScript : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject bullet_;
    GameObject bullet;
    public float bulletSpeed = 25f;
    Rigidbody2D rigid2;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            fire();
        }

    void fire()
    {
            bullet = Instantiate(bullet_, shootPoint.position, shootPoint.rotation);
            rigid2 = bullet.GetComponent<Rigidbody2D>();
            rigid2.AddForce(shootPoint.up * bulletSpeed, ForceMode2D.Impulse);
    }
}
}
