#pragma strict

class Pool {
	var container = new Array();
	
	function init(_cnt:int) {
		for (var i = 0; i < _cnt; i++) {
			var obj = new GameObject();
			container.Push(obj);
		}
	}
	
	function request() {
		var obj = container.Pop();
		return obj;
	}
	
	function returnObj(obj:GameObject) {
		container.Push(obj);
	}
}

function Start () {
	var pool = new Pool();
	pool.init(3);
	var obj = pool.request();
	pool.returnObj(obj);
}

function Update () {

}