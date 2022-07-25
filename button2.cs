using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button2 : MonoBehaviour
{
    GameObject cube2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void buttonFunction2()
    {
        cube2 = GameObject.FindWithTag("cube2");
        cube2.transform.position = new Vector3(10f, 0f, -0.5f);
    }
}
