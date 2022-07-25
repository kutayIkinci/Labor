using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSensor : MonoBehaviour
{
    public GameObject detectedDestination;
    // Start is called before the first frame update

    void Start()
    {
        detectedDestination = null;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "trainDestination" || other.tag == "RedHouse")
        {
            detectedDestination = other.gameObject;
            Debug.Log("Destination Point detected");

        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "trainDestination" || other.tag == "RedHouse")
        {
            Debug.Log("Destination Point undetected");
            //detectedDestination = null;

        }

    }
}
