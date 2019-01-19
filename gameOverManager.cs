using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class gameOverManager : MonoBehaviour {
    
    
    //SON KALINAN YER : EN YÜKSEK SKORU SAVE YAPMAK
    private void Awake()
    {
        Ads.instance.RequestFullScreenAd();
    }
    void Start () {

	}
	void Update () {
        
	}
    public void SoundOff()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().volume = 0;
    }
    public void SoundOn()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().volume = 1;
    }
    public void Replay()
    {
        
        Ads.instance.ShowFullScreenAd();
        EnemyCube.power = 0;
        SceneManager.LoadScene(0);
    }
}
