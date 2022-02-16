using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ballPrefab;
    public int ballSpeed = 15;


    private GameObject inGameBall = null;
    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        SpawnBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (inGameBall)
        {
            MoveBall();
        }
    }

    private void SpawnBall()
    {
        inGameBall = Instantiate(ballPrefab, 
            new Vector3(0,0,0), 
            Quaternion.identity);
    }

    private void MoveBall()
    {
        inGameBall.transform.Translate(inGameBall.GetComponent<Ball>().getDirection() * ballSpeed * Time.deltaTime);
    }
}
