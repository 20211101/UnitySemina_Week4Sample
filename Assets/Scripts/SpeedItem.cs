using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedItem : Item
{
    public override void Use(Player player)
    {
        player.SpeedUp();
    }
}
