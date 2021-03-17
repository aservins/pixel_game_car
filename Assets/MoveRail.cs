using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRail : MonoBehaviour
{
    float moveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -9)
        {
            transform.position = new Vector2(0, 9.5f);
        }

        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
    }
}
