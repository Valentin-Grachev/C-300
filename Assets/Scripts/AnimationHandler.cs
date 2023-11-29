using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationHandler : MonoBehaviour
{
    [SerializeField] private List<string> _triggers;

    private Animator _animator;



    private void Awake()
    {
        _animator = GetComponent<Animator>();
        Control.onStepChanged += OnStepChanged;
    }

    private void OnStepChanged()
    {
        string triggerName = _triggers[Control.currentStep];
        if (triggerName != string.Empty)
            _animator.SetTrigger(triggerName);

    }
}
