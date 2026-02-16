using UnityEngine;

public class SimplePlayer : MonoBehaviour // library สำหรับตอน gameplay
{
    private Rigidbody2D rigid; // สำหรับการเคลื่อนที่
    private Animator anim; // สำหรับ animation

    [Header("Ground And Wall Check")]
    [SerializeField] private float groundDistCheck = 1f; // ระยะ sensor ที่วิ่งไปชนพื้น
    [SerializeField] private float wallDistCheck = 1f; // ระยะ sensor ที่วิ่งไปชนผนัง
    [SerializeField] private LayerMask groundLayer; // หาเฉพาะ layer ของพื้น
    public bool isGrounded = false; // ตรวจชนพื้น
    public bool isWalled = false;  // ตรวจชนกำแพง

    private void Awake() // ทำงานก่อนเข้ามาใน game
    {
        rigid = GetComponent<Rigidbody2D>(); // มันอยู่ที่ gameobject นี้
        anim = GetComponentInChildren<Animator>(); // ใช้ InChildren เพราะ Animator อยู่ที่ลูก
    }
    private void Update() // ทำงานทุก frame
    {
        JumpState(); // ตรวจสถานะว่า อยู่บนพื้น กำลังกระโดด กำลังลงพื้น หรือ wallSlide
        Jump(); // สั่งกระโดดในแบบต่างๆ
        WallSlide(); // สั่ง wallSlide
        InputVal(); // ตรวจ input จากผู้เล่น
        Move(); // สั้งเคลื่อนไหวทั้งบนพื้นและอากาศ
        Flip(); // สั่งหันหน้าไปทางทิศการเคลื่อนที่อัดโนมัต
        GroundAndWallCheck(); // ตรวจจับพื้นและผนัง
        Animation(); // สั่ง animation
    }
    private void JumpState()
    {

    }
    private void Jump()
    {

    }
    private void WallSlide()
    {

    }
    private void InputVal()
    {

    }
    private void Move()
    {

    }
    private void Flip()
    {

    }
    private void GroundAndWallCheck()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, groundDistCheck, groundLayer); // sensor พื้น
        isWalled = Physics2D.Raycast(transform.position, transform.right, wallDistCheck, groundLayer); // sensor ผนัง
    }
    private void OnDrawGizmos() // กราฟฟิกแสดงผลของ sensor ตรวจจับพื้นและผนัง
    {
        Gizmos.color = Color.blue; // เส้นสีน้ำเงิน
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * groundDistCheck); // เส้น sensor ตรวจพื้น
        Gizmos.color = Color.red; // เส้นแดง
        Gizmos.DrawLine(transform.position, transform.position + transform.right * wallDistCheck); // เส้น sensor ตรวจผนัง
    }
    private void Animation()
    {

    }
}
