using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeScaler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;


    private readonly List<float> timeScales = new List<float>
    {
        0, 0.25f, 0.5f, 1f, 2f, 4f, 8f
    };




    public void SetTimeIndex(float index)
    {
        Time.timeScale = timeScales[(int)index];
        _text.text = timeScales[(int)index].ToString();
    }



}
