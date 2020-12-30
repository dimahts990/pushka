using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelGen : MonoBehaviour
{
    private float t;
    public float timer;
    public int line;
    public GameObject barrel;
    void Update()
    {
        if (t <= 0)
        {
            gen();
            t = timer;
        }
        else t-=Time.deltaTime;        
    }

    void gen()
    {
        GameObject newBarrel;
        switch (line)
        {
            case 1:
                newBarrel = Instantiate(barrel, new Vector3(Random.Range(-2.4f, 2.4f), -3.1f, 10), Quaternion.identity);
                newBarrel.GetComponent<Rigidbody>().AddForce(transform.up * Random.Range(480f,670f));
                break;
            case 2:
                newBarrel = Instantiate(barrel, new Vector3(Random.Range(-3f, 3.2f), -4.1f, 13), Quaternion.identity);
                newBarrel.GetComponent<Rigidbody>().AddForce(transform.up * Random.Range(520f, 770f));
                break;
            case 3:
                newBarrel = Instantiate(barrel, new Vector3(Random.Range(-4f, 4f), -5f, 16), Quaternion.identity);
                newBarrel.GetComponent<Rigidbody>().AddForce(transform.up * Random.Range(570f, 860f));
                break;
            case 4:
                newBarrel = Instantiate(barrel, new Vector3(Random.Range(-5f, 5f), -6f, 19), Quaternion.identity);
                newBarrel.GetComponent<Rigidbody>().AddForce(transform.up * Random.Range(680f, 930f));
                break;
        }
    }
}
