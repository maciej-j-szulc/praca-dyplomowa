using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public bool SportCenterLevelActivated = true;
    public bool BeachLevelActivated = true;
    public bool CastleLevelActivated = true;
    public bool CommunityCenterLevelActivated = true;
    public bool MuseumLevelActivated = true;
    public bool LibraryLevelActivated = true;
    public bool ChurchLevelActivated = true;
    public bool ShopLevelActivated = true;

    public int SportCenterCounter = 0;
    public int BeachCounter = 0;
    public int CastleCounter = 0;
    public int CommunityCenterCounter = 0;
    public int MuseumCounter = 0;
    public int LibraryCounter = 0;
    public int ChurchCounter = 0;
    public int ShopCounter = 0;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
