using UnityEngine;

namespace myInput
{
    public static class InputManager
    {

#region Left
        public static bool moveLeft()
        {
            return Input.GetKey(KeyBinds.moveLeft);
        }

#endregion

#region Right
        public static bool moveRight()
        {
            return Input.GetKey(KeyBinds.moveRight);
        }

        #endregion

#region Dash
        public static bool getdash()
        {
            return Input.GetKey(KeyBinds.dash);
        }
#endregion

#region Jump
        public static bool getJump()
        {
            return Input.GetKey(KeyBinds.jump) || Input.GetKey(KeyBinds.altJump);
        }

        public static bool getJumpDown()
        {
            return Input.GetKeyDown(KeyBinds.jump) || Input.GetKeyDown(KeyBinds.altJump);
        }

        public static bool getJumpUp()
        {
            return Input.GetKeyUp(KeyBinds.jump) || Input.GetKeyUp(KeyBinds.altJump);
        }
        #endregion

#region Crouch
        public static bool crouch()
        {
            return Input.GetKey(KeyBinds.crouch);
        }

#endregion

#region SyncRecord
        public static bool startSync()
        {
            return Input.GetKey(KeyBinds.startSync);
        }
        public static bool recordSync()
        {
            return Input.GetKey(KeyBinds.recordSync);
        }
        public static bool toggleSync()
        {
            return Input.GetKey(KeyBinds.toggleSync);
        }

#endregion

#region Attack
        public static bool attack()
        {
            return Input.GetKey(KeyBinds.attack);
        }

        #endregion

#region Interact
        public static bool interact()
        {
            return Input.GetKey(KeyBinds.interact);
        }
#endregion


    }
}