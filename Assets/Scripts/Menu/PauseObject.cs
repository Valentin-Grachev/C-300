using UnityEngine;

public class PauseObject : MonoBehaviour
{
    private float _originTimeScale;


    private void OnEnable()
    {
        _originTimeScale = Time.timeScale;
        Time.timeScale = 0f;
    }


    private void OnDisable()
    {
        Time.timeScale = _originTimeScale;
    }

}
