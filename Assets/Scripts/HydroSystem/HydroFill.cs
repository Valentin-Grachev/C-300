using UnityEngine;
using DG.Tweening;


public class HydroFill : HydroItem
{
    [SerializeField] private Transform _sortParent;


    private RectTransform _rectTransform;
    private float _width;


    private const float speed = 1000f;


    public override void Initialize()
    {
        if (_sortParent == null) Debug.LogError("Parent is null! GameObject: " + name + " " + transform.parent.name);
        transform.SetParent(_sortParent);
        onAnimated = null;
        _rectTransform ??= GetComponent<RectTransform>();
        _width = _rectTransform.sizeDelta.x;
        _rectTransform.sizeDelta = new Vector2(0f, _rectTransform.sizeDelta.y);
    }

    public override void Animate()
    {
        float duration = _width / speed;

        _rectTransform.DOSizeDelta(new Vector2(_width, _rectTransform.sizeDelta.y), duration)
            .SetEase(Ease.Linear)
            .onComplete += () => onAnimated?.Invoke();
    }

    
}
