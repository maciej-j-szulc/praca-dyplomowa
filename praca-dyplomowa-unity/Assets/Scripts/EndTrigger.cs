using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
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
                break;
            case "ShopLevel":
                DataManager.Instance.ShopLevelActivated = false;
                break;
            case "ChurchLevel":
                DataManager.Instance.ChurchLevelActivated = false;
                break;
            case "CastleLevel":
                DataManager.Instance.CastleLevelActivated = false;
                break;
            case "LibraryLevel":
                DataManager.Instance.LibraryLevelActivated = false;
                break;
            case "CommunityCenterLevel":
                DataManager.Instance.CommunityCenterLevelActivated = false;
                break;
            case "SportCenterLevel":
                DataManager.Instance.SportCenterLevelActivated = false;
                break;
            case "MuseumLevel":
                DataManager.Instance.MuseumLevelActivated = false;
                break;
        }
    }
}
