using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MenuQuit : MonoBehaviour
{
    public CinemachineVirtualCameraBase camera3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (camera3.Priority == 11)
        {
            Debug.Log("menu quit");
        }
    }
}

