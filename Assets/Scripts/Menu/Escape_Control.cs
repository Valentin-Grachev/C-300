using UnityEngine;

public class Escape_Control : MonoBehaviour
{
    [SerializeField] private GameObject _menu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _menu.SetActive(!_menu.activeInHierarchy);
        }
    }


}
