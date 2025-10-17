using UnityEngine;

namespace KsBattle.CombatObjects
{
    public class CombatUnit : CombatObject
    {
        public CombatUnit(ulong dynamicId, 
            Vector3 worldPosition, Vector3 worldForward, Vector3 worldScale) 
            : base(dynamicId, worldPosition, worldForward, worldScale)
        {
        }
    }
}