using UnityEngine;


public class Test : MonoBehaviour
{
    [SerializeField] private HydroSequence _sequence;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            FindObjectOfType<HydroSequence>().Run();
        }
    }



}
