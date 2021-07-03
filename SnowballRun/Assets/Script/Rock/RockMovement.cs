using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMovement : MonoBehaviour
{
    [SerializeField] float velocity=1;
    private readonly int destroyWall = -16;
    private Vector3 direction = new Vector3(0, 0, -1);

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        transform.position += velocity*direction * Time.deltaTime;
        Death();
    }

    private void Death()
    {
        if (transform.position.z < destroyWall)
            Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        GameManager.alive=false;
        Debug.Log("Morto!");
    }
}
