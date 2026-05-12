using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEditor;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{


    // Start is called once before th
    public void Jogar()
    {
       SceneManager.LoadScene("Level1"); 
    }

    public void Sair()
    {
       #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#else
            Application.Quit();
#endif
    }
}
