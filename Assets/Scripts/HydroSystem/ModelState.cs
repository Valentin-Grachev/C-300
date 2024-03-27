using UnityEngine;


public class ModelState : MonoBehaviour
{
    [SerializeField] private AnimationClip _clip;

    private void OnEnable()
    {
        ModelAnimation.SetTrigger(_clip.name);
        ModelAnimation.speed = 0f;
    }

}
