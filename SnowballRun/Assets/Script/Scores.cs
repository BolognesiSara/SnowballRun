using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Scores : MonoBehaviour
{
    private float score = 0;
    // [SerializeField] TextMeshPro text;
    [SerializeField] Text text;
    [SerializeField] TextMeshProUGUI scoreText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
     

        scoreText.text = "Score: " + Mathf.CeilToInt(score);
        //text.SetText(score.ToString());
    }
}
