using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SomeNiceName : MonoBehaviour {
    public Scene Level01;
	public Text textObject;

	public enum States {
	start, tree, punchDeath, getWood, crab, raft, axe, fire, brokenRaft, fixedRaft, repair, destroyRaft, killCrab, crabDeath, startFire, bonfire, starve, areYouSure, dinner, missFlight, win, restartCurrentScene
	};
	public States myState;

	public bool axe = false;
	public bool wood = false;
	public bool crab = false;
	public bool brokeRaft = false;
	public bool fixRaft = false;
	public bool dinner = false;
	public bool bonfire = false;

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
		} else if (myState == States.destroyRaft){
			State_destroyRaft ();
		} else if (myState == States.crabDeath){
			State_crabDeath ();
		} else if (myState == States.killCrab){
			State_killCrab ();
		} else if (myState == States.startFire){
			State_startFire ();
		} else if (myState == States.bonfire){
			State_bonfire ();
		} else if (myState == States.starve){
			State_starve ();
		} else if (myState == States.areYouSure){
			State_areYouSure ();
		} else if (myState == States.dinner){
			State_dinner ();
		} else if (myState == States.missFlight){
			State_missFlight ();
		} else if (myState == States.win){
			State_win ();
		} else if (myState == States.win){
			State_win ();
        }
        else if (myState == States.brokenRaft)
        {
            State_brokenRaft();
        }
        else if (myState == States.fixedRaft)
        {
            State_fixedRaft();
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
			"\n\n Press C to approach the Crab" +
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
				"\n" +
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
			"\n\nYOU HAVE DIED" + "\n\nPress Enter to Restart Game";
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
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
            if (Input.GetKeyDown(KeyCode.R))
            {
                myState = States.brokenRaft;
            }
        } else if (fixRaft == false && wood == true) {
			textObject.text = "You approach a wooden raft." +
			"\nThere are various holes in the raft" +
			"\nThe sail seems unharmed" +
			"\n\nPress R to ride the Raft" +
			"\nPress S to return to Start" +
			"\nPress A to break down the raft with the Axe" +
			"\nPress W to repair the Raft with Wood";
            if (Input.GetKeyDown(KeyCode.R))
            {
                myState = States.brokenRaft;
            }
        } else if (fixRaft == false && wood == false && axe == true) {
			textObject.text = "You approach a wooden raft." +
			"\nThere are various holes in the raft" +
			"\nThe sail seems unharmed" +
			"\n\nPress R to ride the Raft" +
			"\nPress S to return to Start" +
			"\nPress A to break down the raft with the Axe";
            if (Input.GetKeyDown(KeyCode.R))
            {
                myState = States.brokenRaft;
            }
        } else if (fixRaft == true && wood == true && axe == true) {
			textObject.text = "You have repaired the Raft" +
				"\n\nPress R to ride the Raft" +
				"\nPress S to return to Start" +
				"\nPress A to break down the raft with the Axe";
                if (Input.GetKeyDown(KeyCode.R))
            {
                myState = States.fixedRaft;
            }
        }
          if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.start;
		} else if (Input.GetKeyDown (KeyCode.W)){
			myState = States.repair;
		} else if (Input.GetKeyDown (KeyCode.A)){
			myState = States.destroyRaft;
		}
	}
	void State_crab(){
		if (axe == true) {
			textObject.text = "You approach a large crab" +
			"\nIt walks toward you hatefully." +
			"\n\nPress A to Attack with the Axe" +
			"\nPress P to Punch the Crab" +
			"\nPress S to Return to Start";
		} else if (axe == false) {
			textObject.text = "You approach a large crab" +
				"\nIt walks toward you hatefully." +
				"\n" +
				"\nPress P to Punch the Crab" +
				"\nPress S to Return to Start";
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.killCrab;
		} else if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.crabDeath;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.start;
		}
	}
	void State_brokenRaft(){
		textObject.text = "You Push the raft into the water and step on board." +
			"\nit feels very unstable under your feet" +
			"\nYou make it off shore and travel 30 yards" +
			"\nYou look down as the water reaches your knees, the Raft was sinking" +
			"\nYou wish you took swimming lessons as a child" +
			"\n\nYOU HAVE DIED" + "\n\nPress Enter to Restart Game";
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
	void State_fixedRaft(){
		textObject.text = "You Push the raft into the water and step on board." +
			"\nThe raft feels stable" +
			"\nYou travel for an hour and decide to get some rest" +
			"\nYou drift to sleep" +
			"\nYou wake to the sound of thunder accompanied by a bright flash" +
			"\nYou look up at your sail and see another flash" +
			"\n\nYOU HAVE DIED" + "\n\nPress Enter to Restart Game";
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
	void State_repair(){
		fixRaft = true;
		textObject.text = "You have repaired the raft" +
		"\n\nPress Enter to continue.";

		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.raft;
		}
	}
	void State_destroyRaft (){
		brokeRaft = true;
		textObject.text = "You have collected wood from the raft" +
			"\n\nPress S to return to start";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.start;
		}
			
	}
	void State_crabDeath(){
		textObject.text = "You throw your fist at the crab" +
			"\nYou feel the hit connect and as you pull your arm back you look at your hand" +
			"\nIt's on the ground next to the crab" +
			"\nYou pass out before you can stop the bleeding" +
			"\n\nYOU HAVE DIED" + "\n\nPress Enter to Restart Game";
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
	void State_killCrab(){
		crab = true;
		textObject.text = "You bring your axe down on the crab and slice off a claw" +
			"\nYou hammer at his shell with the axe until blood spills out" +
			"\nYou have Collected Crab" +
			"\n\nPress S to return to start";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.start;
		}
	}
	void State_fire(){
		if (wood == false) {
			textObject.text = "You approach the Firepit" +
			"\n\nPress S to return to Start";
		} else if (wood == true) {
			textObject.text = "You approach the Firepit" +
			"\n\nPress S to return to Start" +
			"\nPress W to start fire with Wood";
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.start;
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			myState = States.areYouSure;
		}
	}
	void State_starve(){
		textObject.text = "You hear helicopter blades whirring" +
		"\nYou jump up and down flailing your arms" +
		"\nYou are grateful for your giant signal fire" +
		"\nHelicopter heads toward your island and lands near you" +
		"\nYou almost run toward your rescuers, overjoyed." +
		"\nYou feel dizzy with hunger" +
		"\nAs you reach the helicopter you collapse" +
		"\nYou were still hours away from the nearest hospital" +
		"\n\n YOU HAVE DIED" + "\n\nPress Enter to Restart Game";
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
	void State_bonfire(){
		bonfire = true;
		if (dinner == true) {
			textObject.text = "You throw the wood from the raft onto the fire" +
			"\nThe fire swells with life" +
			"\n\nPress Enter to continue";
			if (Input.GetKeyDown (KeyCode.Return)) {
				myState = States.win;
			}
		} else if (dinner == false && crab == true) {
			textObject.text = "You throw the wood from the raft onto the fire" +
			"\nThe fire swells with life" +
			"\nYou still feel hungry" +
			"\n\nPress Enter to continue" +
			"\nPress C to cook Crab";
			if (Input.GetKeyDown (KeyCode.Return)) {
				myState = States.starve;
			}
			if (Input.GetKeyDown (KeyCode.C)) {
				myState = States.dinner;
			}
		} else if (dinner == false && crab == false) {
			textObject.text = "You throw the wood from the raft onto the fire" +
			"\nThe fire swells with life" +
			"\nYou still feel hungry" +
			"\n\nPress Enter to continue";
			if (Input.GetKeyDown (KeyCode.Return)) {
				myState = States.starve;
			}
		}	
	}
	void State_startFire(){
		if (crab == true && brokeRaft == true && dinner == false) {
			textObject.text = "You start a fire" +
			"\nThe heat feels nice" +
			"\nIt lights up the dark night" +
			"\nthe fire isn't very big" +
			"\nYou feel hungry" +
			"\n\nPress C to cook Crab" +
			"\nPress R to add wood from the Raft";
		} else if (crab == false && brokeRaft == true && dinner == false) {
			textObject.text = "You start a fire" +
			"\nThe heat feels nice" +
			"\nIt lights up the dark night" +
			"\nthe fire isn't very big" +
			"\nYou feel hungry" +
			"\nPress R to add wood from the Raft";
		} else if (crab == true && brokeRaft == false && dinner == false) {
			textObject.text = "You start a fire" +
			"\nThe heat feels nice" +
			"\nIt lights up the dark night" +
			"\nthe fire isn't very big" +
			"\nYou feel hungry" +
			"\n\nPress C to cook Crab";
		} else if (crab == true && brokeRaft == true && dinner == true) {
			textObject.text = "You start a fire" +
			"\nThe heat feels nice" +
			"\nIt lights up the dark night" +
			"\nthe fire isn't very big" +
			"\n" +
			"\nPress R to add wood from the Raft";
		} else if (crab == true && brokeRaft == false && dinner == true) {
			textObject.text = "You start a fire" +
				"\nThe heat feels nice" +
				"\nIt lights up the dark night" +
				"\nthe fire isn't very big" +
				"\n\nPress Enter to continue";
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.bonfire;
		}
		else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.dinner;
		}
		else if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.missFlight;
		}
	}
	void State_areYouSure(){
		textObject.text = "You will not be able to return to other locations" +
			"\nAre you sure you want to continue?" +
			"\nY/N?";
		if (Input.GetKeyDown (KeyCode.Y)) {
			myState = States.startFire;
		} else if (Input.GetKeyDown (KeyCode.N)) {
			myState = States.start;
		}
	}
	void State_dinner(){
		dinner = true;
		textObject.text = "You cook and eat the crab" +
		"\nPress Enter to continue";
		if (bonfire == true) {
			if (Input.GetKeyDown (KeyCode.Return)) {
				myState = States.bonfire;
			}
		} else if (bonfire == false) {
			if (Input.GetKeyDown (KeyCode.Return)) {
				myState = States.startFire;
			}
		}
	}
	void State_missFlight(){
        textObject.text = "You hear helicopter blades whirring" +
        	"\nYou look at your pathetic fire and realize you should have made it bigger" +
        	"\nYou Jump up and down flailing your arms and shouting" +
        	"\nThe helicopter passes over your small island" +
        	"\nYou sit down and feel water." +
        	"\nYou realize the tide has risen with the moon." +
        	"\nThe water puts out the fire" +
        	"\nThe island is soon completely submerged, as are you." +
			"\n\nYOU HAVE DIED" + "\n\nPress Enter to Restart Game";
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
	void State_win(){
		textObject.text = "You hear helicopter blades whirring" +
			"\nYou jump up and down flailing your arms" +
			"\nYou are grateful for your giant signal fire" +
			"\nHelicopter heads toward your island and lands near you" +
			"\nYou almost run toward your rescuers, overjoyed." +
			"\n\nYOU HAVE SURVIVED" + 
            "\n\nPress Enter to Restart Game";
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void restartCurrentScene()
    {
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
