#pragma strict

var level: int;

function OnTriggerEnter(other: Collider){
	if(other.gameObject.tag == "Ball"){
		Application.LoadLevel(level);
	}
}