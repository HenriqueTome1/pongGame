using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 direction;
    void Start()
    {
        direction = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
    }

    public Vector3 getDirection()
    {
        return direction;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "LeftWall" || collision.tag == "RightWall")
        {
            // Points ++
            transform.position = Vector3.zero;
            direction = direction * -1;
        }
    }
}
