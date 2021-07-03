using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 dir;
    public float GetSpeed()
    {
        return speed;
    }
    public Vector3 GetDirection()
    {
        return dir;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
