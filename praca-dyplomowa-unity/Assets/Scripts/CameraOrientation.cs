using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraOrientation : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Screen.orientation = ScreenOrientation.Landscape;
    }
}
