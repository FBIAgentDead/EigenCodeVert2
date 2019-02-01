using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Cards/Powers/ShieldCard")]
public class ShieldCard : ScriptableObject {

	public void CardMove(){
		Debug.Log("Card has casted a Shield!");
		// here comes the real behavior behind the protection
	}
}
