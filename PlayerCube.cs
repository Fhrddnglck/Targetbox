using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerCube : MonoBehaviour {
    [SerializeField] Text scoreText;
    [SerializeField] Text enemyText;
    public static int score=5;
    public static PlayerCube instance;
    Rigidbody rigidbody;

 
    private float jumpForce = 90;
    private bool onGround = true;
    public GameObject adsPanel;
    public GameObject music;
    public GameObject enemy;
    // Use this for initialization
    void Start () {
        
        scoreText.text = score.ToString();
        rigidbody = GetComponent<Rigidbody>();
     
    }
	void Update () {
        enemyText.text = EnemyCube.power.ToString();
        
        
	}
    private void Awake()
    {
        score = 5;
       
    }
    private void OnTriggerEnter(Collider other)
    {
        onGround = true;
        
        if (EnemyCube.power<=score && other.tag!="Ground")
        {

            score += EnemyCube.power;
            scoreText.text = score.ToString();
        }
        else if(EnemyCube.power > score && other.tag!="Ground")
        {
            adsPanel.SetActive(true);
            enemy.SetActive(false);
            
        }

    }
    public void GameOver()
    {
        DontDestroyOnLoad(music);
        
        SceneManager.LoadScene("over");
    }

    private void FixedUpdate()
    {

        if (Input.touchCount > 0 && onGround)
        {

           rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            onGround = false;

        }
    }
}
