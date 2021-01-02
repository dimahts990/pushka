using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerInGame : MonoBehaviour
{
    private Text tim;
    private int h, m, s;
    private string hs, ms, ss;
    private float x;
    public string allTime;

    private void Awake()
    {
        tim = this.gameObject.GetComponent<Text>();
        
    }

    private void Update()
    {
        #region clock
        if (s < 10) ss = $"0{s}";
        else ss = $"{s}";
        if (m < 10) ms = $"0{m}";
        else ms = $"{m}";
        if (h < 10) hs = $"0{h}";
        else hs = $"{h}";

        if (h > 0) allTime = $"{hs}:{ms}:{ss}";
        else allTime = $"{ms}:{ss}";
        tim.text = allTime;
        #endregion

        x += Time.deltaTime;
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
