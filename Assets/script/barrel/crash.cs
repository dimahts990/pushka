using System.Collections;
using UnityEngine;

public class crash : MonoBehaviour//управление трещинами на стене
{
    void Start() => StartCoroutine(Des());

    private IEnumerator Des()
    {
        yield return new WaitForSeconds(5);
        for (float a = 1; a > 0; a -= Time.deltaTime)
        {
            GetComponent<SpriteRenderer>().color = new Color(0,0,0,a);
            yield return new WaitForSeconds(0.02f);
        }
        Destroy(this.gameObject);
    }
}
