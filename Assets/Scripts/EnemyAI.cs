using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyAI : MonoBehaviour
{

    private GameObject player;
    public int MoveSpeed = 30;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        transform.LookAt(player.transform);
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;
    }
}