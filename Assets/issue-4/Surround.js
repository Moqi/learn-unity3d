#pragma strict

function Start () {
	Debug.Log("Start ...");
}

function Update () {
	var x = Mathf.Sin(Time.time*2)*5;
	var z = Mathf.Sin(Time.time)*20;
    transform.position.x = x;
    transform.position.z = z;
    Debug.Log(transform.position);
}
