using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MenuOptions : MonoBehaviour
{
    public CinemachineVirtualCameraBase camera2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (camera2.Priority == 11)
        {
            Debug.Log("menu options");
        }
    }
}

