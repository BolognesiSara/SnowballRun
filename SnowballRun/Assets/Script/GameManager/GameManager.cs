using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [HideInInspector] public static bool alive=true;

    [SerializeField] GameObject inGameUI;
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject spawner;
    [SerializeField] TextMeshProUGUI scoreText;

    private float score = 0;
    private string MenuScene = "StartMenu";
    private string GamePlayScene = "GamePlay";

    private void Start()
    {
        Debug.Log("HEY");
        gameOver.SetActive(false);
        inGameUI.SetActive(true);
        spawner.SetActive(true);
    }

    void Update()
    {
        if (alive)
        {
            score += Time.deltaTime;
            scoreText.text = "Score: " + Mathf.CeilToInt(score);
        }
        else
        {
            Death();
        }
    }

    private void Death()
    {
        score = 0;
        inGameUI.SetActive(false);
        spawner.SetActive(false);
        gameOver.SetActive(true);
    }

    public void Spawn()
    {
        SceneManager.LoadScene(GamePlayScene);
        gameOver.SetActive(false);
        inGameUI.SetActive(true);
        spawner.SetActive(true); 
        alive = true;
    }

    public void GoToMenu()
    {
        alive = true;
        SceneManager.LoadScene(MenuScene);
    }
}
