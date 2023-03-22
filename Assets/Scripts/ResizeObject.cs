using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ResizeObject : MonoBehaviour
{
    // Variables pour la taille initiale et la taille r�duite de l'objet
    private Vector3 initialSize;
    public Vector3 reducedSize = new Vector3(200f, 200f, 200f);
    private bool SizePlanet;

    private void Start()
    {
        // Stocke la taille initiale de l'objet
        initialSize = transform.localScale;
    }

    private void OnMouseEnter()
    {
        // R�duit la taille de l'objet lorsque le curseur de la souris passe dessus
       

        SizePlanet = true;
        
    }

    private void OnMouseExit()
    {
        // R�tablit la taille initiale de l'objet lorsque le curseur de la souris quitte l'objet
        
        SizePlanet = false;
    }

    public void Update()
    {
        if (SizePlanet ==  true)
        {
            transform.localScale = reducedSize;
        }

        else
        {
            transform.localScale = initialSize;
        }

    }
}