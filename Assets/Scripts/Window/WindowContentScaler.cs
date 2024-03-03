using UnityEngine;


public class WindowContentScaler : MonoBehaviour
{
    [SerializeField] private float _sensitivity;
    [SerializeField] private RectTransform _viewport;
    [SerializeField] private RectTransform _content;
    [SerializeField] private RectTransform _center;

    private Vector2 _originContentSizeDelta;


    private void Start()
    {
        _originContentSizeDelta = _content.sizeDelta;
    }


    private void Update()
    {
        if (Input.mouseScrollDelta.y != 0f)
        {
            _content.SetParent(_center);
            _center.localScale = _center.localScale + Vector3.one * _sensitivity * Input.mouseScrollDelta.y;
        }
        else _content.SetParent(_viewport);


    }



}
