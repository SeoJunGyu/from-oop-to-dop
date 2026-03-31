using System.Collections.Generic;
using UnityEngine;

public enum ElementType
{
    None,
    Fire,
    Water,
    Earth,
    Air
}

public enum Grade
{
    Normal,
    Magic,
    Rare,
    Unique,
}

public class Sword : MonoBehaviour
{
    public string Name;
    public int AttackValue;
    public ElementType Type;
    public Grade Grade;
    public List<string> Options;

    public override string ToString()
    {
        string colorCode = Grade switch
        {
            Grade.Normal => "#FFFFFF",
            Grade.Magic => "#4EA5F5",
            Grade.Rare => "#F5D64E",
            Grade.Unique => "#C74EF5",
            _ => "#FFFFFF"
        };

        string optionText = Options != null && Options.Count > 0
            ? string.Join("\n    - ", Options)
            : "없음";

        return $"<color={colorCode}><b>[{Grade}] {Name}</b></color>\n" +
                $"<b>공격력:</b> {AttackValue}\n" +
                $"<b>속성:</b> {Type}\n" +
                $"<b>옵션:</b>\n    - {optionText}";
    }
}
