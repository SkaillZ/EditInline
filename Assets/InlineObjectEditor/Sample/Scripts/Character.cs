using UnityEngine;
using System.Collections;
using Skaillz.EditInline;

[CreateAssetMenu(order = 999999)]
public class Character : ScriptableObject
{
    public string characterName;
    public int maxHealth = 10;
    [EditInline] public Weapon weapon;
}
