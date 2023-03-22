using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class UITransitionManager : MonoBehaviour
{
    public CinemachineVirtualCamera currentcamera;
    // Start is called before the first frame update
    void Start()
    {
        currentcamera.Priority ++;
    }

    // Update is called once per frame
    public void UpadateCamera(CinemachineVirtualCamera target)
    {
        currentcamera.Priority--;

        currentcamera = target;

        currentcamera.Priority++;

    }
}
