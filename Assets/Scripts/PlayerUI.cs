using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI speedText;
    [SerializeField] private TextMeshProUGUI ammoText;
    [SerializeField] private Player player;

    private void Update()
    {
        speedText.text = "Speed " + (int)player.Speed;
        ammoText.text = "AMMO " + (int)player.Ammo;
    }
}
