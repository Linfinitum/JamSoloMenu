using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using DG.Tweening;


public class MenuPlay : MonoBehaviour
{
    public CinemachineVirtualCameraBase camera1;
    public GameObject PlayMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (camera1.Priority == 11)
        {
            Debug.Log("menu play");

            PlayMenu.SetActive(true);
            
        }
        else
        {
            PlayMenu.SetActive(false);
        }

        
    }
}
