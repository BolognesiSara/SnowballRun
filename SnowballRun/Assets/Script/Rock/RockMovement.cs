using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMovement : MonoBehaviour
{
    private int destroyWall=-16;
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        transform.position += new Vector3(0, 0, -1)*Time.deltaTime;
        Death();
    }

    private void Death()
    {
        if (transform.position.z < destroyWall)
            Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Morto!");
    }
}
