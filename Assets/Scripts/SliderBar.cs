using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderBar : MonoBehaviour
{
    public TMP_Text NumberDisplay;
    public Slider SliderNB;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NumberDisplay.text = "" + (int)(SliderNB.value * 100);
    }
}