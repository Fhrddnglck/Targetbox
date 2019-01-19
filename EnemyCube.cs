using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyCube : MonoBehaviour {
    // Use this for initialization
    public static int power;
    PlayerCube player;
    
    private void Awake()  //PUT RANDOM ENEMY POWER
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCube>();
        power = Random.Range(PlayerCube.score/2, PlayerCube.score*2);
        
        
    }
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
