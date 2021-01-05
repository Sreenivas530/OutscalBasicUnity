using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public Button button;
    public string newscene;
    public void Start()
    {  // writing this statement in the start rather than in the update because unity has the standard approaches to take input from the keys
        button.onClick.AddListener(OnButtonClick);
        
    }
    public void OnButtonClick() {
        SceneManager.LoadScene(newscene);
    }
}
