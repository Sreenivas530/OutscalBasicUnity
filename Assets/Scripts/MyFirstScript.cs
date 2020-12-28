using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{  // this function is called even before start
    public void Awake()
    {
        Debug.Log("This is Awake funtion");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is the first scirp that i am using");
        
    } 

    // Update is called once per frame
    void Update()
    {
        Debug.Log("This is the update function");
    }
    //anything like physics is related to lateupdate and else everything is related to update
    public void LateUpdate()
    {
        Debug.Log("This is Lateupdate Function");
    }
    private void OnDestroy()
    {
        //inorder to cleanup something we use ondestory
        Debug.Log("Object got destoryed");
    }
}
