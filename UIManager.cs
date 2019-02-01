using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

	[SerializeField]
	private List<CharacterStats> choosePlayer = new List<CharacterStats>();
	[SerializeField]
	private List<CanvasGroup> playerCanvas = new List<CanvasGroup>();
	[SerializeField]
	private Animator cameraTransition;
	bool turnTrue;

	void Update()
	{
		if(choosePlayer[0].canAttack && turnTrue){
			cameraTransition.Play("player1");
			playerCanvas[0].alpha = 1;
            playerCanvas[0].interactable = true;
            playerCanvas[0].blocksRaycasts = true;
            playerCanvas[1].alpha = 0;
            playerCanvas[1].interactable = false;
            playerCanvas[1].blocksRaycasts = false;
			turnTrue = false;
		}
		if(choosePlayer[1].canAttack && !turnTrue)
		{
            cameraTransition.Play("player2");
            playerCanvas[0].alpha = 0;
			playerCanvas[0].interactable = false;
            playerCanvas[0].blocksRaycasts = false;
            playerCanvas[1].alpha = 1;
            playerCanvas[1].interactable = true;
            playerCanvas[1].blocksRaycasts = true;
			turnTrue = true;
		}
	}

}
