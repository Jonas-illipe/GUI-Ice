using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    public Healthbar healthBar;
    public void DecrementHealth()
    {
        healthBar.SetHealth(3);
    }
  
}
