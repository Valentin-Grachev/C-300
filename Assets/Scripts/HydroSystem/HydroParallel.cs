using System.Collections.Generic;
using UnityEngine;


public class HydroParallel : HydroItem
{
    [SerializeField] private List<HydroItem> _items;

    private int _itemsFinished;


    public override void Initialize()
    {
        _itemsFinished = 0;

        foreach (var item in _items)
        {
            item.Initialize();

            item.onAnimated = () =>
            {
                _itemsFinished++;

                if (_itemsFinished == _items.Count)
                    onAnimated?.Invoke();
            };
        }
            
    }

    public override void Animate()
    {
        foreach (var item in _items)
            item.Animate();
    }

    
}
