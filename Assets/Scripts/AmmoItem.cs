using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoItem : Item
{
    public override void Use(Player player)
    {
        player.AmmoUp();
    }
}
