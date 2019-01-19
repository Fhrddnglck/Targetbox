using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPanel : MonoBehaviour {
    
    public GameObject startPanelUI;
    public GameObject enemy;
    private void Awake()
    {
        enemy.SetActive(false);
        DontDestroyOnLoad(this.gameObject);
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1) Destroy(objs[0]);
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount>0)
        {
            Touch touch = Input.touches[0];
            startPanelUI.SetActive(false);
            enemy.SetActive(true);
            
        }
	}
}
