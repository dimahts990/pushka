using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerInGame : MonoBehaviour//общий ход времени игры
{
    public int h, m, s;
    private string hs, ms, ss;
    private float x;
    public string allTime;

    private void Update()
    {
        #region clock
        ss = (s < 10) ? $"0{s}" : $"{s}";
        ms = (m < 10) ? $"0{m}" : $"{m}";
        hs = (h < 10) ? $"0{h}" : $"{h}";

        allTime = (h > 0) ? $"{hs}:{ms}:{ss}" : $"{ms}:{ss}";
        #endregion

        if (gameOver.gameover.gameOn == true) x += Time.deltaTime;
        
        if (x >= 1)
        {
            if (s <= 59)
            {
                s++;
            }
            else
            {
                s = 0;
                if (m <= 59)
                {
                    m++;
                }
                else
                {
                    m = 0;
                    h++;
                }
            }
            x = 0;
        }
    }
}
