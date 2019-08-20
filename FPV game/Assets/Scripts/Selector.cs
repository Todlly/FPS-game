using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{
    Ray ray;

    private void Awake()
    {
    }

    private void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.gameObject.CompareTag("Interactable"))
            {
                Debug.Log("HitInter");
                PickUp obj = hit.transform.GetComponent<PickUp>();
                obj.Highlight();
            }
        }
    }
}
