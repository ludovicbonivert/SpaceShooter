using UnityEngine;
using System.Collections;

public class Coroutine : MonoBehaviour {

	void Start(){
		StartCoroutine(exampleCorout());
	}

	IEnumerator exampleCorout(){
		yield return new WaitForSeconds(2);
		Debug.Log("Hello");
		yield return new WaitForSeconds(2);
		Debug.Log("Hello");
	}
}
