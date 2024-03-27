using UnityEngine;


public class TestHydroSequence : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            foreach (var item in FindObjectsOfType<HydroItem>(includeInactive: true))
                item.ClearState();

            GetComponent<HydroSequence>().Run();
        }
    }



}
