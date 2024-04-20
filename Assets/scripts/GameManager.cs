using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!");
        Player player = new("Teen");
        Debug.Log(player.Id);
        Debug.Log(player.Name);
        Debug.Log(player.Gauge);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
