using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(2,2,2);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(20, 20, 20);
        }
    }
}
