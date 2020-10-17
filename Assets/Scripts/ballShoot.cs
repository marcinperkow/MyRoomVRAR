using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballShoot : MonoBehaviour
{
    public GameObject cannon;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject newBall = GameObject.Instantiate(ball, cannon.transform.position, cannon.transform.rotation) as GameObject;
            newBall.GetComponent<Rigidbody>().velocity += Vector3.up * 2;
            newBall.GetComponent<Rigidbody>().AddForce(newBall.transform.forward * 300);
        }
    }
}
