using UnityEngine;
using DG.Tweening;


public class HydroFill : HydroItem
{
    [SerializeField] private Transform _sortParent;


    private RectTransform _rectTransform;
    private float _originWidth;


    private const float speed = 1000f;

    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
        _originWidth = _rectTransform.sizeDelta.x;
    }


    public override void Initialize()
    {
        if (_sortParent == null) Debug.LogError("Parent is null! GameObject: " + name + " " + transform.parent.name);
        transform.SetParent(_sortParent);
        _rectTransform.sizeDelta = new Vector2(0f, _rectTransform.sizeDelta.y);
    }

    public override void Animate()
    {
        float duration = _originWidth / speed;

        _rectTransform.DOSizeDelta(new Vector2(_originWidth, _rectTransform.sizeDelta.y), duration)
            .SetEase(Ease.Linear)
            .onComplete += () => onAnimated?.Invoke();
    }

    
}
