using UnityEngine;

public class gamemanager : MonoBehaviour
{
    [Header("slime")]
    public Transform slime;
    [Header("TurtleShell")]
    public Transform TurtleShell;
    [Header("虛擬搖桿")]
    public FixedJoystick joystick;
    [Header("旋轉速度"),Range(0.1f, 20f)]
    public float turn = 1.5f;

    private void Start()
    {
        print("開始事件");
    }

    private void Update()
    {
        print("更新事件");
        print(joystick.Vertical);

        slime.Rotate(0, joystick.Horizontal, 0);
        TurtleShell.Rotate(0, joystick.Horizontal * turn , 0);
    }
}
