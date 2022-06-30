using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public enum Traits { Human, Snake, Bull, Shark };
    public int Level;
    public int UnitCount;
    public int Attack, Defense, Health, Speed;
    public Traits Head, Legs, Arms, Body;

    void Start() {
        Level = 1;
        UnitCount = 1;
        RandomizeBodyParts();
    }

    void Update() {
        if(UnitCount == 3) {
            // LevelUpgrade();
        }
    }

    void RandomizeBodyParts() {
        Head = Traits.Human;
        Body = Traits.Human;
        Legs = Traits.Human;
        Arms = Traits.Human;

        Attack = 20; 
        Defense = 20; 
        Health = 20;
        Speed = 20;  
    }

    void UpdateTraits(string BodyPart, Traits newTrait) {
        
    }
}
