using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuSRC : MonoBehaviour//скрипт для меню
{
    public void classik()
    {
        SceneManager.LoadScene("classic");
    }
    public void TimeKiller()
    {
        SceneManager.LoadScene("timeKiller");
    }
}
