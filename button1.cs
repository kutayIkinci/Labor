using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1 : MonoBehaviour
{
    GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonFunction()
    {
        cube = GameObject.FindWithTag("buttonCube");
        cube.transform.position = new Vector3(0f, 0f, 17.57f);
    }
}
