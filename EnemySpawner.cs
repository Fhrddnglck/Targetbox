using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    public GameObject enemy;
    public float speed;
    public float second = 4f;
	// Use this for initialization
	void Start () {
        StartCoroutine(spawn());
    }
	        

    IEnumerator spawn()    //ENEMY SPAWN CODE
    {
        while(true)
        {
            GameObject en = Instantiate(enemy, transform.position, Quaternion.identity) as GameObject;
            en.GetComponent<Rigidbody>().velocity = new Vector3(-speed * Time.deltaTime, 0, 0);
            speed += 45;
            if(second<1f)
            {
                yield return new WaitForSeconds(second);
            }else
            {
                yield return new WaitForSeconds(second);
                second -= 0.1f;
            }
           
            
            Destroy(en.gameObject);
        } 
    }
}
