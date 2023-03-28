using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using DG.Tweening;

public class MenuQuit : MonoBehaviour
{
    public CinemachineVirtualCameraBase camera3;
    public GameObject QuitMenu;
    [SerializeField] float TimeToWait;
    // Start is called before the first frame update
    void Start()
    {
        QuitMenu.transform.DOScale(0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (camera3.Priority == 11)
        {
            Debug.Log("menu quit");
            QuitMenu.SetActive(true);
            StartCoroutine(SpawnQuitMenu());

        }
        else
        {
            QuitMenu.SetActive(false);
        }
    }

    IEnumerator SpawnQuitMenu()
    {
        yield return new WaitForSeconds(TimeToWait);
        QuitMenu.transform.DOScale(1, 0.5f);
    }
}

