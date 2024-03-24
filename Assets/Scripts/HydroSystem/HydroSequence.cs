using UnityEngine;
using System.Collections.Generic;

public class HydroSequence : HydroItem
{
    [SerializeField] private List<HydroItem> _items;

    public override void Animate()
    {
        for (int i = 0; i < _items.Count - 1; i++)
        {
            int index = i;
            _items[index].onAnimated += () => _items[index + 1].Animate();
        }

        _items[_items.Count - 1].onAnimated = () => onAnimated?.Invoke();

        _items[0].Animate();
    }

    public override void Initialize()
    {
        foreach (var item in _items) item.Initialize();
    }

    public void Run()
    {
        Initialize();
        Animate();

        
    }

}
