//this class wil manage both players mana and tell the players when they can attack

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaManager : MonoBehaviour {
	[SerializeField]
	List<CharacterStats> players = new List<CharacterStats>();
	[SerializeField]
	private List<Slider> manaBars = new List<Slider>();

	void Update()
	{
		if(!players[0].canAttack){
			if(!players[1].canAttack)
				SlideUp();
		}
		ChoosePlayer();
	}

	private void SlideUp()
	{
        players[0].mana += players[0].manaRegeneration/100;
        players[1].mana += players[1].manaRegeneration/100;
		for(int i = 0; i < manaBars.Count; i++){
			manaBars[i].value = players[i].mana;
		}
	}
	private void ChoosePlayer(){
		if(players[0].mana  >= 100 && players[1].mana >= 100){
			int i = Random.Range(1,3); 
			if(i == 1){
				players[0].mana = 99;
				players[0].canAttack = false;
			}
			else
			{
                players[1].mana = 99;
                players[1].canAttack = false;
			}
		}
	}
	
}
