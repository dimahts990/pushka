using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coreSys : MonoBehaviour//отображения количества снарядов
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
        if (SceneManager.GetActiveScene().name == "classic")
        {
            coreInfo.GetComponent<TextMeshPro>().text = (coreQuantity > 0) ? $"{coreQuantity} шт." : "0 шт.";
            if (coreQuantity <= 0)
            {
                gameOver.gameover.end();
            }
        }
    }

    public void addCore(int x) => coreQuantity += x;
}
