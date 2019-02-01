using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card" , menuName = "Cards/Empty Card")]
public class Card : ScriptableObject{
	
	public string cardName;
	public string description;
	public int manaCost;
	public int damage;
	public int heal;
	public Sprite cardSprite;
	public UnityEngine.Events.UnityEvent cardSpecial;

	public void CardMove(){
		cardSpecial.Invoke();
	}

}
