using UnityEngine;

namespace myInput
{
    /// <summary>
    /// Our Custom Input Manager
    /// </summary>
    public static class InMan
    {
        public static float getHorizontal()
        {
            float value = 0.0f;
            if (getMoveLeft())
            {
                value -= 1.0f;
            }

            if (getMoveRight())
            {
                value += 1.0f;
            }
            return value;
        }

        #region Left
        public static bool getMoveLeft()
        {
            return Input.GetKey(KeyBinds.moveLeft);
        }

        public static bool getMoveLeftUp()
        {
            return Input.GetKeyUp(KeyBinds.moveLeft);
        }
        public static bool getMoveLeftDown()
        {
            return Input.GetKeyDown(KeyBinds.moveLeft);
        }
        #endregion

        #region Right
        public static bool getMoveRight()
        {
            return Input.GetKey(KeyBinds.moveRight);
        }

        public static bool getMoveRightDown()
        {
            return Input.GetKeyDown(KeyBinds.moveRight);
        }

        public static bool getMoveRightUp()
        {
            return Input.GetKeyUp(KeyBinds.moveRight);
        }
        #endregion

        #region Dash
        public static bool getDash()
        {
            return Input.GetKey(KeyBinds.dash);
        }
        public static bool getDashDown()
        {
            return Input.GetKeyDown(KeyBinds.dash);
        }
        public static bool getDashUp()
        {
            return Input.GetKeyUp(KeyBinds.dash);
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
        public static bool getCrouch()
        {
            return Input.GetKey(KeyBinds.crouch);
        }
        public static bool getCrouchDown()
        {
            return Input.GetKeyDown(KeyBinds.crouch);
        }
        public static bool getCrouchUp()
        {
            return Input.GetKeyUp(KeyBinds.crouch);
        }
        #endregion

        #region StartSync
        public static bool getStartSync()
        {
            return Input.GetKey(KeyBinds.startSync);
        }
        public static bool getStartSyncDown()
        {
            return Input.GetKeyDown(KeyBinds.startSync);
        }
        public static bool getStartSyncUp()
        {
            return Input.GetKeyUp(KeyBinds.startSync);
        }
        #endregion

        #region RecordSync
        public static bool getRecordSync()
        {
            return Input.GetKey(KeyBinds.recordSync);
        }
        public static bool getRecordSyncDown()
        {
            return Input.GetKeyDown(KeyBinds.recordSync);
        }
        public static bool getRecordSyncUp()
        {
            return Input.GetKeyUp(KeyBinds.recordSync);
        }
        #endregion

        #region ToggleSync
        public static bool getToggleSync()
        {
            return Input.GetKey(KeyBinds.toggleSync);
        }
        public static bool getToggleSyncDown()
        {
            return Input.GetKeyDown(KeyBinds.toggleSync);
        }
        public static bool getToggleSyncUp()
        {
            return Input.GetKeyUp(KeyBinds.toggleSync);
        }
        #endregion

        #region Attack
        public static bool getAttack()
        {
            return Input.GetKey(KeyBinds.attack);
        }
        public static bool getAttackDown()
        {
            return Input.GetKeyDown(KeyBinds.attack);
        }
        public static bool getAttackUp()
        {
            return Input.GetKeyUp(KeyBinds.attack);
        }
        #endregion

        #region Interact
        public static bool getInteract()
        {
            return Input.GetKey(KeyBinds.interact);
        }
        public static bool getInteractDown()
        {
            return Input.GetKeyDown(KeyBinds.interact);
        }
        public static bool getInteractUp()
        {
            return Input.GetKeyUp(KeyBinds.interact);
        }
        #endregion
    }
}