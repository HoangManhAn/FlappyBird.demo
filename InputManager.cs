using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    
    private static InputManager instance;
    public static InputManager Instance => instance;

    private void Awake()
    {
        if (InputManager.instance != null)
        {
            Debug.LogError("Only one InputManager allow to exist");
            Destroy(gameObject);

        }
        InputManager.instance = this;
    }
    
    public bool GetMouse()
    {
        return Input.GetMouseButtonDown(0);
    }

    public void GetKeyboard()
    {
        //Updating
    }



}
