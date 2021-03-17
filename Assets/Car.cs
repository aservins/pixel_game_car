using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    //-1 = izquierda
    //0 = en medio 
    //1 = derecha
    int rail = 0; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && rail != -1)
        {
            rail--;
            transform.position = new Vector2(transform.position.x - 1.65f, transform.position.y);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && rail != 1)
        {
            rail++;
            transform.position = new Vector2(transform.position.x + 1.65f, transform.position.y);
        }
    }
}
