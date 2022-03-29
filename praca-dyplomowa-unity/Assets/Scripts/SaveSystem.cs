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
