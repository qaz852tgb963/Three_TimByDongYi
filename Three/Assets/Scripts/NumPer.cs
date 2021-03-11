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

    #endregion


    #region 函式



    #endregion

    
    #region 事件

    private void Start()
    {
        
    }
    
    #endregion

}
