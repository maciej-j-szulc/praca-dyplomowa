using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollidersHandler : MonoBehaviour
{
    public GameObject BeachLevelCollider;
    public GameObject CastleLevelCollider;
    public GameObject ChurchLevelCollider;
    public GameObject CommunityCenterLevelCollider;
    public GameObject SportCenterLevelCollider;
    public GameObject ShopLevelCollider;
    public GameObject MuseumLevelCollider;
    public GameObject LibraryLevelCollider;


    public GameObject BeachColor;
    public GameObject CastleColor;
    public GameObject ChurchColor;
    public GameObject CommunityCenterColor;
    public GameObject SportCenterColor;
    public GameObject ShopColor;
    public GameObject MuseumColor;
    public GameObject LibraryColor;


    public Text BeachText;
    public Text CastleText;
    public Text ChurchText;
    public Text CommunityCenterText;
    public Text SportCenterText;
    public Text ShopText;
    public Text MuseumText;
    public Text LibraryText;

    public Text BeachScore;
    public Text CastleScore;
    public Text ChurchScore;
    public Text CommunityCenterScore;
    public Text SportScore;
    public Text ShopScore;
    public Text MuseumScore;
    public Text LibraryScore;

    private void Awake()
    {
        BeachText.text = "Ilość podejść: " + DataManager.Instance.BeachCounter.ToString();
        SportCenterText.text = "Ilość podejść: " + DataManager.Instance.SportCenterCounter.ToString();
        ShopText.text = "Ilość podejść: " + DataManager.Instance.ShopCounter.ToString();
        LibraryText.text = "Ilość podejść: " + DataManager.Instance.LibraryCounter.ToString();
        MuseumText.text = "Ilość podejść: " + DataManager.Instance.MuseumCounter.ToString();
        CommunityCenterText.text = "Ilość podejść: " + DataManager.Instance.CommunityCenterCounter.ToString();
        ChurchText.text = "Ilość podejść: " + DataManager.Instance.ChurchCounter.ToString();
        CastleText.text = "Ilość podejść: " + DataManager.Instance.CastleCounter.ToString();
        if (DataManager.Instance.SportCenterLevelActivated == false)
        {
            SportCenterLevelCollider.SetActive(false);
            SportCenterColor.GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
            
            SportScore.text =DataManager.Instance.SportCenterScore.ToString();
        }
        
        if (DataManager.Instance.ShopLevelActivated == false)
        {
            ShopLevelCollider.SetActive(false);
            ShopColor.GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
            
            ShopScore.text =DataManager.Instance.ShopScore.ToString();
        }
        if (DataManager.Instance.LibraryLevelActivated == false)
        {
            LibraryLevelCollider.SetActive(false);
            LibraryColor.GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
            
            LibraryScore.text = DataManager.Instance.LibraryScore.ToString();
        }
        if (DataManager.Instance.MuseumLevelActivated == false)
        {
            MuseumLevelCollider.SetActive(false);
            MuseumColor.GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
            
            MuseumScore.text =DataManager.Instance.MuseumScore.ToString();
        }
        if (DataManager.Instance.CommunityCenterLevelActivated == false)
        {
            CommunityCenterLevelCollider.SetActive(false);
            CommunityCenterColor.GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
            
            CommunityCenterScore.text = DataManager.Instance.CommunityCenterScore.ToString();
        }
        if (DataManager.Instance.ChurchLevelActivated == false)
        {
            ChurchLevelCollider.SetActive(false);
            ChurchColor.GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
            
            ChurchScore.text = DataManager.Instance.ChurchScore.ToString();
        }
        if (DataManager.Instance.CastleLevelActivated == false)
        {
            CastleLevelCollider.SetActive(false);
            CastleColor.GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
            
            CastleScore.text = DataManager.Instance.CastleScore.ToString();
        }
        if (DataManager.Instance.BeachLevelActivated == false)
        {
            BeachLevelCollider.SetActive(false);
            BeachColor.GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
            
            BeachScore.text = DataManager.Instance.BeachScore.ToString();
        }
    }
}
