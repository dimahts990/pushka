using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameOver : MonoBehaviour
{
    public static gameOver gameover;
    public GameObject Panel;
    public Text itog;
    public timerInGame tig;

    private void Awake()
    {
        gameover = this;
    }

    public void end()
    {
        itog.text = $"Ты продержался {tig.allTime}";
        Panel.SetActive(true);
    }

    public void reStart()
    {
        SceneManager.LoadScene("game");
    }
}
