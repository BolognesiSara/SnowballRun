using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scores : MonoBehaviour
{
    private int score = 0;
    private MeshRenderer gettoneRenderer;

    private void OnTriggerEnter(Collider other)
    {
        gettoneRenderer = GetComponent<MeshRenderer>();
        if (gettoneRenderer.enabled)
        {
            score++;
            Debug.Log("Il tuo punteggio è: " + score);

        }
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
