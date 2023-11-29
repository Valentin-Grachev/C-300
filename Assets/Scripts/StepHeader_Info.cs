using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StepHeader_Info : Info
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private List<string> _headers;


    protected override void Subscribe()
    {
        Control.onStepChanged += UpdateValue;
    }

    protected override void Unsubscribe()
    {
        Control.onStepChanged -= UpdateValue;
    }

    protected override void UpdateValue()
    {
        _text.text = _headers[Control.currentStep];


    }




}
