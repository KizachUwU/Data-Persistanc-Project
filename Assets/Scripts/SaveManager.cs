using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager instance;
    public string PlayerName;
    public string highestScorePlayer;
    public int highestScore=0;


    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    class SaveData
    {
        public string Name;
        public int Score;
    }

    public void Save()
    {
        SaveData data = new SaveData();
        data.Name = highestScorePlayer;
        data.Score = highestScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void Load()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highestScorePlayer = data.Name;
            highestScore = data.Score;
        }
    }
}
