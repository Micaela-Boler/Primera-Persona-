using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("Activar panel de victoria")]
    [SerializeField] TextMeshProUGUI remainingEnemyText;
    [SerializeField] TextMeshProUGUI youWin;
    public GameOver screen;
    public int remainingEnemies;

    void Start()
    {
        remainingEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        UpdateUI();
    }


    void UpdateUI()
    {
        remainingEnemyText.text = remainingEnemies.ToString();
    }


    public void EnemyKilled()
    {
        remainingEnemies--;
        UpdateUI();

        if (remainingEnemies == 0) 
        { screen.activeScreen(); }
    }


    // Reiniciar
    public void Reset()
    {
        SceneManager.LoadScene(0);
    }


   
}


