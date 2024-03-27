using System;
using UnityEngine;


public class ModelAnimation : MonoBehaviour
{
    private static ModelAnimation instance;
    public static event Action onAnimationFinished;

    [SerializeField] private Animator _animator; 
    
    public static float speed { get => instance._animator.speed; set => instance._animator.speed = value; }
    public static void SetTrigger(string name) => instance._animator.SetTrigger(name);

    public void InvokeFinishAnimation() => onAnimationFinished?.Invoke();


    private void Awake()
    {
        instance = this;
    }






}
