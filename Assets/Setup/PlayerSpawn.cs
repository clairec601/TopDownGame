using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public static PlayerSpawn instance { get; private set; }
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject ramen;
    [SerializeField] private GameObject ramenSpawnLocation;
    private static Vector3 playerPosition;
    public static bool ramenWasPlaced;
    void Awake()
    {
        instance = this;
        if (GameObject.FindGameObjectWithTag("Player")){
            player = GameObject.FindGameObjectWithTag("Player");
            player.transform.position = playerPosition;
        }
    }

    void Start() {
        if (QuestManager.instance.CheckState("Ramen").Equals(QuestState.FINISHED)){
            ramen.transform.position = ramenSpawnLocation.transform.position;
        }
    }

    void Update()
    {
        playerPosition = player.transform.position;
    }
    public void placeRamen(){
        if (GameObject.FindGameObjectWithTag("Ramen")){
            ramen.transform.position = ramenSpawnLocation.transform.position;
            ramenWasPlaced = true;
        }
    }
}
