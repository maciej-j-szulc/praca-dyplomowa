using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem {

    static string path = Application.persistentDataPath + "/gamesave.gg";
    public static void SaveGame(DataManager PlayerProgress)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData gamedata = new GameData(PlayerProgress);
        Debug.Log("Before saving");
        Debug.Log(gamedata.BeachCounter);
        Debug.Log(gamedata.BeachLevelActivated);
        Debug.Log("Plaża" + gamedata.BeachScore);
        Debug.Log("Biblioteka" + gamedata.LibraryScore);
        formatter.Serialize(stream, gamedata);
        stream.Close();
    }

    public static GameData LoadGame()
    {
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            GameData data = formatter.Deserialize(stream) as GameData;
            Debug.Log("Before loading");
            Debug.Log(data.BeachCounter);
            Debug.Log(data.BeachLevelActivated);
            Debug.Log(path);
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("ERROR nie ma sava" + path);
            return null;
        }
    }

}
