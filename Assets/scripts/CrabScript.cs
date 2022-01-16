using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CrabScript : MonoBehaviour
{
    
    
    public Rigidbody2D rigid;
    public GameController totalScore;
    public Transform targetedCharacter;
    
    public Vector3 characterPosition;
    public Vector3 crabPosition;

    public float crabSpeed=1;
    public double tempSpeed = 0;
    

    private void Start()
    {
        
    }

    private void Update()
    {
        crabPosition = transform.position;
        characterPosition = targetedCharacter.position;
        transform.position = Vector3.MoveTowards(crabPosition,Vector3.Lerp(crabPosition, characterPosition, (crabSpeed + (float)tempSpeed) * Time.deltaTime), (crabSpeed + (float)tempSpeed)* Time.deltaTime );
        
        tempSpeed = tempSpeed + 0.0001;
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("bullet")) {

            totalScore.score += 1; 
            Destroy(this.gameObject);
            
           
        }
    }
    

}
