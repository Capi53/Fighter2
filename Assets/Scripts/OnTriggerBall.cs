using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class OnTriggerBall : MonoBehaviour {
 
    void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("Player")){
            Debug.Log("aaaaaaaaa");
            Destroy(gameObject);
        }
    }
    private GameObject[] enemyObjects;

	void Update () {

		enemyObjects = GameObject.FindGameObjectsWithTag("Coin");
		if(enemyObjects.Length == 0){
			SceneManager.LoadScene("GameClear");
		}
	}
}