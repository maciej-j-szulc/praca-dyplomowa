using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject competeLevelUI;

    public void CompleteLevel()
    {
        competeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            AddToCounter(SceneManager.GetActiveScene().name);
            Invoke("Restart", restartDelay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void AddToCounter(string name)
    {
        switch (name)
        {
            case "BeachLevel":
                DataManager.Instance.BeachCounter += 1;
                break;
            case "ShopLevel":
                DataManager.Instance.ShopCounter += 1;
                break;
            case "ChurchLevel":
                DataManager.Instance.ChurchCounter += 1;
                break;
            case "CastleLevel":
                DataManager.Instance.CastleCounter += 1;
                break;
            case "LibraryLevel":
                DataManager.Instance.LibraryCounter += 1;
                break;
            case "CommunityCenterLevel":
                DataManager.Instance.CommunityCenterCounter += 1;
                break;
            case "SportCenterLevel":
                DataManager.Instance.SportCenterCounter += 1;
                break;
            case "MuseumLevel":
                DataManager.Instance.MuseumCounter += 1;
                break;
        }
    }
}
