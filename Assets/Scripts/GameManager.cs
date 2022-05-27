using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState State;
    public static event Action<GameState> OnGameStateChange;

    public enum GameState {
        BuyPhase,
        BattlePhase,
        Victory,
        Defeat,
        BuyStage,
        Pause
    };
    
    void Awake() { Instance = this; }

    // Start is called before the first frame update
    void Start() { UpdateGameState(GameState.BuyPhase); }

    // Update is called once per frame
    void Update() { }

    public void UpdateGameState(GameState newState) {
        State = newState;

        switch (newState) {
            case GameState.BuyPhase:
                break;
            case GameState.BattlePhase:
                Battle();
                break;
            case GameState.Victory:
                break;
            case GameState.Defeat:
                break;
            case GameState.Pause:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

        OnGameStateChange?.Invoke(newState);
        // if(OnGameStateChange != null) {
        //     OnGameStateChange(newState);
        // }
    }

    void Battle() {
        // Loop until no units are left on either side

        // Player unit attacks
        // Unit 01.Attack();
        // Enemy unit gets hit (activate the effects of the traits)
        
        // Enemy unit attacks
        // Player unit gets hit
        
        // Resolve Damage
    }
}
