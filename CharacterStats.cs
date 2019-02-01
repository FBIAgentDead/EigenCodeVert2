using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStats : MonoBehaviour {

	public float mana;
	public float manaRegeneration;
	public int health;
	public Slider healthBar;
	public bool canAttack;
	public bool turnBlocked;
	//this wil call the character powers
	IAbilities characterPower;
	CharacterStats statistics;
	[SerializeField]
	private Button specialAttack;
	[SerializeField]
	private Button neutralAttack;
	[SerializeField]
	private Button selfBuff;
	public List<Card> availableCards = new List<Card>();
	public int damageBuff;

	void Start()
	{
		characterPower = gameObject.GetComponent<IAbilities>();
		statistics = gameObject.GetComponent<CharacterStats>();
		specialAttack.onClick.AddListener(characterPower.SpecialAttack);
        neutralAttack.onClick.AddListener(characterPower.MainAttack);
        selfBuff.onClick.AddListener(characterPower.SelfBuf);
	}

	void Update()
	{
		if(mana >= 100){
			canAttack = true;
		}
		else{
			canAttack = false;
		}
		healthBar.value = health;
		if(health <= 0){
            Application.LoadLevel(Application.loadedLevel);
		}
	}

}
