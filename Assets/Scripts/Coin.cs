using UnityEngine;

public class Coin : ItemBase
{
    [SerializeField] PlayerManager playerManager;
    public override void Activate()
    {
        playerManager.playerHp = 5;
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
