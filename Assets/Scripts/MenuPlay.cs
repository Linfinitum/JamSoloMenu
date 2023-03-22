using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MenuPlay : MonoBehaviour
{
    public CinemachineVirtualCameraBase camera1;
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
        }
    }
}
