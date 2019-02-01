using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Cards/Powers/DoubleTurn")]
public class DoubleTurn : ScriptableObject {

	public void CardMove(){
		Debug.Log("You can now attack 2 times");
	}

}
