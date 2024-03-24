using UnityEngine;
using DG.Tweening;

public class HydroMove : HydroItem
{
    [SerializeField] private RectTransform _moveObject;
    [SerializeField] private RectTransform _newPosition;

    private Vector3 _originPosition = Vector3.zero;

    private const float moveDuration = 1f;


    public override void Initialize()
    {
        onAnimated = null;

        if (_originPosition == Vector3.zero)
            _originPosition = _moveObject.localPosition;

        _moveObject.localPosition = _originPosition;
    }

    public override void Animate()
    {
        _moveObject.DOLocalMove(_newPosition.localPosition, moveDuration)
            .SetEase(Ease.Linear)
            .onComplete += () => onAnimated?.Invoke();

    }

    
}
