using System.Collections;
using UnityEngine;
using Cinemachine;
using DG.Tweening;
using System;

public class MenuOptions : MonoBehaviour
{
    public CinemachineVirtualCameraBase camera2;
    public GameObject OptionsMenu;
    [SerializeField] float TimeToWait;
    // Start is called before the first frame update
    void Start()
    {
        OptionsMenu.transform.DOScale(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (camera2.Priority == 11)
        {
            Debug.Log("menu options");
            OptionsMenu.SetActive(true);
            StartCoroutine(SpawnOptionsMenu());
        }
        else
        {
            OptionsMenu.SetActive(false);
        }
    }
    
    IEnumerator SpawnOptionsMenu()
    {
        yield return new WaitForSeconds(TimeToWait);
        OptionsMenu.transform.DOScale(1, 1);
    }
}

