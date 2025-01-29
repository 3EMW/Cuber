using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    private GameObject playerGO;
    private PlayerController player;
    private bool hasObstacleUsed;
    void Start()
    {
        playerGO = GameObject.FindGameObjectWithTag("Player");
        player = playerGO.GetComponent<PlayerController>();
    }

 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && hasObstacleUsed == false)
        {
            player.TouchedToObstacle();
        }
    }
}
