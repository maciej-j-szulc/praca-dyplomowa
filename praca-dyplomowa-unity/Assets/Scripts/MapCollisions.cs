using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MapCollisions : MonoBehaviour
{
    public Text LevelName;
    public GameObject CurrentLevelBoard;
    public Button StartLevel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tag = gameObject.tag;
        if (collision.gameObject.tag.Equals("Player"))
        {
            switch (tag)
            {
                case "SC":
                    LevelName.text = "Sklep";
                    CurrentLevelBoard.SetActive(true);
                    StartLevel.onClick.AddListener(delegate { StartNewLevel("ShopLevel"); });
                    break;
                case "CHU":
                    LevelName.text = "Kościół";
                    CurrentLevelBoard.SetActive(true);
                    StartLevel.onClick.AddListener(delegate { StartNewLevel("ChurchLevel"); });
                    break;
                case "LIB":
                    LevelName.text = "Biblioteka";
                    CurrentLevelBoard.SetActive(true);
                    StartLevel.onClick.AddListener(delegate { StartNewLevel("LibraryLevel"); });
                    break;
                case "COM":
                    LevelName.text = "Miejski Dom Kultury";
                    CurrentLevelBoard.SetActive(true);
                    StartLevel.onClick.AddListener(delegate { StartNewLevel("CommunityCenterLevel"); });
                    break;
                case "SPT":
                    LevelName.text = "Centrum Sportu";
                    CurrentLevelBoard.SetActive(true);
                    StartLevel.onClick.AddListener(delegate { StartNewLevel("SportLevel"); });
                    break;
                case "BEA":
                    LevelName.text = "Plaża Miejska";
                    CurrentLevelBoard.SetActive(true);
                    StartLevel.onClick.AddListener(delegate { StartNewLevel("BeachLevel"); });
                    break;
                case "CAS":
                    LevelName.text = "Ruiny Zamku";
                    CurrentLevelBoard.SetActive(true);
                    StartLevel.onClick.AddListener(delegate { StartNewLevel("CastleLevel"); });
                    break;
                case "MUS":
                    LevelName.text = "Muzeum";
                    CurrentLevelBoard.SetActive(true);
                    StartLevel.onClick.AddListener(delegate { StartNewLevel("MuzeumLevel"); });
                    break;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        CurrentLevelBoard.SetActive(false);
    }

    void StartNewLevel(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }

}
