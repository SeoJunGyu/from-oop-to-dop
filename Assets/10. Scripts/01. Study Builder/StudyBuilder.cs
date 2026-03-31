using UnityEngine;

public class StudyBuilder : MonoBehaviour
{
    public void Awake()
    {
        //SwordBuilder sb = new SwordBuilder();

        //var sword = sb.SetRandomGrade().SetName().CreateSword();

        //Sword newSword1 = new SwordBuilder().CreateSword();

        /*
        BlackSmith blackSmith = new BlackSmith();
        
        for(int i = 0; i < 5; i++)
        {
            Grade grade = (Grade)UnityEngine.Random.Range(0, 4);
            Sword newSword = blackSmith.GenerateSword(grade);
            Debug.Log(newSword.ToString());
        }
        */

        BlackSmith a = new BlackSmith();
        a.level = 1;
        BlackSmith b = new BlackSmith();
        b.level = 5;

        var sword = a.GenerateSword(Grade.Unique);
        Debug.Log(sword.ToString());
        var sword2 = b.UpgradeSword(sword);
        Debug.Log(sword2.ToString());
        
    }
}
