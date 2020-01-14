using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerSpawnController : MonoBehaviour
{
    GameObject Player;
    public GameObject PlayerPrefab;

    public GameObject SpawnLocation;

    void Awake()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            //player already exists, so just move it to the spawn location and set the Player gameobject parameter
            Debug.Log("Player from MenuScene destroyen");
            Player = GameObject.FindGameObjectWithTag("Player");
            Player.transform.position = SpawnLocation.transform.position;

        }
        else
        {
            Debug.Log("no player from menu exist");
            Player = Instantiate(PlayerPrefab);
            Player.transform.position = SpawnLocation.transform.position;

        }
    }
}