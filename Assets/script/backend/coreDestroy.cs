using UnityEngine;

public class coreDestroy : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y <= -7f) Destroy(this.gameObject);
    }
}
