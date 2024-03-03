using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WindowMover : MonoBehaviour, IDragHandler
{
    [SerializeField] private RectTransform _window;

    public void OnDrag(PointerEventData eventData)
    {
        _window.position = eventData.position;
    }
}
