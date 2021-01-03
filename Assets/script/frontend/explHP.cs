using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class explHP : MonoBehaviour
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
        hp--;
        switch (hp)
        {
            case 3:
                hp1.SetActive(false);
                hp2.SetActive(false);
                hp3.SetActive(false);
                break;
            case 2:
                hp1.SetActive(true);
                hp2.SetActive(false);
                hp3.SetActive(false);
                break;
            case 1:
                hp1.SetActive(true);
                hp2.SetActive(true);
                hp3.SetActive(false);
                break;
            case 0:
                hp1.SetActive(true);
                hp2.SetActive(true);
                hp3.SetActive(true);
                break;
        }
        if (hp <= 0)
        {
            gameOver.gameover.end();
        }
    }

}
