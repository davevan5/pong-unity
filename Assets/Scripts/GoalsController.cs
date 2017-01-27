using UnityEngine;

public class GoalsController : MonoBehaviour
{
    public GoalController LeftGoalController;
    public GoalController RightGoalController;

    public void RestartGame()
    {
        LeftGoalController.Reset();
        RightGoalController.Reset();
    }
}
