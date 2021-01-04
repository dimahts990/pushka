using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endTime : MonoBehaviour//скрипт для отображения оставшегося времени игры (для режима timeKiller)
{
    private Text tim;
    private string hs, ms, ss;
    public int h, m, s, all;
    public string allTime;
    public static endTime endtime;

    private void Awake()
    {
        endtime = this;
        tim = this.gameObject.GetComponent<Text>();
        all = 30;
        s = all;
        StartCoroutine(timeMinus());
    }

    private void Update()
    {
        #region clock
        m = (int)Mathf.Round(all / 60);
        if (m >= 60)
        {
            int tm = m;
            h = (int)Mathf.Round(tm / 60);
            m = tm % 60;
        }
        else h = 0;
        s = all % 60;

        ss = (s < 10) ? $"0{s}" : $"{s}";
        ms = (m < 10) ? $"0{m}" : $"{m}";
        hs = (h < 10) ? $"0{h}" : $"{h}";
        allTime = (h > 0) ? $"{hs}:{ms}:{ss}" : $"{ms}:{ss}";

        tim.text = allTime;
        #endregion
    }
    public void AddTime(int time) => all += time;

    private IEnumerator timeMinus()
    {
        while (all > 0)
        {
            if (h == 0 && m == 0 && s <= 10)
            {
                tim.color = new Color(1, 0, 0);
                for(float i = 0; i <1; i+=0.1f)
                {
                    yield return new WaitForSeconds(0.1f);
                    tim.color = Color.Lerp(new Color(1, 0, 0), new Color(0, 1, 1), i);
                }
                all--;
            }
            else
            {
                yield return new WaitForSeconds(1);
                all--;
            }
        }
        gameOver.gameover.end();
    }
}
