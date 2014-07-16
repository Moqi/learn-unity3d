#pragma strict

var cube1:GameObject;
var cube2:GameObject;
var center:Vector3;
var isSurrondCube1:boolean = true;
var surroundPoint:Vector3;
var s:float = 0;
var speed:float = 3.0;

function Start () {
	Debug.Log("Start ...");
	
	cube1 = GameObject.Find("Cube1");

	Debug.Log("Cube1 position ===> ");
	Debug.Log(cube1.transform.position);
	
	cube2 = GameObject.Find("Cube2");
	Debug.Log("Cube2 position ===> ");
	Debug.Log(cube2.transform.position);
	
	center = Vector3(
		(cube1.transform.position.x+cube2.transform.position.x)/2,
		(cube1.transform.position.y+cube2.transform.position.y)/2,
		(cube1.transform.position.z+cube2.transform.position.z)/2
	);
	Debug.Log("center position ===> ");
	Debug.Log(center);
	
	transform.position = center;
	
	surroundPoint = cube1.transform.position;
}


function changeSurroundPoint() {
	 isSurrondCube1 = !isSurrondCube1;
}

function getSurroundPoint() {
	if (isSurrondCube1) {
		return cube1.transform.position;
	} else {
		return cube2.transform.position;
	}
}

function getSurroundDirection() {
	if (isSurrondCube1) {
		return Vector3.up;
	} else {
		return Vector3.down;
	}
}

function Update () {
	if (s>360){
		changeSurroundPoint();
		s=0;
	}
	transform.RotateAround(getSurroundPoint(), getSurroundDirection(), speed);
	s += speed;
}
