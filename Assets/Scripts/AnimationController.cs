using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private static AnimationController instance;


    [System.Serializable]
    private struct Step
    {
        public string name;
        public HydroSequence hydroSequence;
        public Transform cameraPosition;
    }

    [SerializeField] private Transform _hydroSystem;
    [SerializeField] private TextMeshProUGUI _stepText;
    [SerializeField] private List<Step> _steps;
    

    public static int currentStepIndex { get; private set; } 



    private void Awake()
    {
        instance = this;
    }


    public static void RunStep(int stepIndex)
    {
        foreach (Transform child in instance._hydroSystem)
            child.gameObject.SetActive(false);


        currentStepIndex = stepIndex;
        var step = instance._steps[stepIndex];

        instance._stepText.text = step.name;
        Camera.main.transform.position = step.cameraPosition.position;
        Camera.main.transform.rotation = step.cameraPosition.rotation;

        step.hydroSequence.gameObject.SetActive(true);
        step.hydroSequence.Run();

    }




}
