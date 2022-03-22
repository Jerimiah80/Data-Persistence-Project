using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    public static string input;

    private void Awake()
    {
        Instance = this;
        
    }

    public void ReadStringInput(string userInput)
    {
        input = userInput;
        
        BestScore.Instance.SaveUser();

    }

    
}//class




