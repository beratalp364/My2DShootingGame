using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class soldierScript : MonoBehaviour
{
    
    
    public float speed = 5f;
    float reverseAngle;
    public Camera camera;
    public Rigidbody2D rigid;
    
    Vector2 move;
    Vector2 mousePosition;
    Vector2 lookDirection;
    

    private void Update()
    {
       
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");
        mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);

        lookDirection = mousePosition - rigid.position;

        reverseAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        rigid.rotation = reverseAngle;

        

    }


    private void LateUpdate()
    {
        
        rigid.MovePosition(rigid.position + move * speed * Time.fixedDeltaTime);
    
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "crab")
        {
            SceneManager.LoadScene(1);
        }
    }

}
