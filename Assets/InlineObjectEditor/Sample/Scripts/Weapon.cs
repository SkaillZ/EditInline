using UnityEngine;
using System.Collections;

[CreateAssetMenu(order = 999999)]
public class Weapon : ScriptableObject
{
    public string weaponName;
    public int attack = 2;
    public int defense = 1;
}
