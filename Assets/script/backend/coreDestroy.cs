using System.Collections;
using UnityEngine;

public class coreDestroy : MonoBehaviour//уничтожение снаряда и для трещен на стене от него самого же
{
    private Rigidbody rb;
    public GameObject crack;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (transform.position.y <= -17f) Destroy(this.gameObject);
    }

    [System.Obsolete]
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "web")
        {
            rb.velocity = Vector3.zero;
            rb.useGravity = false;
            rb.isKinematic = true;
            GetComponent<SphereCollider>().enabled = false;
            transform.position = new Vector3(transform.position.x, transform.position.y, 26.61f);
            Instantiate(crack, new Vector3(transform.position.x, transform.position.y, 26.61f), Quaternion.identity);
            StartCoroutine(Ps());
        }
    }

    [System.Obsolete]
    private IEnumerator Ps()
    {
        ParticleSystem p = GetComponentInChildren<ParticleSystem>();
        for(float a = 1; a > 0; a -= Time.deltaTime)
        {
            p.startColor = new Color(1, 1, 1, a);
            yield return new WaitForSeconds(0.005f);
        }
        Destroy(this.gameObject.transform.GetChild(0).gameObject);
        yield return new WaitForSeconds(3);
        rb.isKinematic = false;
        rb.useGravity = true;
    }
}
