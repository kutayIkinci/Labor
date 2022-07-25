using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueLocomotive : MonoBehaviour
{
    public float speed;
    private Rigidbody rb2;
    public float TurningSpeed = 1f;
    public GameObject DestinationSensor;
    GameObject nextDestination;
    GameObject BlueLocomotivee;
    GameObject BlueHouse;
    bool BlueHousee = false;

    void Lokasyon2()
    {
        BlueLocomotivee = GameObject.FindWithTag("BlueLocomotivee");
        BlueHouse = GameObject.FindWithTag("BlueHouse");
        if (Vector3.Distance(BlueLocomotivee.transform.position, BlueHouse.transform.position) < 3)
        {
            BlueHousee = true;
            rb2.velocity = new Vector3(0, 0, 0);
            TurningSpeed = 0f;

        }

    }
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        nextDestination = DestinationSensor.GetComponent<BlueSensor>().detectedDestination;

        if (nextDestination != null)
        {

            Vector3 lookPos = nextDestination.transform.position - transform.position;
            lookPos.y = 0;
            Quaternion rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * TurningSpeed);
            rb2.velocity = transform.forward * speed;
        }
        Lokasyon2();
    }
}
