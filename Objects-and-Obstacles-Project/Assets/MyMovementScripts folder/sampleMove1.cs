using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sampleMove1 : MonoBehaviour   //class name similar to file name in assets folder
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(new Vector3(1,1,0) * Time.deltaTime * speed);
        }
    }
}
