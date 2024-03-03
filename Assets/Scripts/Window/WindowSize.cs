using UnityEngine;


public class WindowSize : MonoBehaviour
{
    [SerializeField] private RectTransform _window;
    [SerializeField] private float _step = 100f;


    public void IncreaseWidth()
    {
        _window.sizeDelta += Vector2.right * _step;
    }

    public void DecreaseWidth()
    {
        _window.sizeDelta -= Vector2.right * _step;
    }

    public void IncreaseHeight()
    {
        _window.sizeDelta += Vector2.up * _step;
    }


    public void DecreaseHeight()
    {
        _window.sizeDelta -= Vector2.up * _step;
    }



}
