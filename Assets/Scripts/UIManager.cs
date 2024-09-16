using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Slider healthBar;
    [SerializeField] Slider energyBar;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player != null && !player.GetComponent<PlayerAvatar>().isDead)
        {
            healthBar.value = player.GetComponent<PlayerAvatar>().Health;
            energyBar.value = player.GetComponent<PlayerAvatar>().Energy;
        }
    }
}
