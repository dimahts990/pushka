using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour//отображение и хранение очков
{
    public int scoreQuantity;
    public static score Score;

    private void Awake()
    {
        Score = this;
        scoreQuantity = 0;
    }

    public void ScoreAdd(int quantity)
    {
        scoreQuantity += quantity;
        GetComponent<Text>().text = scoreQuantity.ToString();
    }
}
