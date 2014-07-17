using UnityEngine;
using System.Collections;

public class Hero : ScriptableObject {

	public int attack = 20;
	public int magic = 30;
	public int maxHP = 100;
	public int maxMp = 100;
	public Texture2D icon = (Texture2D)Resources.Load ("avatar");

}

public class ScriptableObjectTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Hero hero = ScriptableObject.CreateInstance<Hero> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
