using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coreBonus : MonoBehaviour//скрипт для отображения прибавленя (или отбавления) снарядов (или времени) за поподание в бочку
{
    private void Update()
    {
        transform.position += transform.up * Time.deltaTime;
        GetComponent<TextMesh>().color -= new Color(0, 0, 0, Time.deltaTime);
        if (GetComponent<TextMesh>().color.a <= 0) Destroy(this.gameObject);
    }
    public void info(bool add,int core)
    {
        if (add == true)
        {
            GetComponent<TextMesh>().color = new Color(0.2078431f, 1, 0, 1);
            GetComponent<TextMesh>().text = $"+{core}";
        }
        else
        {
            GetComponent<TextMesh>().color = new Color(1, 0.03921569f, 0, 1);
            GetComponent<TextMesh>().text = $"-{core}";
        }
    }
}
