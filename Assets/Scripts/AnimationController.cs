using DG.Tweening;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public enum ProcessType { Opening, Closing }


    private static AnimationController instance;
    public static ProcessType processType = ProcessType.Opening;


    private const float cameraMoveDuration = 0.7f;

    private Tween _moveTween;
    private Tween _rotationTween;



    [System.Serializable]
    private struct Step
    {
        public string name;
        public HydroSequence hydroSequence;
        public Transform cameraPosition;
    }

    [SerializeField] private Transform _hydroSystem;
    [SerializeField] private TextMeshProUGUI _stepText;
    [SerializeField] private List<Step> _openingSteps;
    [SerializeField] private List<Step> _closingSteps;

    public static int currentStepIndex { get; private set; } 


    public static int stepsQuantity => processType == ProcessType.Opening ? 
        instance._openingSteps.Count : instance._closingSteps.Count;


    private void Awake()
    {
        instance = this;

    }

    private void Start()
    {
        RunStep(0);
    }


    public static void RunStep(int stepIndex)
    {
        DOTween.KillAll();
        foreach (Transform child in instance._hydroSystem)
            Destroy(child.gameObject);


        currentStepIndex = stepIndex;

        var step = processType == ProcessType.Opening ?
            instance._openingSteps[stepIndex] : instance._closingSteps[stepIndex];


        instance._stepText.text = step.name;

        instance._moveTween?.Kill();
        instance._moveTween = Camera.main.transform.
            DOMove(step.cameraPosition.position, cameraMoveDuration).SetEase(Ease.OutFlash).SetUpdate(true);

        instance._rotationTween?.Kill();
        instance._rotationTween = Camera.main.transform.
            DORotateQuaternion(step.cameraPosition.rotation, cameraMoveDuration).SetEase(Ease.OutFlash).SetUpdate(true);

        var hydroSequence = Instantiate(step.hydroSequence, instance._hydroSystem);
        hydroSequence.Run();

    }




}
