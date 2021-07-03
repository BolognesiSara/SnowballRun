using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameManager : MonoBehaviour
{
    private string GamePlayScene = "GamePlay";

    public void Spawn()
    {
        SceneManager.LoadScene(GamePlayScene);
    }
}
