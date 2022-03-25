using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{

    public Button CloseLevel;
    
    void Start()
    {
        CloseLevel.onClick.AddListener(Close);
    }

    void Close()
    {
        SceneManager.LoadScene("Map");
    }
}
