using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsScript : MonoBehaviour
{

    public Slider healthBar;
    public Slider manaBar;
    public Slider staminaBar;
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        healthBar.value += 20;
        Destroy(button);
    }

    public void OnClick2()
    {
        manaBar.value += 10;
        Destroy(button);
    }
}
