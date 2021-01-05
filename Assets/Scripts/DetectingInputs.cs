using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectingInputs : MonoBehaviour
{
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   // this function will enable the user to identify when he press the key
        if (Input.GetKeyDown(KeyCode.A))
            Debug.Log("A key is downed");
        // this function will tell whether he holds the key or not
        if(Input.GetKey(KeyCode.A))
        { Debug.Log("User pressed A key"); }
        // this command will identigy whether the key is lifted or not
        if (Input.GetKeyUp(KeyCode.A))
            Debug.Log("A key is lifted");
        if (Input.GetMouseButtonDown(0))
            Debug.Log("Left Mouse button is pressed");
        if (Input.GetMouseButton(0))
            Debug.Log("left mouse button is holded");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("left mouse button is released");
        if (Input.GetMouseButton(1))
            Debug.Log("right mouse button is holded");
        if (Input.GetMouseButtonUp(1))
            Debug.Log("right mouse button is pressed");
        if (Input.GetMouseButtonDown(1))
            Debug.Log("right mouse button is released");
    }
    private void LateUpdate()
    {
        
    }
    private void OnDestroy()
    {
        
    }
}
