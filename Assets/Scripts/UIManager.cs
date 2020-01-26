using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text healthText;
    public Text hunger;
    public HealthSystem HealthSystem;
    public HungerSystem HungerSystem;
    public InventoryUI InventoryUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // UI Components
    // Update is called once per frame
    void Update()
    {
        healthText.text = HealthSystem.GetHealth().ToString();
        hunger.text = HungerSystem.GetHungerLevel().ToString();
    }
    public void ToggleInventory()
    {
        InventoryUI.Toggle();
    }
}
