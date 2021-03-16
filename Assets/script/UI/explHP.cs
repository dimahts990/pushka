using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class explHP : MonoBehaviour //скрипт для отображения пропущенных бочек
{
    public GameObject hp1,hp2,hp3;
    public int hp;
    public static explHP exp;

    private void Awake()
    {
        exp = this;
        hp = 3;
        hp1.SetActive(false);
        hp2.SetActive(false);
        hp3.SetActive(false);
    }
    private void Update()
    {
        
    }
    public void mHP()
    {
        Handheld.Vibrate();
        hp--;
        hp1.SetActive((hp < 3) ? true : false);
        hp2.SetActive((hp < 2) ? true : false);
        hp3.SetActive((hp < 1) ? true : false);
        
        if (hp <= 0)
        {
            gameOver.gameover.end();
        }
    }

}
