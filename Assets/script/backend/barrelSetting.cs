using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelSetting : MonoBehaviour
{
    private GameObject barrel;
    public GameObject barrel_die;
    public int type;

    void Start()
    {
        barrel = this.gameObject;
        switch (type)
        {
            case 1:
                Debug.Log($"обычная бочка дающая {Random.Range(1, 6).ToString()} снарядов");
                break;
            case 2:
                Debug.Log("бочка, которая должна всё взорвать");
                break;
        }
    }

    void Update()
    {
        if (barrel.transform.position.y <= -6.5f) Destroy(barrel);
        transform.Rotate(new Vector3(1, 1, 1));
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "core")
        {
            Die(other.gameObject);
        }
    }

    void Die(GameObject obj)
    {
        Destroy(obj);
        GameObject die = Instantiate(barrel_die, transform.position, Quaternion.Euler(transform.rotation.eulerAngles));
        die.GetComponent<Rigidbody>().AddExplosionForce(480, transform.position, 2f, 3f);
        Destroy(this.gameObject);
    }
}
