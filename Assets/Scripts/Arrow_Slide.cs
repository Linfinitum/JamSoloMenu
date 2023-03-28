using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Arrow_Slide : MonoBehaviour
{
    public TMP_Text TextDisplay;
    public string[] Texts;
    private int _count;
    public void UpdateText(int numbers)
    {
        _count += numbers;
        if (_count >= Texts.Length)
        {
            _count = 0;
        }
        if (_count < 0)
        {
            _count = Texts.Length - 1;
        }
        TextDisplay.text = Texts[_count];
    }
    // Start is called before the first frame update
    void Start()
    {
        TextDisplay.text = Texts[0];
    }

    // Update is called once per frame
    void Update()
    {

    }
}