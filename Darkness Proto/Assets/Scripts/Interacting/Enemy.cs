﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public MonsterType monsterSpecies;

    public void MoveEnemy(GameObject[] player)
    {
        switch(monsterSpecies.monsterName)
        {
            case "Skeleton Swordsman":
                if(GetComponent<EnemyStats>().currentPosition != 4)
                {
                    int chosenPosition = Random.Range(0, 2);
                    monsterSpecies.skill1.UseSkillOnEnemyMonster(this, player[chosenPosition].GetComponent<PlayerStats>());
                }
                else
                {
                    int chosenPosition = Random.Range(0, 1);
                    monsterSpecies.skill2.UseSkillOnEnemyMonster(this, player[chosenPosition].GetComponent<PlayerStats>());
                    monsterSpecies.skill2.UseSkillOnSelfMonster(this);
                }
                break;
        }
    }
}
