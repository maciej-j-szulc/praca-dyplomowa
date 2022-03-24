using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour
{
    void Awake()
    {
        GameData data = SaveSystem.LoadGame();
        DataManager.Instance.BeachLevelActivated = data.BeachLevelActivated;
        DataManager.Instance.CastleLevelActivated = data.CastleLevelActivated;
        DataManager.Instance.CommunityCenterLevelActivated = data.CommunityCenterLevelActivated;
        DataManager.Instance.ChurchLevelActivated = data.ChurchLevelActivated;
        DataManager.Instance.LibraryLevelActivated = data.LibraryLevelActivated;
        DataManager.Instance.MuseumLevelActivated = data.MuseumLevelActivated;
        DataManager.Instance.ShopLevelActivated = data.ShopLevelActivated;
        DataManager.Instance.SportCenterLevelActivated = data.SportCenterLevelActivated;

        DataManager.Instance.BeachCounter = data.BeachCounter;
        DataManager.Instance.CastleCounter = data.CastleCounter;
        DataManager.Instance.CommunityCenterCounter = data.CommunityCenterCounter;
        DataManager.Instance.ChurchCounter = data.ChurchCounter;
        DataManager.Instance.LibraryCounter = data.LibraryCounter;
        DataManager.Instance.MuseumCounter = data.MuseumCounter;
        DataManager.Instance.ShopCounter = data.ShopCounter;
        DataManager.Instance.SportCenterCounter = data.SportCenterCounter;

        DataManager.Instance.BeachScore = data.BeachScore;
        DataManager.Instance.CastleScore = data.CastleScore;
        DataManager.Instance.CommunityCenterScore = data.CommunityCenterScore;
        DataManager.Instance.ChurchScore = data.ChurchScore;
        DataManager.Instance.LibraryScore = data.LibraryScore;
        DataManager.Instance.MuseumScore = data.MuseumScore;
        DataManager.Instance.ShopScore = data.ShopScore;
        DataManager.Instance.SportCenterScore = data.SportCenterScore;
    }
}
