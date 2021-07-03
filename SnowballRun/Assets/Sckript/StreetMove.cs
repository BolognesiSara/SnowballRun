using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetMove : MonoBehaviour
{
    Manager manager;
    private MeshRenderer streetRender;
    private Vector3 streetStats;
    private Vector3 Offset;
    private Material streetMat;

    // chiamato prima di tutti gli "Start() { }" di ogni Script
    void Awake()
    {
        streetRender = GetComponent<MeshRenderer>();
        streetMat = streetRender.material;
        manager = FindObjectOfType<Manager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        streetStats = manager.GetSpeed() * manager.GetDirection() * Time.deltaTime;
        Offset = streetMat.GetTextureOffset("_MainTex");
        Offset += streetStats;
        streetMat.SetTextureOffset("_MainTex", Offset);
    }

}
