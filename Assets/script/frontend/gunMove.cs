using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gunMove : MonoBehaviour//управление пушкой
{
    private RaycastHit hit;
    private bool readyFier;

    public GameObject gun,trCoreGenerate,gunPlatform,corePrefab;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit) && hit.transform.CompareTag("web") || hit.transform.CompareTag("barrel"))
            {
                readyFier = true;
                gun.transform.LookAt(hit.point);
                gunPlatform.transform.LookAt(new Vector3(hit.point.x,0.35f,hit.point.z));
            }
            else Fier();
        }
        if (Input.GetMouseButtonUp(0)) Fier();

    }
    private void Fier()
    {
        bool ready = false;
        if (SceneManager.GetActiveScene().name == "classic")
        {
            ready = (coreSys.coresys.coreQuantity > 0) ? true : false;
        }
        else ready = true;
        if (readyFier == true && ready==true)
        {
            GameObject core = Instantiate(corePrefab, trCoreGenerate.transform.position, Quaternion.identity);
            core.transform.parent = null;
            core.GetComponent<Rigidbody>().AddForce(trCoreGenerate.transform.forward * 3000f);
            coreSys.coresys.addCore(-1);
            readyFier = false;
        }
    }
}
