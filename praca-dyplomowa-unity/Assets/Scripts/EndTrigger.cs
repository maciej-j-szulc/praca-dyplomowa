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
                if(AddAttempt == true)
                {
                    DataManager.Instance.BeachCounter += 1;
                    AddAttempt = false;
                }
                
                break;
            case "ShopLevel":
                DataManager.Instance.ShopLevelActivated = false;
                
                if (AddAttempt == true)
                {
                    DataManager.Instance.ShopCounter += 1;
                    AddAttempt = false;
                }
                break;
            case "ChurchLevel":
                DataManager.Instance.ChurchLevelActivated = false;
                if (AddAttempt == true)
                {
                    DataManager.Instance.ChurchCounter += 1;
                    AddAttempt = false;
                }
                
                break;
            case "CastleLevel":
                DataManager.Instance.CastleLevelActivated = false;
                
                if (AddAttempt == true)
                {
                    DataManager.Instance.CastleCounter += 1;
                    AddAttempt = false;
                }
                break;
            case "LibraryLevel":
                DataManager.Instance.LibraryLevelActivated = false;
                
                if (AddAttempt == true)
                {
                    DataManager.Instance.LibraryCounter += 1;
                    AddAttempt = false;
                }
                break;
            case "CommunityCenterLevel":
                DataManager.Instance.CommunityCenterLevelActivated = false;
                
                if (AddAttempt == true)
                {
                    DataManager.Instance.CommunityCenterCounter += 1;
                    AddAttempt = false;
                }
                break;
            case "SportCenterLevel":
                DataManager.Instance.SportCenterLevelActivated = false;
                
                if (AddAttempt == true)
                {
                    DataManager.Instance.SportCenterCounter += 1;
                    AddAttempt = false;
                }
                break;
            case "MuseumLevel":
                DataManager.Instance.MuseumLevelActivated = false;
                
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
