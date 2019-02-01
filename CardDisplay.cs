using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour {

	public List<Text> manaText = new List<Text>();
	public List<Text> damageText = new List<Text>();
    public List<Text> healthText = new List<Text>();
	public List<Text> cardDiscription = new List<Text>();
	public List<Text> cardName = new List<Text>();
	public List<Image> customCardImg = new List<Image>();
	private CardManager getCards;

	void Start()
	{
		getCards = GetComponent<CardManager>();
	}

	void Update()
	{
		DisplayCards();
	}

	private void DisplayCards(){
		for(int i = 0; i < getCards.card.Count; i++){
			manaText[i].text = "" + getCards.card[i].manaCost;
            damageText[i].text = "" + getCards.card[i].damage;
            healthText[i].text = "" + getCards.card[i].heal;
			cardDiscription[i].text = "" + getCards.card[i].description;
            cardName[i].text = "" + getCards.card[i].cardName;
			customCardImg[i].sprite = getCards.card[i].cardSprite;
		}
	}

}
