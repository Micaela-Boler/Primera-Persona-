using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void activeScreen()
    {
        gameObject.SetActive(true);
    }
}
