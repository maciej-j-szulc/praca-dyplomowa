using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData {

    public bool BeachLevelActivated;
    public bool CastleLevelActivated;
    public bool CommunityCenterLevelActivated;
    public bool ChurchLevelActivated;
    public bool LibraryLevelActivated;
    public bool MuseumLevelActivated;
    public bool ShopLevelActivated;
    public bool SportCenterLevelActivated;

    public int BeachCounter;
    public int CastleCounter;
    public int CommunityCenterCounter;
    public int ChurchCounter;
    public int LibraryCounter;
    public int MuseumCounter;
    public int ShopCounter;
    public int SportCenterCounter;


    public GameData(DataManager data)
    {
        BeachLevelActivated = data.BeachLevelActivated;
        CastleLevelActivated = data.CastleLevelActivated;
        CommunityCenterLevelActivated = data.CommunityCenterLevelActivated;
        ChurchLevelActivated = data.ChurchLevelActivated;
        LibraryLevelActivated = data.LibraryLevelActivated;
        MuseumLevelActivated = data.MuseumLevelActivated;
        ShopLevelActivated = data.ShopLevelActivated;
        SportCenterLevelActivated = data.SportCenterLevelActivated;

        BeachCounter = data.BeachCounter;
        CastleCounter = data.CastleCounter;
        CommunityCenterCounter = data.CommunityCenterCounter;
        ChurchCounter = data.ChurchCounter;
        LibraryCounter = data.LibraryCounter;
        MuseumCounter = data.MuseumCounter;
        ShopCounter = data.ShopCounter;
        SportCenterCounter = data.SportCenterCounter;
    }
}
