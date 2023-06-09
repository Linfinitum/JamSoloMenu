using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Cinemachine;



public class ResizeObject : MonoBehaviour
{
    // Variables pour la taille initiale et la taille r�duite de l'objet
    private Vector3 initialSize;
    //public Vector3 reducedSize = new Vector3(200f, 200f, 200f);
    private bool SizePlanet;
    public float Scale;
    public CinemachineVirtualCamera CameraPlay;
    public CinemachineVirtualCamera CameraOptions;
    public CinemachineVirtualCamera CameraQuit;

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
        if (CameraPlay.Priority == 11 || CameraOptions.Priority == 11 || CameraQuit.Priority == 11)
        {
            SizePlanet = false;
        }

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
