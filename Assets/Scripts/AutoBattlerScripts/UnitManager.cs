using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    public static List<Character> PlayerUnits;
    public static List<Character> Playerbench;
    public static List<Character> EnemyUnits;

    void Update() {
    
    }

    void LevelUpgrade() {
        // plays animation
        // delete two of the units
        // upgrade the player unit
    }

    void Attack(Character OtherUnit) {
        // OtherUnit -= attack;
        // handleEffects(); 
        // Calculate player damage
    }

    void HandleEffects() {
        //  if (enemyUnit.thorns) { 
        // this.health -= thornsdamage;
        // }

        // if (enemyUnit.poison) {
        // apply status debuff
        // }
    }

    int GetCharCount(Character unit) {
        // Search the playerUnits
        // Search the playerBench
        // return character Count
        return 0;
    }
}
