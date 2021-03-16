using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelGen : MonoBehaviour//генерация бочек
{
    private bool readyGen;
    private int q;
    private float m,s;
    public float timer;
    public GameObject barrel,barrelD,bareelBaBah;
    public timerInGame tig;

    private void Awake()
    {
        readyGen = true;
        q = 0;
    }

    private void Update()
    {
        m = tig.m;
        s = tig.s;
        if (readyGen == true && gameOver.gameover.gameOn==true)
        {
            if (m < 1)
            {
                if (s <= 15)
                {
                    q = 1;
                }
                else if (s > 15 && s <= 30)
                {
                    q = 2;
                }
                else if (s > 30 && s <= 45)
                {
                    q = 3;
                }
            }
            else
            {
                if (s <= 15)
                {
                    q = 4;
                }
                else if (s > 15 && s <= 30)
                {
                    q = 5;
                }
                else if (s > 30 && s <= 45)
                {
                    q = 6;
                }
            }
            readyGen = false;
            StartCoroutine(GenSys(q));
        }
    }

    private IEnumerator GenSys(int quantity)
    {
        while (quantity>0)
        {
            switch (Random.Range(0, 8))
            {
                case 6:
                    genD(Random.Range(1, 5));
                    break;
                case 7:
                    genBabah(Random.Range(1, 5));
                    break;
                default:
                    gen(Random.Range(1, 5));
                    break;
            }
            quantity--;
        }
        yield return new WaitForSeconds(timer);
        readyGen = true;
    }

    #region genBarrel
    void gen(int line)
    {
        GameObject newBarrel;
        switch (line)
        {
            case 1:
                newBarrel = Instantiate(barrel, new Vector3(Random.Range(-2.4f, 2.4f), -5.6f, 10), Quaternion.Euler(new Vector3(Random.Range(45f,136f),90f,0f)));
                newBarrel.GetComponent<barrelSetting>().type = Random.Range(1, 10);
                newBarrel.GetComponent<Rigidbody>().AddForce(new Vector3(0,1,0) * Random.Range(480f,770f));
                break;
            case 2:
                newBarrel = Instantiate(barrel, new Vector3(Random.Range(-3f, 3.2f), -7.4f, 13), Quaternion.Euler(new Vector3(Random.Range(45f, 136f), 90f, 0f)));
                newBarrel.GetComponent<barrelSetting>().type = Random.Range(1, 10);
                newBarrel.GetComponent<Rigidbody>().AddForce(new Vector3(0,1,0) * Random.Range(520f,870f));
                break;
            case 3:
                newBarrel = Instantiate(barrel, new Vector3(Random.Range(-4f, 4f), -9f, 16), Quaternion.Euler(new Vector3(Random.Range(45f, 136f), 90f, 0f)));
                newBarrel.GetComponent<barrelSetting>().type = Random.Range(1, 10);
                newBarrel.GetComponent<Rigidbody>().AddForce(new Vector3(0,1,0) * Random.Range(570f, 960f));
                break;
            case 4:
                newBarrel = Instantiate(barrel, new Vector3(Random.Range(-5f, 5f), -11f, 19), Quaternion.Euler(new Vector3(Random.Range(45f, 136f), 90f, 0f)));
                newBarrel.GetComponent<barrelSetting>().type = Random.Range(1, 10);
                newBarrel.GetComponent<Rigidbody>().AddForce(new Vector3(0,1,0) * Random.Range(680f, 1030f));
                break;
        }
    }
    void genD(int line)
    {
        GameObject newBarrel;
        switch (line)
        {
            case 1:
                newBarrel = Instantiate(barrelD, new Vector3(Random.Range(-2.4f, 2.4f), -5.6f, 10), Quaternion.Euler(new Vector3(Random.Range(45f, 136f), 90f, 0f)));
                newBarrel.GetComponent<barrelSetting>().type = 10;
                newBarrel.GetComponent<Rigidbody>().AddForce(new Vector3(0,1,0) * Random.Range(480f, 770f));
                break;
            case 2:
                newBarrel = Instantiate(barrelD, new Vector3(Random.Range(-3f, 3.2f), -7.4f, 13), Quaternion.Euler(new Vector3(Random.Range(45f, 136f), 90f, 0f)));
                newBarrel.GetComponent<barrelSetting>().type = 10;
                newBarrel.GetComponent<Rigidbody>().AddForce(new Vector3(0,1,0) * Random.Range(520f, 870f));
                break;
            case 3:
                newBarrel = Instantiate(barrelD, new Vector3(Random.Range(-4f, 4f), -9f, 16), Quaternion.Euler(new Vector3(Random.Range(45f, 136f), 90f, 0f)));
                newBarrel.GetComponent<barrelSetting>().type = 10;
                newBarrel.GetComponent<Rigidbody>().AddForce(new Vector3(0,1,0) * Random.Range(570f, 960f));
                break;
            case 4:
                newBarrel = Instantiate(barrelD, new Vector3(Random.Range(-5f, 5f), -11f, 19), Quaternion.Euler(new Vector3(Random.Range(45f, 136f), 90f, 0f)));
                newBarrel.GetComponent<barrelSetting>().type = 10;
                newBarrel.GetComponent<Rigidbody>().AddForce(new Vector3(0,1,0) * Random.Range(680f, 1030f));
                break;
        }
    }
    void genBabah(int line)
    {
        GameObject newBarrel;
        switch (line)
        {
            case 1:
                newBarrel = Instantiate(bareelBaBah, new Vector3(Random.Range(-2.4f, 2.4f), -5.6f, 10), Quaternion.Euler(new Vector3(Random.Range(45f, 136f), 90f, 0f)));
                newBarrel.GetComponent<barrelSetting>().type = 11;
                newBarrel.GetComponent<Rigidbody>().AddForce(new Vector3(0,1,0) * Random.Range(480f, 770f));
                break;
            case 2:
                newBarrel = Instantiate(bareelBaBah, new Vector3(Random.Range(-3f, 3.2f), -7.4f, 13), Quaternion.Euler(new Vector3(Random.Range(45f, 136f), 90f, 0f)));
                newBarrel.GetComponent<barrelSetting>().type = 11;
                newBarrel.GetComponent<Rigidbody>().AddForce(new Vector3(0,1,0) * Random.Range(520f, 870f));
                break;
            case 3:
                newBarrel = Instantiate(bareelBaBah, new Vector3(Random.Range(-4f, 4f), -9f, 16), Quaternion.Euler(new Vector3(Random.Range(45f, 136f), 90f, 0f)));
                newBarrel.GetComponent<barrelSetting>().type = 11;
                newBarrel.GetComponent<Rigidbody>().AddForce(new Vector3(0,1,0) * Random.Range(570f, 960f));
                break;
            case 4:
                newBarrel = Instantiate(bareelBaBah, new Vector3(Random.Range(-5f, 5f), -11f, 19), Quaternion.Euler(new Vector3(Random.Range(45f, 136f), 90f, 0f)));
                newBarrel.GetComponent<barrelSetting>().type = 11;
                newBarrel.GetComponent<Rigidbody>().AddForce(new Vector3(0,1,0) * Random.Range(680f, 1030f));
                break;
        }
    }
    #endregion
}
