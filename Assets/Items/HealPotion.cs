using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPotion : MonoBehaviour
{
    public void HealSelectedUnit(Units selectedUnit)
    {
        if (selectedUnit == null)
        {
            Debug.LogWarning("No unit selected.");
            return;
        }

        // Fully heal the selected unit
        selectedUnit.HealToFull();

        Debug.Log(selectedUnit.gameObject.name + " has been fully healed.");
    }
}
