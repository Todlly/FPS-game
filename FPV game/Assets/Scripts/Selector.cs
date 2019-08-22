using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{
    Ray ray;
    public Material material;
    private bool highlighted;
    private IInteractable obj;

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
                obj = hit.transform.gameObject.GetComponent<IInteractable>();
                obj.Highlight();
                highlighted = true;
            }
            else if (highlighted)
            {
                obj.DeHighlight();
                highlighted = false;
            }
        }
        else if (highlighted)
        {
            obj.DeHighlight();
            highlighted = false;
        }
    }
}
