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
        //coreInfo.GetComponent<TextMesh>().text = $"";
    }
    public void addCore(int x) => coreQuantity += x;
}
