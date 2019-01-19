using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManag : MonoBehaviour {
    public GameObject AdsPanel;
    public GameObject rewardPanel;
    public GameObject enemy;
    // Use this for initialization
    private void Awake()
    {
        AdsPanel.SetActive(false);
        rewardPanel.SetActive(false);
        
    }
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ReceiveReward()
    {
        AdsPanel.SetActive(false);
        rewardPanel.SetActive(false);
        enemy.SetActive(true);
    }
}
