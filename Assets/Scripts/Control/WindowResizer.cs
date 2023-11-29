using UnityEngine;

public class WindowResizer : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    private void Start()
    {
        Resize(0.5f);
    }

    public void Resize(float scale)
    {
        _camera.rect = new Rect(x: 0f, y: 1f - scale, width: scale * 0.8f, height: scale);

    }


}
