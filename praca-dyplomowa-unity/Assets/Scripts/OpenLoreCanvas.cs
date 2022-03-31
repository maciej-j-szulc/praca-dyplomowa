using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenLoreCanvas : MonoBehaviour
{

    public Button OpenLore;
    public GameObject LoreCanvas;

    void Start()
    {
        OpenLore.onClick.AddListener(OpenLCanvas);
    }

    void OpenLCanvas()
    {
        LoreCanvas.SetActive(true);
    }
}
