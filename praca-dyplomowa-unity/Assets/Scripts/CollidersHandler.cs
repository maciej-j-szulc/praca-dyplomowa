using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidersHandler : MonoBehaviour
{
    public GameObject SportCenterLevelCollider;
    public GameObject ChurchLevelCollider;
    public GameObject BeachLevelCollider;
    public GameObject MuseumLevelCollider;
    public GameObject CommunityCenterLevelCollider;
    public GameObject LibraryLevelCollider;
    public GameObject CastleLevelCollider;
    public GameObject ShopLevelCollider;

    private void Awake()
    {
        if(DataManager.Instance.SportCenterLevelActivated == false)
            SportCenterLevelCollider.SetActive(false);
        
        if (DataManager.Instance.ShopLevelActivated == false)
        {
            ShopLevelCollider.SetActive(false);
        }
        if (DataManager.Instance.LibraryLevelActivated == false)
        {
            LibraryLevelCollider.SetActive(false);
        }
        if (DataManager.Instance.MuseumLevelActivated == false)
        {
            MuseumLevelCollider.SetActive(false);
        }
        if (DataManager.Instance.CommunityCenterLevelActivated == false)
        {
            CommunityCenterLevelCollider.SetActive(false);
        }
        if (DataManager.Instance.ChurchLevelActivated == false)
        {
            ChurchLevelCollider.SetActive(false);
        }
        if (DataManager.Instance.CastleLevelActivated == false)
        {
            CastleLevelCollider.SetActive(false);
        }
        if (DataManager.Instance.BeachLevelActivated == false)
        {
            BeachLevelCollider.SetActive(false);
        }
    }
}
