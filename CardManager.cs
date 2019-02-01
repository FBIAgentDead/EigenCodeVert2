using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour {

	public List<Card> card = new List<Card>();
	private CharacterStats thisStats;

	void Start()
	{
		thisStats = GetComponent<CharacterStats>();
	}

	public void UseCard(int index){
		if(thisStats.canAttack){
			thisStats.health += card[index].heal;
			thisStats.damageBuff += card[index].damage;
			thisStats.mana -= card[index].manaCost;
			card[index].CardMove();
		}
	}

}
