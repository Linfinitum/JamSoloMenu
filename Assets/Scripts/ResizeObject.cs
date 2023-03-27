using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;



public class ResizeObject : MonoBehaviour
{
    // Variables pour la taille initiale et la taille réduite de l'objet
    private Vector3 initialSize;
    //public Vector3 reducedSize = new Vector3(200f, 200f, 200f);
    private bool SizePlanet;
    public float Scale;

    private void Start()
    {
        // Stocke la taille initiale de l'objet
        initialSize = transform.localScale;
    }

    private void OnMouseEnter()
    {
        // Réduit la taille de l'objet lorsque le curseur de la souris passe dessus

        
        SizePlanet = true;
        
    }

    private void OnMouseExit()
    {
        // Rétablit la taille initiale de l'objet lorsque le curseur de la souris quitte l'objet
        
        SizePlanet = false;
    }

    public void Update()
    {
        if (SizePlanet ==  true)
        {
            //transform.localScale = reducedSize;
            transform.DOScale(Scale, 0.3f);
        }

        else
        {
            transform.DOScale(initialSize, 0.3f);
        }

    }
}
