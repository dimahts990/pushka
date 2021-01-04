using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameOver : MonoBehaviour//по названию понятно: скрипт вызывается после проигрыша игрока и предлагает дальнейшие действия
{
    public static gameOver gameover;
    public GameObject Panel;
    public Text itog;
    public bool gameOn;
    public timerInGame tig;
     

    private void Awake()
    {
        gameover = this;
        gameOn = true;
    }

    public void end()
    {
        gameOn = false;
        itog.text = (SceneManager.GetActiveScene().name== "classic") ?$"Твой счёт {score.Score.scoreQuantity}": $"Ты продержался {tig.allTime}";
        Panel.SetActive(true);
    }

    public void reStart()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().name == "classic")? "classic": "timeKiller");
    }
    public void backToMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
