using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class BackButton : MonoBehaviour
{
    
    public CinemachineVirtualCameraBase _camera;
    public CinemachineVirtualCameraBase menucamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _camera.Priority = 10;
        menucamera.Priority = 11;
    }
}
