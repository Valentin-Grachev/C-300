using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class HydroMove : HydroItem
{
    [SerializeField] private Image _movableImage;
    [SerializeField] private float _duration = 5f;
    [Space(10)]
    [SerializeField] private RectTransform _fromPosition;
    [SerializeField] private RectTransform _toPosition;

    private Color _originColor;
    private Tween _moveTween;
    private Sequence _colorSequence;


    private const float colorChangeDuration = 1f;


    private void Awake()
    {
        _originColor = _movableImage.color;
    }


    public override void Initialize()
    {
        _colorSequence?.Kill();
        _moveTween?.Kill();

        _movableImage.rectTransform.localPosition = _fromPosition.localPosition;
        _movableImage.color = _originColor;
    }

    public override void Animate()
    {
        _moveTween = _movableImage.rectTransform.DOLocalMove
            (_toPosition.localPosition, _duration).SetEase(Ease.Linear);

        _moveTween.onComplete += () =>
        {
            onAnimated?.Invoke();
            _colorSequence.Kill();
            _movableImage.color = _originColor;
        };


        _colorSequence = DOTween.Sequence()
            .Append(_movableImage.DOColor(Color.green, colorChangeDuration / 2f).SetEase(Ease.OutFlash))
            .Append(_movableImage.DOColor(_originColor, colorChangeDuration / 2f).SetEase(Ease.OutFlash))
            .SetLoops(-1);

    }

    
}
