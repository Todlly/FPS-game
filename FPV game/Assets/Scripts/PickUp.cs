using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : Interactable
{
    public Material defaultMaterial;
    public Material highlightedMaterial;
    private Material material;

    private void Awake()
    {
        material = GetComponent<Material>();
    }

    public override void Highlight()
    {
        material = highlightedMaterial;
    }

    public override void DeHighlight()
    {
        material = defaultMaterial;
    }
}
