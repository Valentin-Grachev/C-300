using UnityEngine;
using DG.Tweening;
using System.Collections.Generic;

public class HydroSequence : MonoBehaviour
{
    private struct RectWidth
    {
        public RectTransform rectTransform;
        public float width;

        public RectWidth(RectTransform rectTransform, float width)
        {
            this.rectTransform = rectTransform;
            this.width = width;
        }
    }


    [SerializeField] private float _speed;
    [SerializeField] private List<RectTransform> _rectangles;

    private List<RectWidth> _rectSequence = new List<RectWidth>();

    private void Awake()
    {
        foreach (var image in _rectangles)
            _rectSequence.Add(new RectWidth(image, image.sizeDelta.x));
    }


    public void Run()
    {
        var sequence = DOTween.Sequence();

        foreach (var rect in _rectSequence)
        {
            var rectTransform = rect.rectTransform;
            float width = rect.width;
            float duration = width / _speed;

            rectTransform.sizeDelta = new Vector2(0f, rectTransform.sizeDelta.y);

            sequence.Append(rectTransform.DOSizeDelta
                (new Vector2(width, rectTransform.sizeDelta.y), duration).SetEase(Ease.Linear));
        }

        sequence.Play();
    }

}
