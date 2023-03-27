using System.Collections;
using UnityEngine;
using Cinemachine;
using DG.Tweening;
using System;


public class MenuPlay : MonoBehaviour
{
    public CinemachineVirtualCameraBase camera1;
    public GameObject PlayMenu;
    public float TimeToWait;
    // Start is called before the first frame update
    void Start()
    {
        PlayMenu.transform.DOScale(0,0);


    }

    // Update is called once per frame
    void Update()
    {
        if (camera1.Priority == 11)
        {
            Debug.Log("menu play");

            PlayMenu.SetActive(true);
            StartCoroutine(SpawnPlayMenu());
        }
        else
        {
            PlayMenu.SetActive(false);
        }

        
    }

    IEnumerator SpawnPlayMenu()
    {
        yield return new WaitForSeconds(TimeToWait);
        PlayMenu.transform.DOScale(1, 5);
    }
}
