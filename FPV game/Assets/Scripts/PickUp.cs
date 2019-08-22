using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour, IInteractable
{
    public Material defaultMaterial;
    public Material highlightedMaterial;
    private Renderer render;


    private void Start()
    {
        render = GetComponent<Renderer>();
    }

    public void Highlight()
    {
        render.material = highlightedMaterial;
    }

    public void DeHighlight()
    {
        render.material = defaultMaterial;
    }

    public void Interact()
    {

    }
}
