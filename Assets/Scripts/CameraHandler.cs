using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private List<Transform> _transforms;


    private void Start()
    {
        _camera.transform.position = _transforms[Control.currentStep].position;
        _camera.transform.rotation = _transforms[Control.currentStep].rotation;
    }


    private void Awake()
    {
        Control.onStepChanged += OnStepChanged;
    }

    private void OnStepChanged()
    {
        _camera.transform.position = _transforms[Control.currentStep].position;
        _camera.transform.rotation = _transforms[Control.currentStep].rotation;
    }
}
