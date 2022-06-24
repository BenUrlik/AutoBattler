using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public enum Traits { Head, Legs, Arms, Body };
    public enum Stats { Attack, Defense, Health, Speed };
    public int Level;
    public int UnitCount;

    void Awake() {
        RandomizeBodyParts();
    }

    void Start() {
        Level = 1;
        UnitCount = 1;
    }

    void Update() {
        if(UnitCount == 3) {
            // LevelUpgrade();
        }
    }

    void RandomizeBodyParts() {
        // Legs: Select a random number and choose body part
        // Arms: Select a random number and choose body part 
        // Head: Select a random number and choose body part
        // Body: Select a random number and choose body part

        // Enum.health += 20; 
        // Enum.defense += 20; 
        // Enum.speed += 20;
        // Enum.attack += 20;  
    }

    void UpdateTraits(Traits bodyPart, Traits newTrait) {
        // Head = ? :
    }
}
