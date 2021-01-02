using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerInGame : MonoBehaviour
{
    private Text tim;
    private int h, m, s;
    private string hs, ms, ss;
    //private IEnumerator t;

    private void Awake()
    {
        tim = this.gameObject.GetComponent<Text>();
        //t = whaitAndPrint();
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

        if (h > 0) tim.text = $"{hs}:{ms}:{ss}";
        else tim.text = $"{ms}:{ss}";
        #endregion

        


        //StartCoroutine(t);
    }

    /*private IEnumerator whaitAndPrint()
    {
        yield return new WaitForSeconds(1);

        if (s <= 59)
        {
            s++;
        }
        else
        {
            s=0;
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
    }*/
}
