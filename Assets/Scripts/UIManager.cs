using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Slider healthBar;
    [SerializeField] Slider energyBar;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateSliders(GameObject gameObject)
    {
        healthBar.value = gameObject.GetComponent<PlayerAvatar>().Health;
        energyBar.value = gameObject.GetComponent<PlayerAvatar>().Energy;
    }

    public void GameOver()
    {
        healthBar.value = 0;
    }
}
