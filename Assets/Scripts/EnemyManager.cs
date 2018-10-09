using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    public PlayerController playerController;       // Reference to the player's heatlh.
    public GameObject enemy;                // The enemy prefab to be spawned.
    public float spawnTime = 0.2f;            // How long between each spawn.
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
    public int totalSpawn = 0;
    public Text text;
    public 


    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    void Spawn()
    {
     //Find a random index between zero and one less than the number of spawn points.
     int spawnPointIndex = Random.Range(0, spawnPoints.Length);

     //Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
     Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

    totalSpawn++;
    text.text = totalSpawn.ToString() + " metalheads are out to kill you";
    }
}