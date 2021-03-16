using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class barrelSetting : MonoBehaviour//настройка бочек (от настройки типа бочки до их поведения в тех или иных ситуациях
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
        if (barrel.transform.position.y <= -14f && type!=10 && type!=11)
        {
            if (SceneManager.GetActiveScene().name == "classic") explHP.exp.mHP();
            Destroy(barrel);
        }
        else if(barrel.transform.position.y <= -14f) Destroy(barrel);
        transform.Rotate(new Vector3(Random.Range(0.1f,1.1f), Random.Range(0.1f, 1.1f), Random.Range(0.1f, 1.1f)));
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "core") Die();
    }

    void Die()
    {
        GameObject die = Instantiate(barrel_die, transform.position,Quaternion.Euler(transform.rotation.eulerAngles));
        if (type != 11)
        {
            Instantiate(addCore, new Vector3(die.transform.position.x, die.transform.position.y + 1.2f, die.transform.position.z), Quaternion.identity).GetComponent<coreBonus>().info(add, core);
            if (add == true)
            {
                if (SceneManager.GetActiveScene().name == "classic")
                {
                    coreSys.coresys.addCore(core);
                    score.Score.ScoreAdd(core);
                }
                else
                {
                    endTime.endtime.AddTime(core);
                }
            }
            else
            {
                if (SceneManager.GetActiveScene().name == "classic") coreSys.coresys.addCore(core * -1);
                else endTime.endtime.AddTime(core * -1);
            }
            }
        else explHP.exp.mHP();

        die.GetComponent<Rigidbody>().AddExplosionForce(1000f, die.transform.position, 10f);
        Destroy(this.gameObject);
    }
}
