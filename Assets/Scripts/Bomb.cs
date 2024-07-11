using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : ItemBase
{
  
   [SerializeField] PlayerManager playerManager;


    public override void Activate()
    {
      playerManager.playerHp = 0;   
    }

}
