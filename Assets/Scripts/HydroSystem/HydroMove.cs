using UnityEngine;
using DG.Tweening;

public class HydroMove : HydroItem
{
    [SerializeField] private RectTransform _newPosition;

    private RectTransform _rectTransform;
    private Vector3 _originPosition;

    private const float moveDuration = 1f;


    public override void Initialize()
    {
        onAnimated = null;

        if (_rectTransform == null)
        {
            _rectTransform = GetComponent<RectTransform>();
            _originPosition = _rectTransform.position;
        }

        _rectTransform.position = _originPosition;
    }

    public override void Animate()
    {
        _rectTransform.DOMove(_newPosition.position, moveDuration)
            .SetEase(Ease.Linear)
            .onComplete += () => onAnimated?.Invoke();

    }

    
}
