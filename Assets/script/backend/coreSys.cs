using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class coreSys : MonoBehaviour
{
    public GameObject coreInfo;
    public static coreSys coresys;
    public int coreQuantity;

    private void Awake()
    {
        coresys = this;
        coreQuantity = 10;
    }
    private void Update()
    {
        coreInfo.GetComponent<TextMeshPro>().text = $"{coreQuantity} шт.";
        if (coreQuantity <= 0)
        {
            gameOver.gameover.end();
        }
    }

    public void addCore(int x) => coreQuantity += x;
}
