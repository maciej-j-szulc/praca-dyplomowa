using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MapCollisions : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tag = gameObject.tag;
        if (collision.gameObject.tag.Equals("Player"))
        {
            switch (tag)
            {
                case "SC":
                    SceneManager.LoadScene("ShopLevel");
                    break;
                case "CHU":
                    SceneManager.LoadScene("ChurchLevel");
                    break;
                case "LIB":
                    SceneManager.LoadScene("LibraryLevel");
                    break;
                case "COM":
                    SceneManager.LoadScene("CommunityCenterLevel");
                    break;
                case "SPT":
                    SceneManager.LoadScene("SportCenterLevel");
                    break;
                case "BEA":
                    SceneManager.LoadScene("BeachLevel");
                    break;
                case "CAS":
                    SceneManager.LoadScene("CastleLevel");
                    break;
                case "MUS":
                    SceneManager.LoadScene("MuseumLevel");
                    break;
            }
        }
    }

}
