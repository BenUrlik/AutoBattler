using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Trait Head;
    public Trait Arms;
    public Trait Body;
    public Trait Legs;
    public GameManager GMScript;

    // Start is called before the first frame update
    void Start()
    {
        GMScript = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
