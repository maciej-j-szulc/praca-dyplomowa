using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPSLocation : MonoBehaviour
{

    public float latitude;
    public float longitude;
    private Vector2 PlayerPosition;
    void Start()
    {
        StartCoroutine(StartGPSLocation());
    }

    private void Update()
    {
        longitude = Input.location.lastData.longitude * 1000;
        latitude = Input.location.lastData.latitude * 1000;
        PlayerPosition.y = latitude;
        PlayerPosition.x = longitude;
        transform.position = PlayerPosition;
    }

    IEnumerator StartGPSLocation()
    {
        if (!Input.location.isEnabledByUser)
        {
            yield break;
        }
        // Starts the location service.
        Input.location.Start();

        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        if (maxWait < 1)
        {
            yield break;
        }

        if (Input.location.status == LocationServiceStatus.Failed)
        {
            yield break;
        }
        else
        {
            latitude = Input.location.lastData.latitude;
            longitude = Input.location.lastData.longitude;
            latitude *= 1000f;
            longitude *= 1000f;
            yield break;
        }
    }


}
