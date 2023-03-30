using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMover : MonoBehaviour
{
    [SerializeField] float thrustPower = 1;
    [SerializeField] float rotationThrust = 1;

    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            PowerThrusters();
            Navigate();
        }


        // transform.Rotate(Vector3.back * rotationThrust * Time.deltaTime * Input.GetAxis("Horizontal"));
        // if (Input.GetKey(KeyCode.A)) {
        //     Navigate(rotationThrust);
        // }
        
        // if (Input.GetKey(KeyCode.D)) {
        //     Navigate(-rotationThrust);
        // }
    }

    private void PowerThrusters()
    {
        rigidbody.AddRelativeForce(Vector3.up * thrustPower * Time.deltaTime);
    }

    private void Navigate()
    {
        rigidbody.freezeRotation = true;
        transform.Rotate(Vector3.back * rotationThrust * Time.deltaTime * Input.GetAxis("Horizontal"));
        rigidbody.freezeRotation = false;
    }
}
