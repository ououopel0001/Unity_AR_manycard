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
    [Header("slime動畫元件")]
    public Animator Anislime;
    [Header("TurtleShell動畫元件")]
    public Animator AniTurtleShell;
    public float size = 0.3f;

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


        slime.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;
    }

    public void Walk()
    {
        print("走路");
        Anislime.SetTrigger("走路觸發");
    }
    public void Run()
    {
        print("疾走");
        Anislime.SetTrigger("疾走觸發");
    }
    public void Dizzy()
    {
        print("暈眩");
        Anislime.SetTrigger("暈眩觸發");
    }
}
