using UnityEngine;

public class BlackSmith : MonoBehaviour
{
    public int level = 1;

    public Sword GenerateSword(Grade grade)
    {
        SwordBuilder builder = new SwordBuilder();

        //3가지 기본 옵션
        builder.SetGrade(grade).SetName().SetRandomAttackValue();

        //등급에 따른 추가 옵션
        switch (grade)
        {
            case Grade.Magic:
                builder.SetRandomOption();
                break;
            case Grade.Rare:
                builder.SetRandomElementType().SetRandomOption().SetRandomOption();
                break;
            case Grade.Unique:
                builder.SetRandomElementType().SetRandomOption().SetRandomOption().SetRandomOption();
                break;
            default:
                break;
        }

        return builder.CreateSword();
    }

    public Sword UpgradeSword(Sword sword)
    {
        var builder = new SwordBuilder().SetSword(sword);
        
        for(int i = 0; i < level; i++)
        {
            builder.SetRandomOption();
        }

        return builder.CreateSword();
    }
}
