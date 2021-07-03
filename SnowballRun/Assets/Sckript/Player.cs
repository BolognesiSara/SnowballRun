using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float forwardVelocity;
    [SerializeField] private float lateralVelocity;
    [SerializeField] private float jumpStrenght;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.left * forwardVelocity * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.right * forwardVelocity * Time.deltaTime;
        }
           
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * jumpStrenght * Time.deltaTime;
        }
           
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            transform.position += Vector3.down * jumpStrenght * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.forward * lateralVelocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.back * lateralVelocity * Time.deltaTime;
        }

    }
}
