using UnityEngine;

public class HydroModelAnimation : HydroItem
{
    [SerializeField] private AnimationClip _clip;
    [SerializeField] private float _duration;


    public override void Animate()
    {
        float clipDuration = _clip.length;
        ModelAnimation.speed = clipDuration / _duration;
        ModelAnimation.SetTrigger(_clip.name);

    }

    public override void Initialize()
    {
        ModelAnimation.onAnimationFinished -= OnAnimationFinished;
        ModelAnimation.onAnimationFinished += OnAnimationFinished;
    }

    private void OnAnimationFinished() => onAnimated?.Invoke();

}
