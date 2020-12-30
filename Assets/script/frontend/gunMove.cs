using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunMove : MonoBehaviour
{
    private RaycastHit hit;
    private bool readyFier;

    public GameObject gun,trCoreGenerate,gunPlatform,corePrefab;

    private void Update()
    {

        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit) && hit.transform.CompareTag("web"))
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
        if (readyFier == true)
        {
            GameObject core = Instantiate(corePrefab, trCoreGenerate.transform.position, Quaternion.identity);
            core.transform.parent = null;
            core.GetComponent<Rigidbody>().AddForce(trCoreGenerate.transform.forward * 4000f, ForceMode.Force);
            readyFier = false;
        }
    }
}
