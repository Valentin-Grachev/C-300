using UnityEngine;
using DG.Tweening;
using System.Collections.Generic;

public class HydroSequence : MonoBehaviour
{
    [SerializeField] private List<HydroItem> _items;


    public void Run()
    {
        foreach (var item in _items) item.Initialize();

        for (int i = 0; i < _items.Count - 1; i++)
        {
            int index = i;
            _items[index].onAnimated += () => _items[index + 1].Animate();
        }

        _items[0].Animate();
    }

}
