using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelSetting : MonoBehaviour
{
    private GameObject barrel;
    private int core;
    private bool add;
    public GameObject barrel_die,addCore;
    public int type;

    void Start()
    {
        barrel = this.gameObject;
        switch (type)
        {
            case 10:
                core = Random.Range(1, 6);
                add = false;
                break;
            case 11:
                break;

            default:
                core = Random.Range(1, 6);
                add = true;
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
        if (other.tag == "core") Die(other.gameObject);
    }

    void Die(GameObject obj)
    {
        Destroy(obj);
        GameObject die = Instantiate(barrel_die, transform.position,Quaternion.Euler(transform.rotation.eulerAngles));
        if (type != 11)
        {
            Instantiate(addCore, new Vector3(die.transform.position.x, die.transform.position.y + 1.2f, die.transform.position.z), Quaternion.identity).GetComponent<coreBonus>().info(add, core);
            if (add == true) coreSys.coresys.addCore(core);
            else coreSys.coresys.addCore(core * -1);
        }
        else explHP.exp.mHP();

        die.GetComponent<Rigidbody>().AddExplosionForce(1000f, die.transform.position, 10f);
        Destroy(this.gameObject);
    }
}
