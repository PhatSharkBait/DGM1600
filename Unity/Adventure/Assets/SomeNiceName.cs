using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SomeNiceName : MonoBehaviour {

	public Text textObject;

	public enum States {
	start, tree, punchDeath, getWood, crab, raft, axe, fire, brokenRaft, fixedRaft, repair
	};
	public States myState;

	public bool axe = false;
	public bool wood = false;
	public bool crab = false;
	public bool brokeRaft = false;
	public bool fixRaft = false;

	// Use this for initialization
	void Start () {
		myState = States.start;
	}
	
	// Update is called once per frame
	void Update () {
		if (myState == States.start) {
			State_start ();
		} else if (myState == States.axe) {
			State_axe ();		
		} else if (myState == States.tree) {
			State_tree ();
		} else if (myState == States.punchDeath) {
			State_punchDeath ();
		} else if (myState == States.getWood) {
			State_getWood ();
		} else if (myState == States.crab) {
			State_crab ();
		} else if (myState == States.raft) {
			State_raft ();
		} else if (myState == States.fire) {
			State_fire ();
		} else if (myState == States.fixedRaft) {
			State_fixedRaft ();
		} else if (myState == States.fire) {
			State_fire ();
		} else if (myState == States.repair) {
			State_repair ();
		}

	}

	void State_start(){
		if (axe == false && wood == false && crab == false && brokeRaft == false) {
			textObject.text = "You are on a small desert island " +
			"\n There is a tall Tree." +
			"\n There is a Crab walking along the shore" +
			"\n There is a small, broken Raft" +
			"\n There is a rusty Axe" +
			"\n There is a Firepit" +
			"\n\n Press A to grab the Axe" +
			"\n Press T to approach the Tree" +
			"\n Press C to approach the Crab" +
			"\n Press R to approach the Raft" +
			"\n Press F to approach the Firepit";
		} else if (axe == true && wood == false && crab == false && brokeRaft == false) {
			textObject.text =
			"There is a tall Tree." +
			"\n There is a Crab walking along the shore" +
			"\n There is a small, broken Raft" +
			"\n There is a Firepit" +
			"\n\n Press T to approach the Tree" +
			"\n Press C to approach the Crab" +
			"\n Press R to approach the Raft" +
			"\n Press F to approach the Firepit";
		} else if (axe == true && wood == true && crab == false && brokeRaft == false) {
			textObject.text =
			"\n There is a Crab walking along the shore" +
			"\n There is a small, broken Raft" +
			"\n There is a Firepit" +
			"\n Press C to approach the Crab" +
			"\n Press R to approach the Raft" +
			"\n Press F to approach the Firepit";
		} else if (axe == true && wood == true && crab == true && brokeRaft == false) {
			textObject.text = 
			"\n There is a small, broken Raft" +
			"\n There is a rusty Axe" +
			"\n There is a Firepit" +
			"\n\n Press R to approach the Raft" +
			"\n Press F to approach the Firepit";
		} else if (axe == true && wood == true && crab == true && brokeRaft == true) {
			textObject.text =
				"\n There is a Firepit" +
				"\n\n Press F to approach the Firepit";
		} else if (axe == true && wood == true && crab == false && brokeRaft == true) {
			textObject.text =
				"\n There is a Crab walking along the shore" +
				"\n There is a Firepit" +
				"\n\n Press C to approach the Crab" +
				"\n Press F to approach the Firepit";
		} else if (axe == true && wood == false && crab == true && brokeRaft == false) {
			textObject.text =
				"\n There is a tall Tree." +
				"\n There is a small, broken Raft" +
				"\n There is a Firepit" +
				"\n\n Press T to approach the Tree" +
				"\n Press R to approach the Raft" +
				"\n Press F to approach the Firepit";
		} else if (axe == true && wood == false && crab == true && brokeRaft == true) {
			textObject.text =
				"\n There is a tall Tree." +
				"\n There is a Firepit" +
				"\n\n Press T to approach the Tree" +
				"\n Press F to approach the Firepit";
		} else if (axe == true && wood == false && crab == false && brokeRaft == true) {
			textObject.text =
				"\n There is a tall Tree." +
				"\n There is a Crab walking along the shore" +
				"\n There is a small, broken Raft" +
				"\n There is a Firepit" +
				"\n\n Press A to grab the Axe" +
				"\n Press T to approach the Tree" +
				"\n Press C to approach the Crab" +
				"\n Press F to approach the Firepit";
		}

		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.axe;
		}
		else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.tree;
		}
		else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.crab;
		}
		else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.raft;
		}
		else if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.fire;
		}
	}

	void State_axe(){
		axe = true;
		textObject.text = "You have obtained the Axe" +
			"\nPress S to return to Start";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.start;
		}
	}

	void State_tree(){
		if (axe == true) {
			textObject.text = "You approach a tall, thin tree." +
							  "\nPress A to Attack the Tree with the Axe" +
							  "\nPress P to Punch the Tree" +
							  "\nPress S to return to Start";

			if (Input.GetKeyDown (KeyCode.P)) {
				myState = States.punchDeath;
			}
			else if (Input.GetKeyDown (KeyCode.S)) {
				myState = States.start;
			}
			else if (Input.GetKeyDown (KeyCode.A)) {
				myState = States.getWood;
			}
		}
		if (axe == false) {
			textObject.text ="You approach a tall, thin tree." +
							 "\nPress P to Punch the Tree" +
							 "\nPress S to return to Start";
			if (Input.GetKeyDown (KeyCode.P)) {
				myState = States.punchDeath;
			}
			else if (Input.GetKeyDown (KeyCode.S)) {
				myState = States.start;
			}
		}
	}
	void State_punchDeath(){
		textObject.text = "You attempt to Punch the Tree." +
			"\n\nYou break your hand." +
			"\nYou stare at your shattered hand." +
			"\nYou start feeling dizzy." +
			"\nYou faint and your head hits a rock." +
			"\n\nYOU HAVE DIED";
	}
	void State_getWood(){
		wood = true;
		textObject.text = "You have obtained wood." +
			"\n\nPress S to return to Start";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.start;
		}
	}
	void State_raft(){
		if (fixRaft == false && wood == false && axe == false) {
			textObject.text = "You approach a wooden raft." +
			"\nThere are various holes in the raft" +
			"\nThe sail seems unharmed" +
			"\n\nPress R to ride the Raft" +
			"\nPress S to return to Start";
		} else if (fixRaft == false && wood == true) {
			textObject.text = "You approach a wooden raft." +
			"\nThere are various holes in the raft" +
			"\nThe sail seems unharmed" +
			"\n\nPress R to ride the Raft" +
			"\nPress S to return to Start" +
			"\nPress A to break down the raft with the Axe" +
			"\nPress W to repair the Raft with Wood";
		} else if (fixRaft == false && wood == false && axe == true) {
			textObject.text = "You approach a wooden raft." +
			"\nThere are various holes in the raft" +
			"\nThe sail seems unharmed" +
			"\n\nPress R to ride the Raft" +
			"\nPress S to return to Start" +
			"\nPress A to break down the raft with the Axe";
		} else if (fixRaft == true && wood == true && axe == true) {
			textObject.text = "You have repaired the Raft" +
				"\n\nPress R to ride the Raft" +
				"\nPress S to return to Start" +
				"\nPress A to break down the raft with the Axe";
		}
		if (Input.GetKeyDown (KeyCode.R) && fixRaft == false) {
			myState = States.brokenRaft;
		} else if (Input.GetKeyDown (KeyCode.R) && fixRaft == true) {
			myState = States.fixedRaft;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.start;
		} else if (Input.GetKeyDown (KeyCode.W)){
			myState = States.repair;
		}
	}
	void State_crab(){

	}
	void State_fire(){
	
	}
	void State_brokenRaft(){
		textObject.text = "You Push the raft into the water and step on board." +
			"\nit feels very unstable under your feet" +
			"\nYou make it off shore and travel 30 yards" +
			"\nYou look down as the water reaches your knees, the Raft was sinking" +
			"\nYou wish you took swimming lessons as a child" +
			"\n\nYOU HAVE DIED";
	}
	void State_fixedRaft(){
		textObject.text = "You Push the raft into the water and step on board." +
			"\nThe raft feels stable" +
			"\nYou travel for an hour and decide to get some rest" +
			"\nYou drift to sleep" +
			"\nYou wake to the sound of thunder accompanied by a bright flash" +
			"\nYou look up at your sail and see another flash" +
			"\n\nYOU HAVE DIED";
	}
	void State_repair(){
		fixRaft = true;
		textObject.text = "You have repaired the raft" +
		"\n\nPress Enter to continue.";

		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.raft;
		}
	}
}
