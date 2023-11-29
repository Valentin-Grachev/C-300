using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ImageStep_info : Info
{
    [SerializeField] private Image _image;
    [SerializeField] private List<Sprite> _sprites;


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
        _image.sprite = _sprites[Control.currentStep];


    }
}
