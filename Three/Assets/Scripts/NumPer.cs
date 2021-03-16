using UnityEngine;

public class NumPer : MonoBehaviour
{

    #region 屬性

    [Header("是否碰到牆壁_上下左右")]
    public bool bHitWallUp;
    public bool bHitWallDown;
    public bool bHitWallLeft;
    public bool bHitWallRight;

    [Header("是否碰到其他數字格子_上下左右")]
    public bool bHitNumPerUp;
    public bool bHitNumPerDown;
    public bool bHitNumPerLeft;
    public bool bHitNumPerRight;

    [Header("射線長度")]
    public float fHitLine = 90f;
    //自己
    private RectTransform rect;

    #endregion


    #region 方法

    //private void SettingLen()
    //{
    //    Gizmos.color = Color.black;
    //    Gizmos.DrawRay(transform.position, Vector3.up * fHitLine);
    //    Gizmos.color = Color.blue;
    //    Gizmos.DrawRay(transform.position, Vector3.down * fHitLine);

    //    Gizmos.color = Color.yellow;
    //    Gizmos.DrawRay(transform.position, Vector3.left * fHitLine);
    //    Gizmos.color = Color.red;
    //    Gizmos.DrawRay(transform.position, Vector3.right * fHitLine);
    //}

    public void CheckWall()
    {
        RaycastHit2D HitWallUp = Physics2D.Raycast(transform.position, Vector2.up, fHitLine, 1 << 11);
        RaycastHit2D HitWallDown= Physics2D.Raycast(transform.position, Vector2.down, fHitLine, 1 << 11);
        RaycastHit2D HitWallLeft= Physics2D.Raycast(transform.position, Vector2.left, fHitLine, 1 << 11);
        RaycastHit2D HitWallRight= Physics2D.Raycast(transform.position, Vector2.right, fHitLine, 1 << 11);
        
        if (HitWallUp && HitWallUp.transform.name == "牆壁_上")
        {
            bHitWallUp = true;
        }
        else
        {
            bHitWallUp = false;
        }
        
        if (HitWallDown && HitWallDown.transform.name == "牆壁_下")
        {
            bHitWallDown = true;
        }
        else
        {
            bHitWallDown = false;
        }
        
        if (HitWallLeft && HitWallLeft.transform.name == "牆壁_左")
        {
            bHitWallLeft = true;
        }
        else
        {
            bHitWallLeft = false;
        }
        
        if (HitWallRight && HitWallRight.transform.name == "牆壁_右")
        {
            bHitWallRight = true;
        }
        else
        {
            bHitWallRight = false;
        }


    }
    
    public void CheckNumPer()
    {
        RaycastHit2D HitNumPerUp = Physics2D.Raycast(transform.position, Vector2.up, fHitLine, 1 << 12);
        RaycastHit2D HitNumPerDown= Physics2D.Raycast(transform.position, Vector2.down, fHitLine, 1 << 12);
        RaycastHit2D HitNumPerLeft= Physics2D.Raycast(transform.position, Vector2.left, fHitLine, 1 << 12);
        RaycastHit2D HitNumPerRight= Physics2D.Raycast(transform.position, Vector2.right, fHitLine, 1 << 12);
        
        if (HitNumPerUp && HitNumPerUp.transform.tag == "NumPer_Tag")
        {
            bHitNumPerUp = true;
        }
        else
        {
            bHitNumPerUp = false;
        }
        
        if (HitNumPerDown && HitNumPerDown.transform.tag == "NumPer_Tag")
        {
            bHitNumPerDown = true;
        }
        else
        {
            bHitNumPerDown = false;
        }
        
        if (HitNumPerLeft && HitNumPerLeft.transform.tag == "NumPer_Tag")
        {
            bHitNumPerLeft = true;
        }
        else
        {
            bHitNumPerLeft = false;
        }
        
        if (HitNumPerRight && HitNumPerRight.transform.tag == "NumPer_Tag")
        {
            bHitNumPerRight = true;
        }
        else
        {
            bHitNumPerRight = false;
        }


    }

    #endregion


    #region 事件

    private void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    private void Update()
    {
        CheckWall();
        CheckNumPer();
    }

    //private void OnDrawGizmos()
    //{
    //    settingLen();
    //}

    #endregion

}
