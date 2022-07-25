using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locomitive : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public float TurningSpeed = 1f;
    public GameObject DestinationSensor;
    GameObject nextDestination;
    GameObject RedHouse;
    GameObject RedLocomotive;
    GameObject BlueLocomotive;
    GameObject BlueHouse;
    bool RedHousee = false;
    bool BlueHousee = false;

    void Lokasyon() {
        RedLocomotive = GameObject.FindWithTag("RedLocomotive");
        RedHouse = GameObject.FindWithTag("RedHouse");
        if (Vector3.Distance(RedLocomotive.transform.position,RedHouse.transform.position)<3)
        {
            RedHousee = true;
            rb.velocity = new Vector3(0, 0, 0);

        }

    }

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        nextDestination = DestinationSensor.GetComponent<DestinationSensor>().detectedDestination;

        if (nextDestination != null)
        {
        
            Vector3 lookPos = nextDestination.transform.position - transform.position;
            lookPos.y = 0;
            Quaternion rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * TurningSpeed);
            rb.velocity = transform.forward * speed;
        }
        Lokasyon();
        //Lokasyon2();
        if (BlueHousee && RedHousee)
        {
            Debug.Log("TEBRÝKLER KAZANDINIZ.");
        }
    }
}
