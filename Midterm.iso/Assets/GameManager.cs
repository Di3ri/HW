using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Player;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Transform Player;

   [HideInInspector]
    public bool isGameOver = false;
   [SerializeField]
    public GameObject ui_GameOverPage;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
           
        }
    }

    public void GameOver()
    {
        isGameOver = true;
        ui_GameOverPage.SetActive(true);
        
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
