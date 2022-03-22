using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class BestScore : MonoBehaviour
{
    public static BestScore Instance;

    

    public static string userInput;
    public static int userNum;

    private void Awake()
    {


        if (Instance != null)
        {
            Destroy(gameObject);
            return;


        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadInput();
        LoadUser();
        

    }

    private void Update()
    {
        
    }

    [System.Serializable]
    public class SaveData
    {
       
        public string input;
        public int score;
    }

    public void SaveInput()
    {
        SaveData data = new SaveData();
       
        data.score = MainManager.savedScore;


        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    
    public void SaveUser()
    {
        SaveData data = new SaveData();
        data.input = MenuManager.input;
      


        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/save.json", json);
    }

   


    public void LoadInput()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            
            MainManager.savedScore = data.score;

           
            userNum = MainManager.savedScore;
            

        }


    }
    
    public void LoadUser()
    {
        string path = Application.persistentDataPath + "/save.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            MenuManager.input = data.input;
            

            userInput = MenuManager.input;
          
            

        }


    }
    
   

    public void BestScoreUsed()
    {
        
        MainManager.Instance.bestScoreText.text = $"Best Score: {userInput}  {userNum}";
        
       
    }


}//class
