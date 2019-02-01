using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pluto : MonoBehaviour, IAbilities {
    CharacterStats getStats;
    Animator playAbilitie;
    public GameObject enemyObject;
    private Animator enemy;
    private CharacterStats enemyStats;

    void Awake()
    {
        playAbilitie = GetComponentInChildren<Animator>();
        enemy = enemyObject.GetComponentInChildren<Animator>();
        enemyStats = enemyObject.GetComponent<CharacterStats>();
    }

    public void SpecialAttack(){
        getStats = gameObject.GetComponent<CharacterStats>();
        if (getStats.canAttack){
            Debug.Log("SpecialAttack (Pluto)");
            getStats.mana -= 30;
            enemyStats.health -= 20;
            playAbilitie.Play("AttackAnim");
            enemy.Play("SelfHeal");
        }
	}
    public void MainAttack(){
        getStats = gameObject.GetComponent<CharacterStats>();
        if(getStats.canAttack){
            Debug.Log("MainAttack (Pluto)");
            getStats.mana -= 70;
            enemyStats.health -= 5;
            playAbilitie.Play("AttackAnim");
            enemy.Play("SelfHeal");
        }
	}

    public void SelfBuf(){
        getStats = gameObject.GetComponent<CharacterStats>();
        if(getStats.canAttack){
            playAbilitie.Play("Hit");
            getStats.health += 10;
        }
    }

}
