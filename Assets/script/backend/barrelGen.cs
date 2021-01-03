using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelGen : MonoBehaviour
{
    private float t;
    public float timer;
    public GameObject barrel,barrelD,bareelBaBah;

    void Update()
    {
        if (t <= 0 && gameOver.gameover.gameOn==true)
        {
            int D = Random.Range(0, 4);
            switch (D)
            {
                case 2:
                    genD(Random.Range(1, 5));
                    break;
                case 3:
                    genBabah(Random.Range(1, 5));
                    break;
                default:
                    gen(Random.Range(1, 5));
                    break;
            }
            t = timer;
        }
        else t-=Time.deltaTime;

        timer=(timer>=0.5f)? timer -= 0.001f:0.5f;
    }

    void gen(int line)
    {
        GameObject newBarrel;
        switch (line)
        {
            case 1:
                newBarrel = Instantiate(barrel, new Vector3(Random.Range(-2.4f, 2.4f), -5.6f, 10), Quaternion.Euler(new Vector3(Random.Range(45f,136f),90f,0f)));
                newBarrel.GetComponent<barrelSetting>().type = Random.Range(1, 10);
                newBarrel.GetComponent<Rigidbody>().AddForce(transform.up * Random.Range(480f,770f));
                break;
            case 2:
                newBarrel = Instantiate(barrel, new Vector3(Random.Range(-3f, 3.2f), -7.4f, 13), Quaternion.Euler(new Vector3(Random.Range(45f, 136f), 90f, 0f)));
                newBarrel.GetComponent<barrelSetting>().type = Random.Range(1, 10);
                newBarrel.GetComponent<Rigidbody>().AddForce(transform.up * Random.Range(520f,870f));
                break;
            case 3:
                newBarrel = Instantiate(barrel, new Vector3(Random.Range(-4f, 4f), -9f, 16), Quaternion.Euler(new Vector3(Random.Range(45f, 136f), 90f, 0f)));
                newBarrel.GetComponent<barrelSetting>().type = Random.Range(1, 10);
                newBarrel.GetComponent<Rigidbody>().AddForce(transform.up * Random.Range(570f, 960f));
                break;
            case 4:
                newBarrel = Instantiate(barrel, new Vector3(Random.Range(-5f, 5f), -11f, 19), Quaternion.Euler(new Vector3(Random.Range(45f, 136f), 90f, 0f)));
                newBarrel.GetComponent<barrelSetting>().type = Random.Range(1, 10);
                newBarrel.GetComponent<Rigidbody>().AddForce(transform.up * Random.Range(680f, 1030f));
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
                newBarrel.GetComponent<Rigidbody>().AddForce(transform.up * Random.Range(480f, 770f));
                break;
            case 2:
                newBarrel = Instantiate(barrelD, new Vector3(Random.Range(-3f, 3.2f), -7.4f, 13), Quaternion.Euler(new Vector3(Random.Range(45f, 136f), 90f, 0f)));
                newBarrel.GetComponent<barrelSetting>().type = 10;
                newBarrel.GetComponent<Rigidbody>().AddForce(transform.up * Random.Range(520f, 870f));
                break;
            case 3:
                newBarrel = Instantiate(barrelD, new Vector3(Random.Range(-4f, 4f), -9f, 16), Quaternion.Euler(new Vector3(Random.Range(45f, 136f), 90f, 0f)));
                newBarrel.GetComponent<barrelSetting>().type = 10;
                newBarrel.GetComponent<Rigidbody>().AddForce(transform.up * Random.Range(570f, 960f));
                break;
            case 4:
                newBarrel = Instantiate(barrelD, new Vector3(Random.Range(-5f, 5f), -11f, 19), Quaternion.Euler(new Vector3(Random.Range(45f, 136f), 90f, 0f)));
                newBarrel.GetComponent<barrelSetting>().type = 10;
                newBarrel.GetComponent<Rigidbody>().AddForce(transform.up * Random.Range(680f, 1030f));
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
                newBarrel.GetComponent<Rigidbody>().AddForce(transform.up * Random.Range(480f, 770f));
                break;
            case 2:
                newBarrel = Instantiate(bareelBaBah, new Vector3(Random.Range(-3f, 3.2f), -7.4f, 13), Quaternion.Euler(new Vector3(Random.Range(45f, 136f), 90f, 0f)));
                newBarrel.GetComponent<barrelSetting>().type = 11;
                newBarrel.GetComponent<Rigidbody>().AddForce(transform.up * Random.Range(520f, 870f));
                break;
            case 3:
                newBarrel = Instantiate(bareelBaBah, new Vector3(Random.Range(-4f, 4f), -9f, 16), Quaternion.Euler(new Vector3(Random.Range(45f, 136f), 90f, 0f)));
                newBarrel.GetComponent<barrelSetting>().type = 11;
                newBarrel.GetComponent<Rigidbody>().AddForce(transform.up * Random.Range(570f, 960f));
                break;
            case 4:
                newBarrel = Instantiate(bareelBaBah, new Vector3(Random.Range(-5f, 5f), -11f, 19), Quaternion.Euler(new Vector3(Random.Range(45f, 136f), 90f, 0f)));
                newBarrel.GetComponent<barrelSetting>().type = 11;
                newBarrel.GetComponent<Rigidbody>().AddForce(transform.up * Random.Range(680f, 1030f));
                break;
        }
    }
}
