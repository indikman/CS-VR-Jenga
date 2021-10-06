using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerSwitcher : MonoBehaviour
{
    public GameObject[] ControllerToSwitch;

    [SerializeField] InputActionReference controller_switcher;

    private int selectedController;

    // Start is called before the first frame update
    void Start()
    {
        selectedController = 0;

        foreach(GameObject obj in ControllerToSwitch)
        {
            obj.SetActive(false);
        }

        if (ControllerToSwitch.Length > 0)
            ControllerToSwitch[selectedController].SetActive(true);
    }

    private void OnEnable()
    {
        controller_switcher.action.performed += SwitchController;
    }

    private void OnDisable()
    {
        controller_switcher.action.performed -= SwitchController;
    }

    private void SwitchController(InputAction.CallbackContext obj)
    {
        foreach (GameObject objx in ControllerToSwitch)
        {
            objx.SetActive(false);
        }

        selectedController++;

        if (selectedController >= ControllerToSwitch.Length)
            selectedController = 0;

        if (ControllerToSwitch.Length > 0)
            ControllerToSwitch[selectedController].SetActive(true);
    }
}
