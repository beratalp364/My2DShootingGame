using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameController : MonoBehaviour
{
    public GameObject crabSpawn;
    public GameObject crabSpawn2;
    public GameObject crabSpawn3;
    public GameObject crabSpawn4;

    float height, width, waitSeconds=3f;
    
    public int score = 0;

    public TextMeshProUGUI scoreText;
    
    public bool isGameOver = false;

    
    void Start()
    {
            StartCoroutine(spawnCrab());
        
    }

    private void Update()
    {
        scoreText.text = score.ToString();
    }
    
    public IEnumerator spawnCrab()
    {
        while (!isGameOver)
        {
            Instantiate(crabSpawn, new Vector3(8.7f, Random.Range(-height, height), 0), Quaternion.identity);
            Instantiate(crabSpawn2, new Vector3(-9f, 3.7f, 0), Quaternion.identity);
            Instantiate(crabSpawn3, new Vector3(Random.Range(-width, width),4.3f , 0), Quaternion.identity);
            Instantiate(crabSpawn4, new Vector3(Random.Range(-width, width), -4.5f, 0), Quaternion.identity);
            
           
            yield return new WaitForSeconds(waitSeconds);
        }
        
    }

}
