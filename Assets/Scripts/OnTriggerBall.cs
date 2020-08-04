using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class OnTriggerBall : MonoBehaviour {
 
    void OnTriggerEnter(Collider collider)
    {
		Debug.Log("yeah");
		Debug.Log(collider.gameObject);
	    if(collider.gameObject.CompareTag("Coin")){
	        Destroy(collider.gameObject);
	    }
	    GameObject[] coinObjects;
	    coinObjects = GameObject.FindGameObjectsWithTag("Coin");
		if(coinObjects.Length -1 == 0){
			SceneManager.LoadScene("GameClear");
		}
    }
}