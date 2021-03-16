using UnityEngine;

public class NumPerMsnager : MonoBehaviour
{    
    #region 屬性

    [Header("生成的數字紙")]
    public RectTransform NumPer_Instant;
    [Header("生成的數字紙位置")]
    public Vector2[] V2NumPer_L = {
        new Vector2(-224,24),
        new Vector2(-74,24),
        new Vector2(76,24),
        new Vector2(226,24),
        
        new Vector2(-224,-126),
        new Vector2(-74,-126),
        new Vector2(76,-126),
        new Vector2(226,-126),

        new Vector2(-224,-276),
        new Vector2(-74,-276),
        new Vector2(76,-276),
        new Vector2(226,-276),
        
        new Vector2(-224,-426),
        new Vector2(-74,-426),
        new Vector2(76,-426),
        new Vector2(226,-426),
    };

    #endregion
}
