using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : ItemBase
{
    [SerializeField]PlayerManager playerManager;

    public override void Activate()
    {
        playerManager.playerSpeed = 5f;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
