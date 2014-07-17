using UnityEngine;
using System.Collections;

public class ScriptableObjectTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Hero hero = ScriptableObject.CreateInstance<Hero> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
