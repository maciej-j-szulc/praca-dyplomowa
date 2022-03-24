using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    bool AddAttempt = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.CompleteLevel();
        Destroy(gameObject);

        FindObjectOfType<AudioManager>().Play("PlayerWinning");
        FindObjectOfType<AudioManager>().Stop("MainTheme");

        
        ChangeLevelFlag(SceneManager.GetActiveScene().name);
        
        
    }

    void ChangeLevelFlag(string name)
    {
        switch(name)
        {
            case "BeachLevel":
                DataManager.Instance.BeachLevelActivated = false;
                DataManager.Instance.BeachScore = Score.scoreValue;
                
                if(AddAttempt == true)
                {
                    DataManager.Instance.BeachCounter += 1;
                    AddAttempt = false;
                }
                
                break;
            case "ShopLevel":
                DataManager.Instance.ShopLevelActivated = false;
                DataManager.Instance.ShopScore = Score.scoreValue;
                if (AddAttempt == true)
                {
                    DataManager.Instance.ShopCounter += 1;
                    AddAttempt = false;
                }
                break;
            case "ChurchLevel":
                DataManager.Instance.ChurchLevelActivated = false;
                DataManager.Instance.ChurchScore = Score.scoreValue;
                if (AddAttempt == true)
                {
                    DataManager.Instance.ChurchCounter += 1;
                    AddAttempt = false;
                }
                
                break;
            case "CastleLevel":
                DataManager.Instance.CastleLevelActivated = false;
                DataManager.Instance.CastleScore = Score.scoreValue;
                if (AddAttempt == true)
                {
                    DataManager.Instance.CastleCounter += 1;
                    AddAttempt = false;
                }
                break;
            case "LibraryLevel":
                DataManager.Instance.LibraryLevelActivated = false;
                DataManager.Instance.LibraryScore = Score.scoreValue;
                if (AddAttempt == true)
                {
                    DataManager.Instance.LibraryCounter += 1;
                    AddAttempt = false;
                }
                break;
            case "CommunityCenterLevel":
                DataManager.Instance.CommunityCenterLevelActivated = false;
                DataManager.Instance.CommunityCenterScore = Score.scoreValue;
                if (AddAttempt == true)
                {
                    DataManager.Instance.CommunityCenterCounter += 1;
                    AddAttempt = false;
                }
                break;
            case "SportCenterLevel":
                DataManager.Instance.SportCenterLevelActivated = false;
                DataManager.Instance.SportCenterScore = Score.scoreValue;
                if (AddAttempt == true)
                {
                    DataManager.Instance.SportCenterCounter += 1;
                    AddAttempt = false;
                }
                break;
            case "MuseumLevel":
                DataManager.Instance.MuseumLevelActivated = false;
                DataManager.Instance.MuseumScore = Score.scoreValue;
                if (AddAttempt == true)
                {
                    DataManager.Instance.MuseumCounter += 1;
                    AddAttempt = false;
                }
                break;
        }
        SaveSystem.SaveGame(DataManager.Instance);
        
    }
}
